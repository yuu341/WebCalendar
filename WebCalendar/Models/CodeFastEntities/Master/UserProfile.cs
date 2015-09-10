using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalendar.Models.CodeFastEntities.Master
{
    public class UserProfile
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public string EmailAddress { get; set; }

        public string Message { get; set; }

        public byte[] UserIcon { get; set; }

        public DateTime RegisterTime { get; set; }

        public User User { get; set; }

    }
}