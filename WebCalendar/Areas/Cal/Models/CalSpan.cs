using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalendar.Areas.Cal.Models
{
    public class CalSpan
    {
        public int Id { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string Summary { get; set; }
    }
}