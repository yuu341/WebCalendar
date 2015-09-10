using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalendar.Models.CodeFastEntities.Master
{
    public class UserRole
    {
        public int Id { get; set; }

        public int RoleName { get; set; }

        public bool CanUse { get; set; }
    }
}