using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_Console_Appliction.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }    
    }
}
