using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebCalendar.Areas.Cal.Models
{
    [NotMapped]
    public class vCalendar
    {
        public int Id { get; set; }
    }
}