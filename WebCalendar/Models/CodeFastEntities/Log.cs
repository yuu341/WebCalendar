using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebCalendar.Models.CodeFastEntities.Master;

namespace WebCalendar.Models.CodeFastEntities
{
    public class Log
    {
        [Key]
        public DateTime Date { get; set; }

        public int Type { get; set; }

        public int Message { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}