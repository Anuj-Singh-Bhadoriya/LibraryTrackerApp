using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTrackerApp.Model
{
    internal class SignupModel
    {
        public string? FullName { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public int Status { get; set; }
        public string? Email { get; set; }
        public string? PasswordDate { get; set; }
        
    }
}
