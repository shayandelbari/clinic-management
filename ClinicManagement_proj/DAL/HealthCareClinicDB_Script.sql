-- Close all connections and drop database if exists
USE master;
GO

IF DB_ID('HealthCareClinicDB') IS NOT NULL
    DROP DATABASE HealthCareClinicDB;
GO

CREATE DATABASE HealthCareClinicDB;
GO

USE HealthCareClinicDB;
GO

-- DROP STORED PROCEDURES
IF OBJECT_ID('dbo.sp_GetAvailableSlots', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetAvailableSlots;
GO

IF OBJECT_ID('dbo.sp_CancelAppointment', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_CancelAppointment;
GO

IF OBJECT_ID('dbo.sp_BookAppointment', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_BookAppointment;
GO

IF OBJECT_ID('dbo.sp_GetDoctorCurrentSchedule', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetDoctorCurrentSchedule;
GO

-- DROP VIEWS
IF OBJECT_ID('dbo.vw_DoctorWorkloadStats', 'V') IS NOT NULL
    DROP VIEW dbo.vw_DoctorWorkloadStats;
GO

IF OBJECT_ID('dbo.vw_PatientRecordsSummary', 'V') IS NOT NULL
    DROP VIEW dbo.vw_PatientRecordsSummary;
GO

IF OBJECT_ID('dbo.vw_UpcomingAppointments', 'V') IS NOT NULL
    DROP VIEW dbo.vw_UpcomingAppointments;
GO

IF OBJECT_ID('dbo.vw_DoctorCurrentSchedule', 'V') IS NOT NULL
    DROP VIEW dbo.vw_DoctorCurrentSchedule;
GO

-- DROP TABLES (correct FK order: children → parents)
IF OBJECT_ID('dbo.Appointment', 'U') IS NOT NULL
    DROP TABLE dbo.Appointment;
GO

IF OBJECT_ID('dbo.DoctorSchedule', 'U') IS NOT NULL
    DROP TABLE dbo.DoctorSchedule;
GO

IF OBJECT_ID('dbo.DoctorSpecialties', 'U') IS NOT NULL
    DROP TABLE dbo.DoctorSpecialties;
GO

IF OBJECT_ID('dbo.TimeSlots', 'U') IS NOT NULL
    DROP TABLE dbo.TimeSlots;
GO

IF OBJECT_ID('dbo.Patient', 'U') IS NOT NULL
    DROP TABLE dbo.Patient;
GO

IF OBJECT_ID('dbo.Doctor', 'U') IS NOT NULL
    DROP TABLE dbo.Doctor;
GO

IF OBJECT_ID('dbo.Specialties', 'U') IS NOT NULL
    DROP TABLE dbo.Specialties;
GO

IF OBJECT_ID('dbo.UserRoles', 'U') IS NOT NULL
    DROP TABLE dbo.UserRoles;
GO

IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
    DROP TABLE dbo.Users;
GO

IF OBJECT_ID('dbo.Roles', 'U') IS NOT NULL
    DROP TABLE dbo.Roles;
GO


PRINT 'All views, tables, and stored procedures have been dropped successfully.';
GO

-- TABLE: Users
CREATE TABLE dbo.Users (
    Id INT NOT NULL PRIMARY KEY,
    Username VARCHAR(32) NOT NULL UNIQUE,
    PasswordHash VARCHAR(256) NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO

-- TABLE: Roles
CREATE TABLE dbo.Roles (
    Id INT NOT NULL PRIMARY KEY,
    RoleName VARCHAR(64) NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO

-- TABLE: UserRoles (junction table)
CREATE TABLE dbo.UserRoles (
    UserId INT NOT NULL,
    RoleId INT NOT NULL,
    CONSTRAINT PK_UserRoles PRIMARY KEY (UserId, RoleId),
    CONSTRAINT FK_UserRoles_Users FOREIGN KEY (UserId) REFERENCES dbo.Users(Id) ON DELETE CASCADE,
    CONSTRAINT FK_UserRoles_Roles FOREIGN KEY (RoleId) REFERENCES dbo.Roles(Id) ON DELETE CASCADE
);
GO

-- TABLE: Patient
CREATE TABLE dbo.Patient(
    Id INT NOT NULL PRIMARY KEY,
    FirstName VARCHAR(64) NOT NULL,
    LastName VARCHAR(64) NOT NULL,
    InsuranceNumber VARCHAR(24) NOT NULL UNIQUE,
    DateOfBirth DATETIME2(7) NOT NULL,
    PhoneNumber VARCHAR(20) NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT CK_Patient_InsuranceNumber CHECK (
        -- Quebec Health Card: 4 letters + 8 digits + 2 digits (AAAA12345678 with space before last 2 digits)
        (InsuranceNumber LIKE '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9] [0-9][0-9]'
        OR
        InsuranceNumber LIKE '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
        OR
        -- Canadian Health Card (generic): 10 digits
        InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
        OR
        -- Ontario Health Card: 10 digits + 2 letters (1234567890-AB with optional hyphen)
        (InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[A-Z][A-Z]'
        OR
        InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z]')
    )
);
GO

-- TABLE: Specialties
CREATE TABLE dbo.Specialties (
    Id INT NOT NULL PRIMARY KEY,
    Name VARCHAR(64) NOT NULL UNIQUE
);
GO

-- TABLE: Doctor
CREATE TABLE dbo.Doctor(
    Id INT NOT NULL PRIMARY KEY,
    FirstName VARCHAR(64) NOT NULL,
    LastName VARCHAR(64) NOT NULL,
    LicenseNumber VARCHAR(24) NOT NULL UNIQUE,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO

-- TABLE: DoctorSpecialties (junction table)
CREATE TABLE dbo.DoctorSpecialties (
    DoctorId INT NOT NULL,
    SpecialtyId INT NOT NULL,
    CONSTRAINT PK_DoctorSpecialties PRIMARY KEY (DoctorId, SpecialtyId),
    CONSTRAINT FK_DoctorSpecialties_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE CASCADE,
    CONSTRAINT FK_DoctorSpecialties_Specialties FOREIGN KEY (SpecialtyId) REFERENCES dbo.Specialties(Id) ON DELETE CASCADE
);
GO

-- TABLE: DoctorSchedule
CREATE TABLE dbo.DoctorSchedule(
    Id INT NOT NULL PRIMARY KEY,
    DoctorId INT NOT NULL,
    DayOfWeek VARCHAR(10) NOT NULL CHECK (DayOfWeek IN ('SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY')),
    WorkStartTime DATETIME2(7) NOT NULL,
    WorkEndTime DATETIME2(7) NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_DoctorSchedule_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE CASCADE
);
GO

-- TABLE: TimeSlots
CREATE TABLE dbo.TimeSlots(
    Id INT NOT NULL PRIMARY KEY,
    HourOfDay INT NOT NULL,
    MinuteOfHour INT NOT NULL,
    CONSTRAINT UQ_TimeSlots_Time UNIQUE (HourOfDay, MinuteOfHour),
    CONSTRAINT CK_TimeSlots_Hour CHECK (HourOfDay >= 0 AND HourOfDay <= 23),
    CONSTRAINT CK_TimeSlots_Minute CHECK (MinuteOfHour >= 0 AND MinuteOfHour <= 59)
);
GO

-- TABLE: Appointment
CREATE TABLE dbo.Appointment(
    Id INT NOT NULL PRIMARY KEY,
    Date DATE NOT NULL,
    Notes VARCHAR(512) NULL,
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    TimeSlotId INT NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Appointment_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE NO ACTION,
    CONSTRAINT FK_Appointment_Patient FOREIGN KEY (PatientId) REFERENCES dbo.Patient(Id) ON DELETE NO ACTION,
    CONSTRAINT FK_Appointment_TimeSlot FOREIGN KEY (TimeSlotId) REFERENCES dbo.TimeSlots(Id) ON DELETE NO ACTION,
    CONSTRAINT UQ_Appointment_DateTime UNIQUE (DoctorId, Date, TimeSlotId)
);
GO

-- INSERT SAMPLE DATA

-- Roles
INSERT INTO dbo.Roles (Id, RoleName, CreatedAt, ModifiedAt) VALUES
(1, 'Administrator', GETDATE(), GETDATE()),
(2, 'Doctor', GETDATE(), GETDATE()),
(3, 'Receptionist', GETDATE(), GETDATE());
GO

-- Users
INSERT INTO dbo.Users (Id, Username, PasswordHash, CreatedAt, ModifiedAt) VALUES
(1, 'admin', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE()),
(2, 'dr_who', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE()),
(3, 'dr_smith', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE()),
(4, 'dr_jones', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE()),
(5, 'receptionist1', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE()),
(6, 'receptionist2', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
GO

-- UserRoles
INSERT INTO dbo.UserRoles (UserId, RoleId) VALUES
(1, 1), -- admin -> Administrator
(2, 2), -- dr_who -> Doctor
(3, 2), -- dr_smith -> Doctor
(4, 2), -- dr_jones -> Doctor
(5, 3), -- receptionist1 -> Receptionist
(6, 3); -- receptionist2 -> Receptionist
GO

-- Specialties
INSERT INTO dbo.Specialties (Id, Name) VALUES
(1, 'General Practice'),
(2, 'Cardiology'),
(3, 'Pediatrics');
GO

-- Doctors
INSERT INTO dbo.Doctor (Id, FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES
(1, 'John', 'Who', 'LIC001234', GETDATE(), GETDATE()),
(2, 'Sarah', 'Smith', 'LIC002345', GETDATE(), GETDATE()),
(3, 'Michael', 'Jones', 'LIC003456', GETDATE(), GETDATE());
GO

-- DoctorSpecialties
INSERT INTO dbo.DoctorSpecialties (DoctorId, SpecialtyId) VALUES
(1, 1), -- Dr. Who -> General Practice
(2, 2), -- Dr. Smith -> Cardiology
(3, 3); -- Dr. Jones -> Pediatrics
GO

-- Patients (using Quebec Health Card format: 4 letters + 8 digits + space + 2 digits)
INSERT INTO dbo.Patient (Id, FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES
(1,'Emma','Wilson','1985-03-15','WILE85031500 01','555-0101',GETDATE(),GETDATE()),
(2,'James','Brown','1990-07-22','BROJ90072200 02','555-0102',GETDATE(),GETDATE()),
(3,'Olivia','Davis','1978-11-30','DAVO78113000 03','555-0103',GETDATE(),GETDATE()),
(4,'William','Miller','2015-05-10','MILW15051000 04','555-0104',GETDATE(),GETDATE()),
(5,'Sophia','Garcia','1995-09-18','GARS95091800 05','555-0105',GETDATE(),GETDATE());
GO

-- DoctorSchedule
INSERT INTO dbo.DoctorSchedule (Id, DoctorId, DayOfWeek, WorkStartTime, WorkEndTime, CreatedAt, ModifiedAt) VALUES
-- Dr. Who (Monday-Friday 9AM-5PM)
(1, 1, 'MONDAY', '2025-01-01 09:00:00', '2025-01-01 17:00:00', GETDATE(), GETDATE()),
(2, 1, 'TUESDAY', '2025-01-01 09:00:00', '2025-01-01 17:00:00', GETDATE(), GETDATE()),
(3, 1, 'WEDNESDAY', '2025-01-01 09:00:00', '2025-01-01 17:00:00', GETDATE(), GETDATE()),
(4, 1, 'THURSDAY', '2025-01-01 09:00:00', '2025-01-01 17:00:00', GETDATE(), GETDATE()),
(5, 1, 'FRIDAY', '2025-01-01 09:00:00', '2025-01-01 17:00:00', GETDATE(), GETDATE()),
-- Dr. Smith (Monday-Thursday 8AM-4PM)
(6, 2, 'MONDAY', '2025-01-01 08:00:00', '2025-01-01 16:00:00', GETDATE(), GETDATE()),
(7, 2, 'TUESDAY', '2025-01-01 08:00:00', '2025-01-01 16:00:00', GETDATE(), GETDATE()),
(8, 2, 'WEDNESDAY', '2025-01-01 08:00:00', '2025-01-01 16:00:00', GETDATE(), GETDATE()),
(9, 2, 'THURSDAY', '2025-01-01 08:00:00', '2025-01-01 16:00:00', GETDATE(), GETDATE()),
-- Dr. Jones (Tuesday-Saturday 10AM-6PM)
(10, 3, 'TUESDAY', '2025-01-01 10:00:00', '2025-01-01 18:00:00', GETDATE(), GETDATE()),
(11, 3, 'WEDNESDAY', '2025-01-01 10:00:00', '2025-01-01 18:00:00', GETDATE(), GETDATE()),
(12, 3, 'THURSDAY', '2025-01-01 10:00:00', '2025-01-01 18:00:00', GETDATE(), GETDATE()),
(13, 3, 'FRIDAY', '2025-01-01 10:00:00', '2025-01-01 18:00:00', GETDATE(), GETDATE()),
(14, 3, 'SATURDAY', '2025-01-01 10:00:00', '2025-01-01 18:00:00', GETDATE(), GETDATE());
GO

-- TimeSlots (30-minute intervals from 8AM to 6PM)
DECLARE @hour INT = 8;
DECLARE @minute INT = 0;
DECLARE @slotId INT = 1;

WHILE @hour < 18
BEGIN
    INSERT INTO dbo.TimeSlots (Id, HourOfDay, MinuteOfHour) VALUES (@slotId, @hour, @minute);
    SET @slotId = @slotId + 1;
    SET @minute = @minute + 30;
    IF @minute >= 60
    BEGIN
        SET @minute = 0;
        SET @hour = @hour + 1;
    END
END
GO

-- Appointments (using TimeSlot references)
INSERT INTO dbo.Appointment (Id, PatientId, DoctorId, TimeSlotId, Date, Notes, CreatedAt, ModifiedAt) VALUES
(1, 1, 1, 5, '2025-11-25', 'Annual checkup', GETDATE(), GETDATE()), -- 10:00 AM
(2, 2, 2, 13, '2025-11-26', 'Heart consultation', GETDATE(), GETDATE()), -- 2:00 PM
(3, 3, 1, 7, '2025-11-22', 'Follow-up visit', GETDATE(), GETDATE()), -- 11:00 AM
(4, 4, 3, 15, '2025-11-27', 'Child vaccination', GETDATE(), GETDATE()), -- 3:00 PM
(5, 5, 2, 3, '2025-11-23', 'Cardiac screening', GETDATE(), GETDATE()), -- 9:00 AM
(6, 1, 2, 6, '2025-12-01', 'Blood pressure check', GETDATE(), GETDATE()); -- 10:30 AM
GO

-- VIEW 1: Doctor's Current Schedule
CREATE VIEW dbo.vw_DoctorCurrentSchedule
AS
SELECT 
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    s.Name AS Specialization,
    sc.DayOfWeek,
    CONVERT(VARCHAR(5), sc.WorkStartTime, 108) AS StartTime,
    CONVERT(VARCHAR(5), sc.WorkEndTime, 108) AS EndTime,
    d.LicenseNumber
FROM 
    dbo.Doctor d
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
    LEFT JOIN dbo.DoctorSchedule sc ON d.Id = sc.DoctorId;
GO

-- VIEW 2: Upcoming Appointments Summary
CREATE VIEW dbo.vw_UpcomingAppointments
AS
SELECT 
    a.Id AS AppointmentId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.PhoneNumber,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    s.Name AS Specialization,
    a.Date AS AppointmentDate,
    ts.HourOfDay,
    ts.MinuteOfHour,
    a.Notes,
    a.PatientId,
    a.DoctorId
FROM 
    dbo.Appointment a
    INNER JOIN dbo.Patient p ON a.PatientId = p.Id
    INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
    INNER JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
WHERE 
    a.Date >= CAST(GETDATE() AS DATE);
GO

-- VIEW 3: Patient Medical Records Summary
CREATE VIEW dbo.vw_PatientRecordsSummary
AS
SELECT 
    p.Id AS PatientId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.InsuranceNumber,
    p.DateOfBirth,
    DATEDIFF(YEAR, p.DateOfBirth, GETDATE()) - 
        CASE 
            WHEN MONTH(p.DateOfBirth) > MONTH(GETDATE()) 
                OR (MONTH(p.DateOfBirth) = MONTH(GETDATE()) AND DAY(p.DateOfBirth) > DAY(GETDATE()))
            THEN 1 
            ELSE 0 
        END AS Age,
    p.PhoneNumber,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE PatientId = p.Id) AS TotalAppointments,
    (SELECT MAX(Date) FROM dbo.Appointment WHERE PatientId = p.Id) AS LastAppointmentDate
FROM 
    dbo.Patient p;
GO

-- VIEW 4: Doctor Workload Statistics
CREATE VIEW dbo.vw_DoctorWorkloadStats
AS
SELECT 
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    s.Name AS Specialization,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id AND Date >= CAST(GETDATE() AS DATE)) AS UpcomingAppointments,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id AND Date < CAST(GETDATE() AS DATE)) AS CompletedAppointments,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id) AS TotalAppointments
FROM 
    dbo.Doctor d
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id;
GO

-- PROCEDURE 1: Get Doctor's Current Schedule
CREATE PROCEDURE dbo.sp_GetDoctorCurrentSchedule
    @DoctorId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    IF @DoctorId IS NULL
    BEGIN
        -- Return all doctors' schedules
        SELECT * FROM dbo.vw_DoctorCurrentSchedule
        ORDER BY DoctorName, DayOfWeek;
    END
    ELSE
    BEGIN
        -- Return specific doctor's schedule
        IF NOT EXISTS (SELECT 1 FROM dbo.Doctor WHERE Id = @DoctorId)
        BEGIN
            RAISERROR('Doctor not found', 16, 1);
            RETURN;
        END
        
        SELECT * FROM dbo.vw_DoctorCurrentSchedule
        WHERE DoctorId = @DoctorId
        ORDER BY DayOfWeek;
    END
END
GO

-- PROCEDURE 2: Book New Appointment
CREATE PROCEDURE dbo.sp_BookAppointment
    @PatientId INT,
    @DoctorId INT,
    @AppointmentDate DATE,
    @TimeSlotId INT,
    @Notes VARCHAR(512) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @NewId INT;
    
    -- Validate inputs
    IF NOT EXISTS (SELECT 1 FROM dbo.Patient WHERE Id = @PatientId)
    BEGIN
        RAISERROR('Patient not found', 16, 1);
        RETURN;
    END
    
    IF NOT EXISTS (SELECT 1 FROM dbo.Doctor WHERE Id = @DoctorId)
    BEGIN
        RAISERROR('Doctor not found', 16, 1);
        RETURN;
    END
    
    IF NOT EXISTS (SELECT 1 FROM dbo.TimeSlots WHERE Id = @TimeSlotId)
    BEGIN
        RAISERROR('Time slot not found', 16, 1);
        RETURN;
    END
    
    IF @AppointmentDate < CAST(GETDATE() AS DATE)
    BEGIN
        RAISERROR('Appointment date cannot be in the past', 16, 1);
        RETURN;
    END
    
    -- Check for existing appointment at this time
    IF EXISTS (
        SELECT 1 
        FROM dbo.Appointment 
        WHERE DoctorId = @DoctorId 
            AND Date = @AppointmentDate
            AND TimeSlotId = @TimeSlotId
    )
    BEGIN
        RAISERROR('This time slot is already booked', 16, 1);
        RETURN;
    END
    
    -- Get next available ID
    SELECT @NewId = ISNULL(MAX(Id), 0) + 1 FROM dbo.Appointment;
    
    -- Insert new appointment
    INSERT INTO dbo.Appointment 
        (Id, PatientId, DoctorId, Date, TimeSlotId, Notes, CreatedAt, ModifiedAt)
    VALUES 
        (@NewId, @PatientId, @DoctorId, @AppointmentDate, @TimeSlotId, @Notes, GETDATE(), GETDATE());
    
    -- Return the new appointment details
    SELECT 
        a.Id AS AppointmentId,
        p.FirstName + ' ' + p.LastName AS PatientName,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        a.Date AS AppointmentDate,
        ts.HourOfDay,
        ts.MinuteOfHour,
        a.Notes
    FROM 
        dbo.Appointment a
        INNER JOIN dbo.Patient p ON a.PatientId = p.Id
        INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
        INNER JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
    WHERE 
        a.Id = @NewId;
END
GO

-- PROCEDURE 3: Cancel Appointment
CREATE PROCEDURE dbo.sp_CancelAppointment
    @AppointmentId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Check if appointment exists
    IF NOT EXISTS (SELECT 1 FROM dbo.Appointment WHERE Id = @AppointmentId)
    BEGIN
        RAISERROR('Appointment not found', 16, 1);
        RETURN;
    END
    
    -- Return confirmation with appointment details before deleting
    SELECT 
        a.Id AS AppointmentId,
        p.FirstName + ' ' + p.LastName AS PatientName,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        a.Date AS AppointmentDate,
        ts.HourOfDay,
        ts.MinuteOfHour,
        'Appointment cancelled successfully' AS Message
    FROM 
        dbo.Appointment a
        INNER JOIN dbo.Patient p ON a.PatientId = p.Id
        INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
        INNER JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
    WHERE 
        a.Id = @AppointmentId;
    
    -- Delete the appointment
    DELETE FROM dbo.Appointment WHERE Id = @AppointmentId;
END
GO

-- PROCEDURE 4: Get Available Appointment Slots
CREATE PROCEDURE dbo.sp_GetAvailableSlots
    @DoctorId INT,
    @Date DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Validate doctor exists
    IF NOT EXISTS (SELECT 1 FROM dbo.Doctor WHERE Id = @DoctorId)
    BEGIN
        RAISERROR('Doctor not found', 16, 1);
        RETURN;
    END
    
    DECLARE @DayName VARCHAR(10);
    SET @DayName = UPPER(DATENAME(WEEKDAY, @Date));
    
    -- Return available time slots based on doctor's schedule
    SELECT 
        d.Id AS DoctorId,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        s.Name AS Specialization,
        @Date AS RequestedDate,
        @DayName AS DayOfWeek,
        ts.Id AS TimeSlotId,
        ts.HourOfDay,
        ts.MinuteOfHour,
        CASE WHEN a.Id IS NOT NULL THEN 1 ELSE 0 END AS IsBooked
    FROM 
        dbo.Doctor d
        LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
        LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
        INNER JOIN dbo.DoctorSchedule sc ON d.Id = sc.DoctorId AND sc.DayOfWeek = @DayName
        CROSS JOIN dbo.TimeSlots ts
        LEFT JOIN dbo.Appointment a ON d.Id = a.DoctorId 
            AND a.Date = @Date
            AND a.TimeSlotId = ts.Id
    WHERE 
        d.Id = @DoctorId
        AND CAST(CAST(ts.HourOfDay AS VARCHAR) + ':' + CAST(ts.MinuteOfHour AS VARCHAR) AS TIME) >= CAST(sc.WorkStartTime AS TIME)
        AND CAST(CAST(ts.HourOfDay AS VARCHAR) + ':' + CAST(ts.MinuteOfHour AS VARCHAR) AS TIME) < CAST(sc.WorkEndTime AS TIME)
    ORDER BY 
        ts.HourOfDay, ts.MinuteOfHour;
END
GO