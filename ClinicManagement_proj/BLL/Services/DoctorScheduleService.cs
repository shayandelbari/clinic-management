using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL.Services;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement_proj.BLL
{
    public class DoctorScheduleService
    {
        private readonly ClinicDbContext clinicDb;

        public DoctorScheduleService(ClinicDbContext dbContext)
        {
            clinicDb = dbContext;
        }

        public DoctorScheduleDTO CreateSchedule(DoctorScheduleDTO scheduleDto)
        {
            if (!ClinicManagementApp.CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Access denied. Administrator role required.");

            clinicDb.DoctorSchedules.Add(scheduleDto);
            clinicDb.SaveChanges();
            return scheduleDto;
        }

        public DoctorScheduleDTO UpdateSchedule(DoctorScheduleDTO scheduleDto)
        {
            if (!ClinicManagementApp.CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Access denied. Administrator role required.");

            scheduleDto.ModifiedAt = DateTime.Now;
            clinicDb.SaveChanges();
            return scheduleDto;
        }

        public void DeleteSchedule(int id)
        {
            if (!ClinicManagementApp.CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Access denied. Administrator role required.");
            var schedule = clinicDb.DoctorSchedules
                .Where(s => s.Id == id)
                .FirstOrDefault()
                ?? throw new ArgumentException("Schedule not found");

            clinicDb.DoctorSchedules.Remove(schedule);
            clinicDb.SaveChanges();
        }

        public void DeleteSchedule(DoctorScheduleDTO scheduleDto)
        {
            if (!ClinicManagementApp.CurrentUserHasRole(UserService.UserRoles.Administrator))
                throw new UnauthorizedAccessException("Access denied. Administrator role required.");

            clinicDb.DoctorSchedules.Remove(scheduleDto);
            clinicDb.SaveChanges();
        }

        public List<DoctorScheduleDTO> GetAllSchedules()
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                (
                    UserService.UserRoles.Administrator,
                    UserService.UserRoles.Doctor,
                    UserService.UserRoles.Receptionist
                )
            )
                throw new UnauthorizedAccessException("You don't have access to read all schedules");
            return clinicDb.DoctorSchedules.ToList();
        }

        public DoctorScheduleDTO Search(int id)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                (
                    UserService.UserRoles.Administrator,
                    UserService.UserRoles.Doctor,
                    UserService.UserRoles.Receptionist
                )
            )
                throw new UnauthorizedAccessException("You don't have access to search schedules");

            var schedule = clinicDb.DoctorSchedules
                .Where(s => s.Id == id)
                .FirstOrDefault()
                ?? throw new ArgumentException("Schedule not found");
            return schedule;
        }

        public DoctorScheduleDTO Search(string dayOfWeek)
        {
            if (!ClinicManagementApp.CurrentUserHasRole
                (
                    UserService.UserRoles.Administrator,
                    UserService.UserRoles.Doctor,
                    UserService.UserRoles.Receptionist
                )
            )
                throw new UnauthorizedAccessException("You don't have access to search schedules");

            var schedule = clinicDb.DoctorSchedules
                .Where(s => s.DayOfWeek == dayOfWeek)
                .FirstOrDefault()
                ?? throw new ArgumentException("Schedule not found");
            return schedule;
        }
    }
}
