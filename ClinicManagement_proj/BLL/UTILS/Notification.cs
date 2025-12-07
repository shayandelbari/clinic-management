using System;

namespace ClinicManagement_proj.BLL.Utils
{
    public enum NotificationType
    {
        Info,
        Warning,
        Error
    }

    /// <summary>
    /// Represents a notification in the system.
    /// </summary>
    public class Notification
    {
        public string Message { get; set; }
        public NotificationType Type { get; set; }
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        /// <param name="message">The message of the notification.</param>
        /// <param name="type">The type of the notification.</param>
        public Notification(string message, NotificationType type)
        {
            Message = message;
            Type = type;
            Timestamp = DateTime.Now;
        }
    }
}