using ClinicManagement_proj.BLL.DTO;
using ClinicManagement_proj.DAL;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement_proj.BLL.Services
{
    internal class UserService
    {
        private ClinicDbContext clinicDb = new ClinicDbContext();

        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = clinicDb.Users.Select(u => new UserDTO
            {
                Id = u.Id,
                Username = u.Username,
                Role = u.Role
            }).ToList();
            return users;
        }
    }
}
