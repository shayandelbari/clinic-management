# API Reference

Welcome to the Clinic Management Application API Reference. This section contains detailed documentation for all classes, interfaces, and methods in the application.

## Namespaces

The application is organized into the following namespaces:

### ClinicManagement_proj.UI

The presentation layer containing Windows Forms and controllers.

- **Forms**: LoginForm, AdminDashboard, DoctorDashboard, ReceptionistDashboard
- **Controllers**: ApptMgmtController, DoctorManagementController, PatientRegistrationController, SchedulingController, UserManagementController, ReportsController, NotificationsController
- **Utilities**: NavigationManager, ImageHelper
- **Interfaces**: IPanelController

### ClinicManagement_proj.BLL

The business logic layer containing services and data transfer objects.

#### Services
- [UserService](ClinicManagement_proj.BLL.Services.UserService.yml)
- [PatientService](ClinicManagement_proj.BLL.Services.PatientService.yml)
- [DoctorService](ClinicManagement_proj.BLL.Services.DoctorService.yml)
- [AppointmentService](ClinicManagement_proj.BLL.Services.AppointmentService.yml)
- [DoctorScheduleService](ClinicManagement_proj.BLL.Services.DoctorScheduleService.yml)
- [NotificationService](ClinicManagement_proj.BLL.Services.NotificationService.yml)
- [ViewsService](ClinicManagement_proj.BLL.Services.ViewsService.yml)

#### DTOs (Data Transfer Objects)
- [PatientDTO](ClinicManagement_proj.BLL.DTO.PatientDTO.yml)
- [DoctorDTO](ClinicManagement_proj.BLL.DTO.DoctorDTO.yml)
- [AppointmentDTO](ClinicManagement_proj.BLL.DTO.AppointmentDTO.yml)
- [TimeSlotDTO](ClinicManagement_proj.BLL.DTO.TimeSlotDTO.yml)
- [DoctorScheduleDTO](ClinicManagement_proj.BLL.DTO.DoctorScheduleDTO.yml)
- [UserDTO](ClinicManagement_proj.BLL.DTO.UserDTO.yml)
- [RoleDTO](ClinicManagement_proj.BLL.DTO.RoleDTO.yml)
- [SpecialtyDTO](ClinicManagement_proj.BLL.DTO.SpecialtyDTO.yml)
- [AuditAppointmentDTO](ClinicManagement_proj.BLL.DTO.AuditAppointmentDTO.yml)

#### Enums
- [DaysOfWeekEnum](ClinicManagement_proj.BLL.DTO.DaysOfWeekEnum.yml)

#### Core
- [ClinicManagementApp](ClinicManagement_proj.BLL.ClinicManagementApp.yml)

#### Utilities
- [Notification](ClinicManagement_proj.BLL.Utils.Notification.yml)
- [NotificationType](ClinicManagement_proj.BLL.Utils.NotificationType.yml)

### ClinicManagement_proj.DAL

The data access layer containing Entity Framework entities and context.

#### Context
- [ClinicDbContext](ClinicManagement_proj.DAL.ClinicDbContext.yml)

#### Entities
- [Patient](ClinicManagement_proj.DAL.Patient.yml)
- [Doctor](ClinicManagement_proj.DAL.Doctor.yml)
- [Appointment](ClinicManagement_proj.DAL.Appointment.yml)
- [TimeSlot](ClinicManagement_proj.DAL.TimeSlot.yml)
- [DoctorSchedule](ClinicManagement_proj.DAL.DoctorSchedule.yml)
- [User](ClinicManagement_proj.DAL.User.yml)
- [Role](ClinicManagement_proj.DAL.Role.yml)
- [Specialty](ClinicManagement_proj.DAL.Specialty.yml)
- [Audit_Appointment](ClinicManagement_proj.DAL.Audit_Appointment.yml)

#### Views
- [vw_UpcomingAppointments](ClinicManagement_proj.DAL.vw_UpcomingAppointments.yml)
- [vw_PatientRecordsSummary](ClinicManagement_proj.DAL.vw_PatientRecordsSummary.yml)
- [vw_PatientClinicalSummary](ClinicManagement_proj.DAL.vw_PatientClinicalSummary.yml)
- [vw_DoctorTodaySchedule](ClinicManagement_proj.DAL.vw_DoctorTodaySchedule.yml)

## Browse the API

Use the navigation on the left to browse all classes, interfaces, and enums in the application.
