using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Console_Appliction.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public UserProfile? UserProfile { get; set; } 
    }
}
