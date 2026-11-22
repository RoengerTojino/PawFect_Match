using System;

namespace PawFect_Match.Models
{
    public abstract class UserAccount
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; protected set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        protected UserAccount()
        {
            Username = "";
            Email = "";
            PasswordHash = "";
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
    }
}