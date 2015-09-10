using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebCalendar.Models.CodeFastEntities.Master
{
    public class User
    {
        public int Id { get; set; }

        public string PasswordHash { get; set; }

        public bool CanUse { get; set; }

        [NotMapped]
        public string Password { get; set; }

        [NotMapped]
        public string PasswordConfirm { get; set; }

        public UserProfile UserProfile { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}