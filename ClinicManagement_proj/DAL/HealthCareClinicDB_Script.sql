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

-- DROP TABLES (in correct order due to foreign keys)
IF OBJECT_ID('dbo.Appointment', 'U') IS NOT NULL
    DROP TABLE dbo.Appointment;
GO

IF OBJECT_ID('dbo.Schedule', 'U') IS NOT NULL
    DROP TABLE dbo.Schedule;
GO

IF OBJECT_ID('dbo.Doctor', 'U') IS NOT NULL
    DROP TABLE dbo.Doctor;
GO

IF OBJECT_ID('dbo.Patient', 'U') IS NOT NULL
    DROP TABLE dbo.Patient;
GO

IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
    DROP TABLE dbo.Users;
GO

PRINT 'All views, tables, and stored procedures have been dropped successfully.';
GO
-- TABLE: Users  (renamed from User)
CREATE TABLE dbo.Users (
    Id INT NOT NULL PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(20) NOT NULL DEFAULT('Receptionist')
);
GO

-- TABLE: Patient
CREATE TABLE dbo.Patient(
    Id INT NOT NULL PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    MedicalNumber VARCHAR(20) NOT NULL UNIQUE,
    PhoneNumber VARCHAR(15) NULL,
    Email VARCHAR(100) NULL,
    CONSTRAINT CK_Patient_MedicalNumber CHECK (
        -- Quebec Health Card: 4 letters + 8 digits + 2 digits (AAAA12345678 with space before last 2 digits)
        (MedicalNumber LIKE '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9] [0-9][0-9]'
        OR
        MedicalNumber LIKE '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
        OR
        -- Canadian Health Card (generic): 10 digits
        MedicalNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
        OR
        -- Ontario Health Card: 10 digits + 2 letters (1234567890-AB with optional hyphen)
        (MedicalNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[A-Z][A-Z]'
        OR
        MedicalNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z]')
    )
);
GO

-- TABLE: Doctor
CREATE TABLE dbo.Doctor(
    Id INT NOT NULL PRIMARY KEY,
    UserId INT NOT NULL UNIQUE,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Specialization VARCHAR(100) NOT NULL,
    Availability VARCHAR(500) NOT NULL,
    CONSTRAINT FK_Doctor_User FOREIGN KEY (UserId) REFERENCES dbo.Users(Id) ON DELETE NO ACTION
);
GO

-- TABLE: Schedule
CREATE TABLE dbo.Schedule(
    Id INT NOT NULL PRIMARY KEY,
    DoctorId INT NOT NULL,
    Schedule VARCHAR(500) NULL,
    EffectiveDate DATETIME NOT NULL,
    CONSTRAINT FK_Schedule_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE NO ACTION
);
GO

-- TABLE: Appointment
CREATE TABLE dbo.Appointment(
    Id INT NOT NULL PRIMARY KEY,
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    CreatedBy INT NOT NULL,
    Description VARCHAR(500) NOT NULL,
    AppointmentDate DATETIME NOT NULL,
    Status VARCHAR(50) NOT NULL,
    Duration INT NOT NULL,
    ModifiedDate DATETIME NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT CK_Appointment_Status CHECK (Status IN ('Pending', 'Confirmed', 'Cancelled', 'Completed')),
    CONSTRAINT CK_Appointment_Duration CHECK (Duration > 0),
    CONSTRAINT FK_Appointment_User FOREIGN KEY (CreatedBy) REFERENCES dbo.Users(Id) ON DELETE NO ACTION,
    CONSTRAINT FK_Appointment_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE NO ACTION,
    CONSTRAINT FK_Appointment_Patient FOREIGN KEY (PatientId) REFERENCES dbo.Patient(Id) ON DELETE NO ACTION
);
GO

-- INSERT SAMPLE DATA

-- Users
INSERT INTO dbo.Users (Id, Username, PasswordHash, Role) VALUES
(1, 'admin', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', 'Administrator'),
(2, 'dr_who', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', 'Doctor'),
(3, 'dr_smith', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', 'Doctor'),
(4, 'dr_jones', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', 'Doctor'),
(5, 'receptionist1', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', 'Receptionist'),
(6, 'receptionist2', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', 'Receptionist');
GO

-- Doctors
INSERT INTO dbo.Doctor (Id, UserId, FirstName, LastName, Specialization, Availability) VALUES
(2, 2, 'John', 'Who', 'General Practice', 'Monday-Friday 9AM-5PM'),
(3, 3, 'Sarah', 'Smith', 'Cardiology', 'Monday-Thursday 8AM-4PM'),
(4, 4, 'Michael', 'Jones', 'Pediatrics', 'Tuesday-Saturday 10AM-6PM');
GO

-- Patients (using Quebec Health Card format: 4 letters + 8 digits + space + 2 digits)
INSERT INTO dbo.Patient (Id, FirstName, LastName, DateOfBirth, MedicalNumber, PhoneNumber, Email) VALUES
(1,'Emma','Wilson','1985-03-15','WILE85031500 01','555-0101','emma.wilson@email.com'),
(2,'James','Brown','1990-07-22','BROJ90072200 02','555-0102','james.brown@email.com'),
(3,'Olivia','Davis','1978-11-30','DAVO78113000 03','555-0103','olivia.davis@email.com'),
(4,'William','Miller','2015-05-10','MILW15051000 04','555-0104','parent.miller@email.com'),
(5,'Sophia','Garcia','1995-09-18','GARS95091800 05','555-0105','sophia.garcia@email.com');
GO

-- Schedules
INSERT INTO dbo.Schedule (Id, DoctorId, Schedule, EffectiveDate) VALUES
(1, 2, 'Mon: 9AM-5PM, Tue: 9AM-5PM, Wed: 9AM-5PM, Thu: 9AM-5PM, Fri: 9AM-5PM', '2025-01-01'),
(2, 3, 'Mon: 8AM-4PM, Tue: 8AM-4PM, Wed: 8AM-4PM, Thu: 8AM-4PM', '2025-01-01'),
(3, 4, 'Tue: 10AM-6PM, Wed: 10AM-6PM, Thu: 10AM-6PM, Fri: 10AM-6PM, Sat: 10AM-6PM', '2025-01-01');
GO

-- Appointments
INSERT INTO dbo.Appointment (Id, PatientId, DoctorId, CreatedBy, Description, AppointmentDate, Status, Duration, ModifiedDate) VALUES
(1,1,2,5,'Annual checkup','2025-11-25 10:00:00','Confirmed',30,GETDATE()),
(2,2,3,5,'Heart consultation','2025-11-26 14:00:00','Confirmed',45,GETDATE()),
(3,3,2,6,'Follow-up visit','2025-11-22 11:00:00','Completed',20,GETDATE()),
(4,4,4,5,'Child vaccination','2025-11-27 15:00:00','Pending',30,GETDATE()),
(5,5,3,6,'Cardiac screening','2025-11-23 09:00:00','Cancelled',60,GETDATE()),
(6,1,3,5,'Blood pressure check','2025-12-01 10:30:00','Confirmed',30,GETDATE());
GO

-- VIEW 1: Doctor's Current Schedule (standard view - EF will recognize DoctorId as key)
CREATE VIEW dbo.vw_DoctorCurrentSchedule
AS
SELECT 
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    d.Specialization,
    s.Schedule AS CurrentSchedule,
    s.EffectiveDate,
    d.Availability,
    s.Id AS ScheduleId
FROM 
    dbo.Doctor d
    INNER JOIN dbo.Schedule s ON d.Id = s.DoctorId
WHERE 
    s.EffectiveDate = (
        SELECT MAX(s2.EffectiveDate) 
        FROM dbo.Schedule s2
        WHERE s2.DoctorId = d.Id
    );
GO

-- VIEW 2: Upcoming Appointments Summary (standard view - EF will recognize AppointmentId as key)
CREATE VIEW dbo.vw_UpcomingAppointments
AS
SELECT 
    a.Id AS AppointmentId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.PhoneNumber,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    d.Specialization,
    a.AppointmentDate,
    a.Duration,
    a.Description,
    a.Status,
    a.PatientId,
    a.DoctorId
FROM 
    dbo.Appointment a
    INNER JOIN dbo.Patient p ON a.PatientId = p.Id
    INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
WHERE 
    a.AppointmentDate >= CAST(GETDATE() AS DATE)
    AND a.Status IN ('Pending', 'Confirmed');
GO

-- VIEW 3: Patient Medical Records Summary (standard view - EF will recognize PatientId as key)
CREATE VIEW dbo.vw_PatientRecordsSummary
AS
SELECT 
    p.Id AS PatientId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.MedicalNumber,
    p.DateOfBirth,
    DATEDIFF(YEAR, p.DateOfBirth, GETDATE()) - 
        CASE 
            WHEN MONTH(p.DateOfBirth) > MONTH(GETDATE()) 
                OR (MONTH(p.DateOfBirth) = MONTH(GETDATE()) AND DAY(p.DateOfBirth) > DAY(GETDATE()))
            THEN 1 
            ELSE 0 
        END AS Age,
    p.PhoneNumber,
    p.Email,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE PatientId = p.Id) AS TotalAppointments,
    (SELECT MAX(AppointmentDate) FROM dbo.Appointment WHERE PatientId = p.Id) AS LastAppointmentDate
FROM 
    dbo.Patient p;
GO

-- VIEW 4: Doctor Workload Statistics (standard view - EF will recognize DoctorId as key)
CREATE VIEW dbo.vw_DoctorWorkloadStats
AS
SELECT 
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    d.Specialization,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id AND Status = 'Pending') AS PendingAppointments,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id AND Status = 'Confirmed') AS ConfirmedAppointments,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id AND Status = 'Completed') AS CompletedAppointments,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE DoctorId = d.Id AND Status = 'Cancelled') AS CancelledAppointments,
    (SELECT ISNULL(SUM(Duration), 0) FROM dbo.Appointment WHERE DoctorId = d.Id AND Status IN ('Pending', 'Confirmed')) AS TotalScheduledMinutes
FROM 
    dbo.Doctor d;
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
        ORDER BY DoctorName;
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
        WHERE DoctorId = @DoctorId;
    END
END
GO

-- PROCEDURE 2: Book New Appointment
CREATE PROCEDURE dbo.sp_BookAppointment
    @PatientId INT,
    @DoctorId INT,
    @CreatedBy INT,
    @Description VARCHAR(500),
    @AppointmentDate DATETIME,
    @Duration INT = 30
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @NewId INT;
    DECLARE @Status VARCHAR(50) = 'Pending';
    
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
    
    IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Id = @CreatedBy)
    BEGIN
        RAISERROR('User not found', 16, 1);
        RETURN;
    END
    
    IF @AppointmentDate < GETDATE()
    BEGIN
        RAISERROR('Appointment date cannot be in the past', 16, 1);
        RETURN;
    END
    
    IF @Duration <= 0
    BEGIN
        RAISERROR('Duration must be greater than 0', 16, 1);
        RETURN;
    END
    
    -- Check for overlapping appointments
    IF EXISTS (
        SELECT 1 
        FROM dbo.Appointment 
        WHERE DoctorId = @DoctorId 
            AND Status IN ('Pending', 'Confirmed')
            AND (
                (@AppointmentDate >= AppointmentDate AND @AppointmentDate < DATEADD(MINUTE, Duration, AppointmentDate))
                OR
                (DATEADD(MINUTE, @Duration, @AppointmentDate) > AppointmentDate AND @AppointmentDate < AppointmentDate)
            )
    )
    BEGIN
        RAISERROR('This time slot conflicts with an existing appointment', 16, 1);
        RETURN;
    END
    
    -- Get next available ID
    SELECT @NewId = ISNULL(MAX(Id), 0) + 1 FROM dbo.Appointment;
    
    -- Insert new appointment
    INSERT INTO dbo.Appointment 
        (Id, PatientId, DoctorId, CreatedBy, Description, 
         AppointmentDate, Status, Duration, ModifiedDate)
    VALUES 
        (@NewId, @PatientId, @DoctorId, @CreatedBy, @Description, 
         @AppointmentDate, @Status, @Duration, GETDATE());
    
    -- Return the new appointment details
    SELECT 
        a.Id AS AppointmentId,
        p.FirstName + ' ' + p.LastName AS PatientName,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        a.AppointmentDate,
        a.Duration,
        a.Status,
        a.Description
    FROM 
        dbo.Appointment a
        INNER JOIN dbo.Patient p ON a.PatientId = p.Id
        INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
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
    
    -- Check if appointment is scheduled
    IF NOT EXISTS (SELECT 1 FROM dbo.Appointment 
                   WHERE Id = @AppointmentId AND Status IN ('Pending', 'Confirmed'))
    BEGIN
        RAISERROR('Only pending or confirmed appointments can be cancelled', 16, 1);
        RETURN;
    END
    
    -- Update status to Cancelled
    UPDATE dbo.Appointment
    SET Status = 'Cancelled',
        ModifiedDate = GETDATE()
    WHERE Id = @AppointmentId;
    
    -- Return confirmation with appointment details
    SELECT 
        a.Id AS AppointmentId,
        p.FirstName + ' ' + p.LastName AS PatientName,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        a.AppointmentDate,
        'Appointment cancelled successfully' AS Message
    FROM 
        dbo.Appointment a
        INNER JOIN dbo.Patient p ON a.PatientId = p.Id
        INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
    WHERE 
        a.Id = @AppointmentId;
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
    
    -- Return doctor info and booked appointments for the day
    SELECT 
        d.Id AS DoctorId,
        d.FirstName + ' ' + d.LastName AS DoctorName,
        d.Specialization,
        s.Schedule AS DoctorSchedule,
        @Date AS RequestedDate,
        a.AppointmentDate AS BookedSlotStart,
        DATEADD(MINUTE, a.Duration, a.AppointmentDate) AS BookedSlotEnd,
        a.Duration AS SlotDuration
    FROM 
        dbo.Doctor d
        LEFT JOIN dbo.Schedule s ON d.Id = s.DoctorId
            AND s.EffectiveDate = (
                SELECT MAX(s2.EffectiveDate) 
                FROM dbo.Schedule s2
                WHERE s2.DoctorId = d.Id
            )
        LEFT JOIN dbo.Appointment a ON d.Id = a.DoctorId 
            AND CAST(a.AppointmentDate AS DATE) = @Date
            AND a.Status IN ('Pending', 'Confirmed')
    WHERE 
        d.Id = @DoctorId
    ORDER BY 
        a.AppointmentDate;
END
GO