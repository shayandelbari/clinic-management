using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.BLL.Utils;
using ClinicManagement_proj.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    public class NotificationService
    {
        private readonly ClinicDbContext clinicDb;
        private static List<Notification> notifications = new List<Notification>();

        public event Action<Notification> NotificationAdded;

        public NotificationService(ClinicDbContext dbContext)
        {
            clinicDb = dbContext;
        }

        public void AddNotification(string message, NotificationType type)
        {
            var notif = new Notification(message, type);
            lock (notifications)
            {
                notifications.Add(notif);
                // Clean up old ones
                for (int i = notifications.Count - 1; i >= 0; i--)
                {
                    if (DateTime.Now.Subtract(notifications[i].Timestamp).TotalMinutes > 30)
                    {
                        notifications.RemoveAt(i);
                    }
                }
            }
            NotificationAdded?.Invoke(notif);
        }

        public List<Notification> GetActiveNotifications()
        {
            lock (notifications)
            {
                List<Notification> active = new List<Notification>();
                foreach (var n in notifications)
                {
                    if (DateTime.Now.Subtract(n.Timestamp).TotalMinutes <= 30)
                    {
                        active.Add(n);
                    }
                }
                return active;
            }
        }

        public List<AuditAppointmentDTO> GetAuditNotifications()
        {
            return clinicDb.AuditAppointments
                .OrderByDescending(a => a.AuditDate)
                .ToList();
        }
    }
}