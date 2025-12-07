---
_layout: landing
---

# Clinic Management Application Documentation

![Clinic Management Preview](~/Static/HealthCareClinicPreview.gif)

A comprehensive multi-tier desktop application for managing clinic operations, developed using C# and .NET Framework.

## Overview

This application provides a complete solution for clinic management, including user authentication, appointment scheduling, patient records, doctor management, and reporting. It follows a layered architecture with Windows Forms UI, business logic services, and Entity Framework data access.

## Key Features

- **Role-Based Authentication**: Secure login system for doctors, receptionists, and administrators
- **Appointment Management**: Full CRUD operations for appointments with scheduling validation
- **Patient Records**: Comprehensive patient data management with clinical summaries
- **Doctor Scheduling**: Manage doctor availability, workloads, and time slots
- **Reports & Analytics**: Generate detailed reports on appointments, patients, and doctor statistics
- **Notifications**: In-app notification system for updates and alerts

## Architecture

The application is built using a multi-tier architecture:

### Presentation Layer (UI)
- Windows Forms with role-specific dashboards
- Controller pattern for panel management and navigation
- Responsive design for desktop clinic environment

### Business Logic Layer (BLL)
- Service classes for business operations
- Data transfer objects (DTOs) for data exchange
- Validation and notification utilities

### Data Access Layer (DAL)
- Entity Framework 6 with Code-First approach
- SQL Server database with stored procedures and views
- Migration support for database schema updates

## Technologies Used

- **Framework**: .NET Framework 4.8
- **Language**: C# 7.3
- **UI**: Windows Forms
- **ORM**: Entity Framework 6.5.1
- **Database**: SQL Server
- **Documentation**: DocFX

## Getting Started

### Prerequisites
- .NET Framework 4.8 or later
- SQL Server (LocalDB or full instance)

### Installation
1. Clone the repository
2. Run the database setup script (`DAL/HealthCareClinicDB_T2_Script.sql`)
3. Build the solution in Visual Studio
4. Run the application

### Usage
- Launch the app and log in with appropriate credentials
- Access role-specific dashboards
- Manage appointments, patients, and schedules
- View reports and notifications

## Contributing

This project is developed for educational purposes. For contributions or modifications, please refer to the source code and follow standard C# development practices.

## License

This project is licensed under the MIT License - see the [LICENSE](https://github.com/shayandelbari/clinic-management/blob/submission/LICENSE) file for details.

---

*Built with DocFX | .NET Framework 4.8 | C#*