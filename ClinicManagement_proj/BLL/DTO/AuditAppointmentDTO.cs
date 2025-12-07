using System;

namespace ClinicManagement_proj.BLL.DTO
{
    /// <summary>
    /// Represents an audit appointment data transfer object.
    /// </summary>
    public class AuditAppointmentDTO
    {
        public int AuditId { get; set; }
        public int AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string NewStatus { get; set; }
        public DateTime AuditDate { get; set; }
    }
}
