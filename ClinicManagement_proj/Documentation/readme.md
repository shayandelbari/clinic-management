# Clinic Management Application

> **EF Database First | WinForms | 3-Tier Architecture**

---

## Table of Contents

1. [Introduction](#1-introduction)
2. [Project Architecture](#2-project-architecture-3-tier)
3. [SQL Database Script](#3-sql-database-script)
4. [Step-by-Step Build Guide](#4-step-by-step-guide-building-the-project)
5. [Features Implemented](#5-features-implemented)
6. [Conclusion](#6-conclusion)

---

## 1. Introduction

This project is a **Clinic Management Application** built using:

| Technology | Description |
|------------|-------------|
| **UI Framework** | Windows Forms (.NET Framework) |
| **Language** | C# |
| **ORM** | Entity Framework 6 (Database First) |
| **Database** | Microsoft SQL Server 2022/2019 |
| **Architecture** | 3-Tier (UI -> BLL -> DAL) |
| **Data Transfer** | DTO (Data Transfer Objects) |

### Application Manages

- **Users** (with roles: Administrator, Doctor, Receptionist)
- **Patients**
- **Doctors**
- **Specialties**
- **Doctor Schedules**
- **Appointments**
- **Time Slots**
- **Audit_Appointment** (audit table)

### CRUD Operations

| Operation | Description |
|-----------|-------------|
| **Add** | Create new records |
| **Update** | Modify existing records |
| **Delete** | Remove records |
| **Search** | `GetEntity()` function |
| **Display** | `GetEntities()` function |

---

## 2. Project Architecture (3-Tier)

```
Solution
│
├── UI
│   ├── Login.cs
│   ├── AdminDashboard.cs
│   ├── DoctorDashboard.cs
│   ├── ReceptionistDashboard.cs
│   ├── Controllers/
│   │   ├── PatientRegistrationController.cs
│   │   ├── SchedulingController.cs
│   │   ├── ApptMgmtController.cs
│   │   ├── DoctorManagementController.cs
│   │   ├── UserManagementController.cs
│   │   ├── ReportsController.cs
│   │   └── NotificationController.cs
│   ├── Utils/
│   │   ├── NavigationManager.cs
│   │   └── ImageHelper.cs
│   └── Program.cs
│
├── BLL
│   ├── DTO/
│   │   ├── UserDTO.cs
│   │   ├── RoleDTO.cs
│   │   ├── PatientDTO.cs
│   │   ├── DoctorDTO.cs
│   │   ├── SpecialtyDTO.cs
│   │   ├── DoctorScheduleDTO.cs
│   │   ├── TimeSlotDTO.cs
│   │   ├── AppointmentDTO.cs
│   │   ├── AuditAppointmentDTO.cs
│   │   └── DaysOfWeekEnum.cs
│   ├── Services/
│   │   ├── UserService.cs
│   │   ├── PatientService.cs
│   │   ├── DoctorService.cs
│   │   ├── AppointmentService.cs
│   │   ├── DoctorScheduleService.cs
│   │   ├── NotificationService.cs
│   │   └── ViewsService.cs
│   ├── Utils/
│   │   └── Notification.cs
│   └── ClinicManagementApp.cs
│
└── DAL
    ├── HealthCareClinicModel.edmx
    ├── HealthCareClinicModel.Context.cs
    ├── HealthCareClinicModel.Designer.cs
    ├── ClinicDbContext.cs
    ├── User.cs
    ├── Role.cs
    ├── UserRole.cs (junction)
    ├── Patient.cs
    ├── Specialty.cs
    ├── Doctor.cs
    ├── DoctorSpecialty.cs (junction)
    ├── DoctorSchedule.cs
    ├── TimeSlot.cs
    ├── Appointment.cs
    ├── Audit_Appointment.cs
    ├── vw_DoctorTodaySchedule.cs
    ├── vw_PatientClinicalSummary.cs
    ├── vw_UpcomingAppointments.cs
    ├── vw_PatientRecordsSummary.cs
    └── sp_GetAvailableSlots_Result.cs
```
---

## 3. SQL Database Script

### 3.1 Database Setup

```sql
-- Close all connections and drop database if exists
USE master;
GO

IF DB_ID('HealthCareClinicDB_T2') IS NOT NULL
    DROP DATABASE HealthCareClinicDB_T2;
GO

CREATE DATABASE HealthCareClinicDB_T2;
GO

USE HealthCareClinicDB_T2;
GO
```

### 3.2 Drop Existing Objects

```sql
-- DROP STORED PROCEDURES
IF OBJECT_ID('dbo.sp_GetAvailableSlots', 'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetAvailableSlots;
GO

-- DROP VIEWS
IF OBJECT_ID('dbo.vw_PatientRecordsSummary', 'V') IS NOT NULL
    DROP VIEW dbo.vw_PatientRecordsSummary;
GO

IF OBJECT_ID('dbo.vw_UpcomingAppointments', 'V') IS NOT NULL
    DROP VIEW dbo.vw_UpcomingAppointments;
GO

IF OBJECT_ID('dbo.vw_DoctorTodaySchedule', 'V') IS NOT NULL
 DROP VIEW dbo.vw_DoctorTodaySchedule;
GO

IF OBJECT_ID('dbo.vw_PatientClinicalSummary', 'V') IS NOT NULL
 DROP VIEW dbo.vw_PatientClinicalSummary;
GO

IF OBJECT_ID('dbo.Audit_Appointment', 'U') IS NOT NULL
 DROP TABLE dbo.Audit_Appointment;
GO

-- DROP TABLES (correct FK order: children -> parents)
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
```

### 3.3 Create Tables

#### Users Table

```sql
CREATE TABLE dbo.Users (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Username VARCHAR(32) NOT NULL UNIQUE,
    PasswordHash VARCHAR(256) NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO
```

#### Roles Table

```sql
CREATE TABLE dbo.Roles (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    RoleName VARCHAR(64) NOT NULL UNIQUE,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO
```

#### UserRoles Table (Junction)

```sql
CREATE TABLE dbo.UserRoles (
    UserId INT NOT NULL,
    RoleId INT NOT NULL,
    CONSTRAINT PK_UserRoles PRIMARY KEY (UserId, RoleId),
    CONSTRAINT FK_UserRoles_Users FOREIGN KEY (UserId) REFERENCES dbo.Users(Id) ON DELETE CASCADE,
    CONSTRAINT FK_UserRoles_Roles FOREIGN KEY (RoleId) REFERENCES dbo.Roles(Id) ON DELETE CASCADE
);
GO
```

#### Patient Table

```sql
CREATE TABLE dbo.Patient(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FirstName VARCHAR(64) NOT NULL,
    LastName VARCHAR(64) NOT NULL,
    InsuranceNumber VARCHAR(24) NOT NULL UNIQUE,
    DateOfBirth DATETIME2(7) NOT NULL,
    PhoneNumber VARCHAR(20) NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT CK_Patient_InsuranceNumber CHECK (
        -- Quebec Health Card: 4 letters + 8 digits + 2 digits
        (InsuranceNumber LIKE '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9] [0-9][0-9]'
        OR
        InsuranceNumber LIKE '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
        OR
        -- Canadian Health Card (generic): 10 digits
        InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
        OR
  -- Ontario Health Card: 10 digits + 2 letters
     (InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[A-Z][A-Z]'
        OR
        InsuranceNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z]')
    )
);
GO
```

#### Specialties Table

```sql
CREATE TABLE dbo.Specialties (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name VARCHAR(64) NOT NULL UNIQUE
);
GO
```

#### Doctor Table

```sql
CREATE TABLE dbo.Doctor(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
 FirstName VARCHAR(64) NOT NULL,
    LastName VARCHAR(64) NOT NULL,
    LicenseNumber VARCHAR(24) NOT NULL UNIQUE,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO
```

#### DoctorSpecialties Table (Junction)

```sql
CREATE TABLE dbo.DoctorSpecialties (
    DoctorId INT NOT NULL,
    SpecialtyId INT NOT NULL,
    CONSTRAINT PK_DoctorSpecialties PRIMARY KEY (DoctorId, SpecialtyId),
    CONSTRAINT FK_DoctorSpecialties_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE CASCADE,
    CONSTRAINT FK_DoctorSpecialties_Specialties FOREIGN KEY (SpecialtyId) REFERENCES dbo.Specialties(Id) ON DELETE CASCADE
);
GO
```

#### DoctorSchedule Table

```sql
CREATE TABLE dbo.DoctorSchedule(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    DoctorId INT NOT NULL,
    DayOfWeek VARCHAR(10) NOT NULL CHECK (DayOfWeek IN ('SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATURDAY')),
    WorkStartTime TIME NOT NULL,
    WorkEndTime TIME NOT NULL,
    CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_DoctorSchedule_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE CASCADE
);
GO
```

#### TimeSlots Table

```sql
CREATE TABLE dbo.TimeSlots(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    HourOfDay INT NOT NULL,
    MinuteOfHour INT NOT NULL,
    CONSTRAINT UQ_TimeSlots_Time UNIQUE (HourOfDay, MinuteOfHour),
    CONSTRAINT CK_TimeSlots_Hour CHECK (HourOfDay >= 0 AND HourOfDay <= 23),
    CONSTRAINT CK_TimeSlots_Minute CHECK (MinuteOfHour >= 0 AND MinuteOfHour <= 59)
);
GO
```

#### Appointment Table

```sql
CREATE TABLE dbo.Appointment(
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Date DATE NOT NULL,
Notes VARCHAR(512) NULL,
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    TimeSlotId INT NOT NULL,
    Status VARCHAR(20) NOT NULL DEFAULT('PENDING') CHECK (Status IN ('PENDING', 'CONFIRMED', 'COMPLETED', 'CANCELLED')),
CreatedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    ModifiedAt DATETIME2(7) NOT NULL DEFAULT(GETDATE()),
    CONSTRAINT FK_Appointment_Doctor FOREIGN KEY (DoctorId) REFERENCES dbo.Doctor(Id) ON DELETE NO ACTION,
    CONSTRAINT FK_Appointment_Patient FOREIGN KEY (PatientId) REFERENCES dbo.Patient(Id) ON DELETE NO ACTION,
    CONSTRAINT FK_Appointment_TimeSlot FOREIGN KEY (TimeSlotId) REFERENCES dbo.TimeSlots(Id) ON DELETE NO ACTION,
    CONSTRAINT UQ_Appointment_DateTime UNIQUE (DoctorId, Date, TimeSlotId)
);
GO
```

#### Audit_Appointment Table

```sql
CREATE TABLE dbo.Audit_Appointment (
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    AppointmentId INT NOT NULL,
    PatientName VARCHAR(255) NOT NULL,
    DoctorName VARCHAR(255) NOT NULL,
    NewStatus VARCHAR(20) NOT NULL,
    AuditDate DATETIME2(7) NOT NULL DEFAULT(GETDATE())
);
GO
```

### 3.4 Create Trigger

```sql
CREATE TRIGGER trg_AuditAppointmentStatus
ON dbo.Appointment
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Audit_Appointment (AppointmentId, PatientName, DoctorName, NewStatus)
    SELECT 
i.Id,
   p.FirstName + ' ' + p.LastName AS PatientName,
   d.FirstName + ' ' + d.LastName AS DoctorName,
        i.Status
    FROM inserted i
    INNER JOIN deleted d_old ON i.Id = d_old.Id
    INNER JOIN dbo.Patient p ON i.PatientId = p.Id
    INNER JOIN dbo.Doctor d ON i.DoctorId = d.Id
    WHERE i.Status IN ('CONFIRMED', 'CANCELLED')
      AND i.Status <> d_old.Status;
END;
GO
```

### 3.5 Insert Sample Data

<details>
<summary>Click to expand sample data insertion script</summary>

```sql
-- INSERT SAMPLE DATA

DECLARE @RoleId1 INT, @RoleId2 INT, @RoleId3 INT;
INSERT INTO dbo.Roles (RoleName, CreatedAt, ModifiedAt) VALUES ('Administrator', GETDATE(), GETDATE());
SET @RoleId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Roles (RoleName, CreatedAt, ModifiedAt) VALUES ('Doctor', GETDATE(), GETDATE());
SET @RoleId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Roles (RoleName, CreatedAt, ModifiedAt) VALUES ('Receptionist', GETDATE(), GETDATE());
SET @RoleId3 = SCOPE_IDENTITY();

DECLARE @UserId1 INT, @UserId2 INT, @UserId3 INT, @UserId4 INT, @UserId5 INT, @UserId6 INT;
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('admin', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('dr_who', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('dr_smith', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId3 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('dr_jones', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId4 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('receptionist1', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId5 = SCOPE_IDENTITY();
INSERT INTO dbo.Users (Username, PasswordHash, CreatedAt, ModifiedAt) VALUES ('receptionist2', 'dHsKcdUmGyLbbM2LlD8u5L7RmODA7o4S9Aab9y4tcTCj21Ut', GETDATE(), GETDATE());
SET @UserId6 = SCOPE_IDENTITY();

INSERT INTO dbo.UserRoles (UserId, RoleId) VALUES
(@UserId1, @RoleId1), -- admin -> Administrator
(@UserId2, @RoleId2), -- dr_who -> Doctor
(@UserId3, @RoleId2), -- dr_smith -> Doctor
(@UserId4, @RoleId2), -- dr_jones -> Doctor
(@UserId5, @RoleId3), -- receptionist1 -> Receptionist
(@UserId6, @RoleId3); -- receptionist2 -> Receptionist

DECLARE @SpecialtyId1 INT, @SpecialtyId2 INT, @SpecialtyId3 INT;
INSERT INTO dbo.Specialties (Name) VALUES ('General Practice');
SET @SpecialtyId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Specialties (Name) VALUES ('Cardiology');
SET @SpecialtyId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Specialties (Name) VALUES ('Pediatrics');
SET @SpecialtyId3 = SCOPE_IDENTITY();

DECLARE @DoctorId1 INT, @DoctorId2 INT, @DoctorId3 INT;
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('John', 'Who', 'LIC001234', GETDATE(), GETDATE());
SET @DoctorId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('Sarah', 'Smith', 'LIC002345', GETDATE(), GETDATE());
SET @DoctorId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('Michael', 'Jones', 'LIC003456', GETDATE(), GETDATE());
SET @DoctorId3 = SCOPE_IDENTITY();

INSERT INTO dbo.DoctorSpecialties (DoctorId, SpecialtyId) VALUES
(@DoctorId1, @SpecialtyId1), -- Dr. Who -> General Practice
(@DoctorId2, @SpecialtyId2), -- Dr. Smith -> Cardiology
(@DoctorId3, @SpecialtyId3); -- Dr. Jones -> Pediatrics

DECLARE @PatientId1 INT, @PatientId2 INT, @PatientId3 INT, @PatientId4 INT, @PatientId5 INT;
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Emma','Wilson','1985-03-15','WILE85031500 01','555-0101',GETDATE(),GETDATE());
SET @PatientId1 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('James','Brown','1990-07-22','BROJ90072200 02','555-0102',GETDATE(),GETDATE());
SET @PatientId2 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Olivia','Davis','1978-11-30','DAVO78113000 03','555-0103',GETDATE(),GETDATE());
SET @PatientId3 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('William','Miller','2015-05-10','MILW15051000 04','555-0104',GETDATE(),GETDATE());
SET @PatientId4 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Sophia','Garcia','1995-09-18','GARS95091800 05','555-0105',GETDATE(),GETDATE());
SET @PatientId5 = SCOPE_IDENTITY();

INSERT INTO dbo.DoctorSchedule (DoctorId, DayOfWeek, WorkStartTime, WorkEndTime, CreatedAt, ModifiedAt) VALUES
-- Dr. Who (Monday-Friday 9AM-5PM)
(@DoctorId1, 'MONDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId1, 'TUESDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId1, 'WEDNESDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId1, 'THURSDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId1, 'FRIDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
-- Dr. Smith (Monday-Thursday 8AM-4PM)
(@DoctorId2, 'MONDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId2, 'TUESDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId2, 'WEDNESDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId2, 'THURSDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
-- Dr. Jones (Tuesday-Saturday 10AM-6PM)
(@DoctorId3, 'TUESDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId3, 'WEDNESDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId3, 'THURSDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId3, 'FRIDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId3, 'SATURDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE());

DECLARE @hour INT = 8;
DECLARE @minute INT = 0;

WHILE @hour < 18
BEGIN
    INSERT INTO dbo.TimeSlots (HourOfDay, MinuteOfHour) VALUES (@hour, @minute);
    SET @minute = @minute + 30;
    IF @minute >= 60
    BEGIN
        SET @minute = 0;
        SET @hour = @hour + 1;
    END
END

INSERT INTO dbo.Appointment (PatientId, DoctorId, TimeSlotId, Date, Notes, Status, CreatedAt, ModifiedAt) VALUES
(@PatientId1, @DoctorId1, 5, '2025-11-25', 'Annual checkup', 'COMPLETED', GETDATE(), GETDATE()),
(@PatientId2, @DoctorId2, 13, '2025-11-26', 'Heart consultation', 'COMPLETED', GETDATE(), GETDATE()),
(@PatientId3, @DoctorId1, 7, '2025-11-22', 'Follow-up visit', 'COMPLETED', GETDATE(), GETDATE()),
(@PatientId4, @DoctorId3, 15, '2025-11-27', 'Child vaccination', 'CANCELLED', GETDATE(), GETDATE()),
(@PatientId5, @DoctorId2, 3, '2025-11-23', 'Cardiac screening', 'CANCELLED', GETDATE(), GETDATE()),
(@PatientId1, @DoctorId2, 6, '2025-12-01', 'Blood pressure check', 'PENDING', GETDATE(), GETDATE());

-- Add more specialties
INSERT INTO dbo.Specialties (Name) VALUES ('Dermatology');
INSERT INTO dbo.Specialties (Name) VALUES ('Neurology');
INSERT INTO dbo.Specialties (Name) VALUES ('Orthopedics');

-- Add more doctors
DECLARE @DoctorId4 INT, @DoctorId5 INT, @DoctorId6 INT;
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('Alice', 'Johnson', 'LIC004567', GETDATE(), GETDATE());
SET @DoctorId4 = SCOPE_IDENTITY();
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('Robert', 'Lee', 'LIC005678', GETDATE(), GETDATE());
SET @DoctorId5 = SCOPE_IDENTITY();
INSERT INTO dbo.Doctor (FirstName, LastName, LicenseNumber, CreatedAt, ModifiedAt) VALUES ('Emily', 'Clark', 'LIC006789', GETDATE(), GETDATE());
SET @DoctorId6 = SCOPE_IDENTITY();

-- Associate new doctors with specialties
INSERT INTO dbo.DoctorSpecialties (DoctorId, SpecialtyId) VALUES
(@DoctorId4, @SpecialtyId1),
(@DoctorId5, @SpecialtyId2),
(@DoctorId6, @SpecialtyId3);

-- Add more patients with valid insurance numbers (Ontario format)
DECLARE @PatientId6 INT, @PatientId7 INT, @PatientId8 INT, @PatientId9 INT, @PatientId10 INT;
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Liam', 'Taylor', '1982-01-05', '1234567890AB', '555-0106', GETDATE(), GETDATE());
SET @PatientId6 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Isabella', 'Anderson', '1992-04-12', '2345678901BC', '555-0107', GETDATE(), GETDATE());
SET @PatientId7 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Mason', 'Thomas', '1975-08-20', '3456789012CD', '555-0108', GETDATE(), GETDATE());
SET @PatientId8 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Ava', 'Jackson', '2000-12-03', '4567890123DE', '555-0109', GETDATE(), GETDATE());
SET @PatientId9 = SCOPE_IDENTITY();
INSERT INTO dbo.Patient (FirstName, LastName, DateOfBirth, InsuranceNumber, PhoneNumber, CreatedAt, ModifiedAt) VALUES ('Ethan', 'White', '1988-06-15', '5678901234EF', '555-0110', GETDATE(), GETDATE());
SET @PatientId10 = SCOPE_IDENTITY();

-- Add schedules for new doctors
INSERT INTO dbo.DoctorSchedule (DoctorId, DayOfWeek, WorkStartTime, WorkEndTime, CreatedAt, ModifiedAt) VALUES
-- Alice Johnson (Monday-Friday 9AM-5PM)
(@DoctorId4, 'MONDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId4, 'TUESDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId4, 'WEDNESDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId4, 'THURSDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
(@DoctorId4, 'FRIDAY', '09:00:00', '17:00:00', GETDATE(), GETDATE()),
-- Robert Lee (Tuesday-Friday 8AM-4PM)
(@DoctorId5, 'TUESDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId5, 'WEDNESDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId5, 'THURSDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
(@DoctorId5, 'FRIDAY', '08:00:00', '16:00:00', GETDATE(), GETDATE()),
-- Emily Clark (Monday, Wednesday, Friday 10AM-6PM)
(@DoctorId6, 'MONDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId6, 'WEDNESDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE()),
(@DoctorId6, 'FRIDAY', '10:00:00', '18:00:00', GETDATE(), GETDATE());

-- Add more appointments
INSERT INTO dbo.Appointment (PatientId, DoctorId, TimeSlotId, Date, Notes, Status, CreatedAt, ModifiedAt) VALUES
-- Past appointments
(@PatientId6, @DoctorId4, 5, '2025-11-20', 'Routine checkup', 'COMPLETED', GETDATE(), GETDATE()),
(@PatientId7, @DoctorId5, 13, '2025-11-21', 'Cardiac evaluation', 'COMPLETED', GETDATE(), GETDATE()),
(@PatientId8, @DoctorId6, 7, '2025-11-19', 'Pediatric consultation', 'COMPLETED', GETDATE(), GETDATE()),
(@PatientId9, @DoctorId4, 15, '2025-11-18', 'Skin check', 'CANCELLED', GETDATE(), GETDATE()),
(@PatientId10, @DoctorId5, 3, '2025-11-17', 'Follow-up', 'CANCELLED', GETDATE(), GETDATE()),
-- Future appointments
(@PatientId1, @DoctorId4, 6, '2025-12-02', 'Follow-up check', 'PENDING', GETDATE(), GETDATE()),
(@PatientId2, @DoctorId5, 14, '2025-12-03', 'Blood test review', 'CONFIRMED', GETDATE(), GETDATE()),
(@PatientId3, @DoctorId6, 8, '2025-12-04', 'Vaccination', 'PENDING', GETDATE(), GETDATE()),
(@PatientId4, @DoctorId4, 16, '2025-12-05', 'Annual physical', 'CONFIRMED', GETDATE(), GETDATE()),
(@PatientId5, @DoctorId5, 4, '2025-12-06', 'Consultation', 'PENDING', GETDATE(), GETDATE());
GO
```

</details>

### 3.6 Create Views

#### View 1: Doctor's Today Schedule

Shows all appointments for today organized by doctor.

```sql
CREATE VIEW dbo.vw_DoctorTodaySchedule
AS
SELECT 
    a.Id AS AppointmentId,
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    s.Name AS Specialization,
    p.Id AS PatientId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.PhoneNumber AS PatientPhone,
    p.DateOfBirth,
    DATEDIFF(YEAR, p.DateOfBirth, GETDATE()) - 
        CASE 
   WHEN MONTH(p.DateOfBirth) > MONTH(GETDATE()) 
       OR (MONTH(p.DateOfBirth) = MONTH(GETDATE()) AND DAY(p.DateOfBirth) > DAY(GETDATE()))
  THEN 1 
            ELSE 0 
        END AS PatientAge,
    a.Date AS AppointmentDate,
    CAST(CAST(ts.HourOfDay AS VARCHAR) + ':' + RIGHT('0' + CAST(ts.MinuteOfHour AS VARCHAR), 2) AS VARCHAR(5)) AS AppointmentTime,
    ts.HourOfDay,
    ts.MinuteOfHour,
    a.Status,
    a.Notes
FROM 
    dbo.Appointment a
    INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
    INNER JOIN dbo.Patient p ON a.PatientId = p.Id
    INNER JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
WHERE 
    a.Date = CAST(GETDATE() AS DATE)
    AND a.Status IN ('PENDING', 'CONFIRMED');
GO
```

#### View 2: Patient Clinical Summary

Comprehensive patient health overview.

```sql
CREATE VIEW dbo.vw_PatientClinicalSummary
AS
SELECT 
    p.Id AS PatientId,
    p.FirstName + ' ' + p.LastName AS PatientName,
    p.DateOfBirth,
    DATEDIFF(YEAR, p.DateOfBirth, GETDATE()) - 
      CASE 
     WHEN MONTH(p.DateOfBirth) > MONTH(GETDATE()) 
     OR (MONTH(p.DateOfBirth) = MONTH(GETDATE()) AND DAY(p.DateOfBirth) > DAY(GETDATE()))
            THEN 1 
            ELSE 0 
        END AS Age,
    p.InsuranceNumber,
    p.PhoneNumber,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE PatientId = p.Id AND Status = 'COMPLETED') AS CompletedVisits,
    (SELECT COUNT(*) FROM dbo.Appointment WHERE PatientId = p.Id AND Status = 'CANCELLED') AS CancelledVisits,
    (SELECT MAX(Date) FROM dbo.Appointment WHERE PatientId = p.Id AND Status = 'COMPLETED') AS LastVisitDate,
    (SELECT TOP 1 d.FirstName + ' ' + d.LastName 
        FROM dbo.Appointment a
        INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
        WHERE a.PatientId = p.Id AND a.Status = 'COMPLETED'
        ORDER BY a.Date DESC, a.TimeSlotId DESC) AS LastSeenDoctor,
 (SELECT MIN(Date) FROM dbo.Appointment WHERE PatientId = p.Id AND Date >= CAST(GETDATE() AS DATE) AND Status IN ('PENDING', 'CONFIRMED')) AS NextAppointmentDate
FROM 
    dbo.Patient p;
GO
```

#### View 3: Upcoming Appointments (Next 7 Days)

For scheduling and planning.

```sql
CREATE VIEW dbo.vw_UpcomingAppointments
AS
SELECT 
    a.Id AS AppointmentId,
    d.Id AS DoctorId,
    d.FirstName + ' ' + d.LastName AS DoctorName,
  s.Name AS Specialization,
    p.Id AS PatientId,
p.FirstName + ' ' + p.LastName AS PatientName,
    p.PhoneNumber AS PatientPhone,
    p.DateOfBirth,
    a.Date AS AppointmentDate,
    DATENAME(WEEKDAY, a.Date) AS DayOfWeek,
    CAST(CAST(ts.HourOfDay AS VARCHAR) + ':' + RIGHT('0' + CAST(ts.MinuteOfHour AS VARCHAR), 2) AS VARCHAR(5)) AS AppointmentTime,
    ts.HourOfDay,
    ts.MinuteOfHour,
    a.Status,
  a.Notes,
    CASE 
        WHEN a.Date = CAST(GETDATE() AS DATE) THEN 'Today'
        WHEN a.Date = CAST(DATEADD(DAY, 1, GETDATE()) AS DATE) THEN 'Tomorrow'
        ELSE CAST(DATEDIFF(DAY, GETDATE(), a.Date) AS VARCHAR(10)) + ' days'
    END AS DaysUntil
FROM 
    dbo.Appointment a
    INNER JOIN dbo.Doctor d ON a.DoctorId = d.Id
    INNER JOIN dbo.Patient p ON a.PatientId = p.Id
    INNER JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
WHERE 
    a.Date >= CAST(GETDATE() AS DATE)
    AND a.Date <= CAST(DATEADD(DAY, 7, GETDATE()) AS DATE)
    AND a.Status IN ('PENDING', 'CONFIRMED');
GO
```

#### View 4: Patient Recent Visit History

Last 5 visits with clinical notes.

```sql
CREATE VIEW dbo.vw_PatientRecordsSummary
AS
SELECT 
    ROW_NUMBER() OVER (PARTITION BY p.Id ORDER BY a.Date DESC, ts.HourOfDay DESC, ts.MinuteOfHour DESC) AS VisitNumber,
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
    a.Id AS AppointmentId,
    a.Date AS VisitDate,
    d.FirstName + ' ' + d.LastName AS DoctorName,
    s.Name AS Specialization,
    a.Status AS VisitStatus,
    a.Notes AS ClinicalNotes,
    DATEDIFF(DAY, a.Date, GETDATE()) AS DaysSinceVisit
FROM 
    dbo.Patient p
    LEFT JOIN dbo.Appointment a ON p.Id = a.PatientId
    LEFT JOIN dbo.Doctor d ON a.DoctorId = d.Id
    LEFT JOIN dbo.DoctorSpecialties ds ON d.Id = ds.DoctorId
    LEFT JOIN dbo.Specialties s ON ds.SpecialtyId = s.Id
    LEFT JOIN dbo.TimeSlots ts ON a.TimeSlotId = ts.Id
WHERE 
    a.Status IN ('COMPLETED', 'CANCELLED');
GO
```

### 3.7 Create Stored Procedure

#### Get Available Appointment Slots

```sql
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
        ts.MinuteOfHour
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
        AND a.Id IS NULL
 ORDER BY 
        ts.HourOfDay, ts.MinuteOfHour;
END
GO
```

---

## 4. Step-by-Step Guide: Building the Project

### Step 1: Create the SQL Database

> Run the script above in **SQL Server Management Studio**.

### Step 2: Create the Windows Forms Project

```
File -> New -> Project -> Windows Forms App (.NET Framework)
```

### Step 3: Create the Folder Structure

```
DAL/
BLL/
   DTO/
   SERVICES/
UI/
   Controllers/
   Utils/
```

### Step 4: Add Entity Framework DB-First

Inside the **DAL** folder:

1. **Right-click** ? Add ? New Item
2. Select **"ADO.NET Entity Data Model"**
3. Choose **"EF Designer from database"**
4. Connect to `HealthCareClinicDB_T2`
5. Select the following tables and views:

| Tables | Views |
|--------|-------|
| Users | vw_DoctorTodaySchedule |
| Roles | vw_PatientClinicalSummary |
| UserRoles | vw_UpcomingAppointments |
| Patient | vw_PatientRecordsSummary |
| Specialties | |
| Doctor | |
| DoctorSpecialties | |
| DoctorSchedule | |
| TimeSlots | |
| Appointment | |
| Audit_Appointment | |

**EF automatically generates:**
- * Entity classes
- * DbContext
- * Mappings

### Step 5: Create DTO Classes

> Separate lightweight classes used by the UI.

### Step 6: Create Service Classes in BLL

Each entity gets its own Service class implementing:

| Operation | Method |
|-----------|--------|
| Add | `Add()` |
| Update | `Update()` |
| Delete | `Delete()` |
| Search | `GetEntity()` |
| GetAll | `GetEntities()` |

### Step 7: Build the Windows Forms UI

**Create:**

| Component | Description |
|-----------|-------------|
| **Login Form** | Authentication |
| **Admin Dashboard** | User and doctor management |
| **Doctor Dashboard** | View schedule, manage appointments |
| **Receptionist Dashboard** | Patient registration, appointment booking |
| **Controllers** | Panel management |
| **Utils** | Navigation and image handling |

> Warning: The Appointment management includes special logic for scheduling and status updates.

---

## 5. Features Implemented

### Core Features

| Feature | Description |
|---------|-------------|
| * Entity Framework 6 | Database First approach |
| * 3-Tier Architecture | UI -> BLL -> DAL |
| * DTO Classes | Layer communication |
| * CRUD Operations | Users, Patients, Doctors, Appointments, etc. |
| * Many-to-Many | Junction tables (UserRoles, DoctorSpecialties) |
| * Appointment Scheduling | Time slots and doctor availability |
| * Audit Trail | Appointment status changes |
| * Role-Based Access | Administrator, Doctor, Receptionist |
| * Views | Reporting and summaries |
| * Stored Procedures | Complex queries |
| * Update Logic | Related entities |
| * Clean Architecture | Maintainable service-layer logic |
| * WinForms UI | Dashboards |

---

## 6. Conclusion

### This Project Demonstrates:

- * Proper use of **Entity Framework Database First**
- * Strong understanding of **SQL database modeling** with constraints and triggers
- * Implementation of a **clean 3-tier architecture**
- * Practical use of **DTO and Service classes**
- * Working **CRUD operations** in a desktop environment
- * Handling **many-to-many relationships** with junction tables
- * Integration of **SQL Server views and stored procedures** into EF
- * **Role-based authentication and authorization**
- * **Appointment scheduling logic** with availability checks

### Project Characteristics

> The project is **modular**, **scalable**, and follows **industry development patterns**.

### Future Enhancements

The project can be extended by adding:

| Enhancement | Description |
|-------------|-------------|
| More User Roles | Extended role hierarchy |
| Advanced Reporting | Detailed analytics and reports |
| Authentication Enhancements | Password policies, MFA |
| Pagination | Advanced filtering for large datasets |
| External Integration | Billing, EHR systems |
| Mobile App | Companion application |
| Cloud Migration | Azure SQL, etc. |

---

<div align="center">

**Built with love using .NET Framework, Entity Framework 6, and SQL Server**

</div>


