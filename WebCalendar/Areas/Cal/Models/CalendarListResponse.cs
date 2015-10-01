using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCalendar.Areas.Cal.Models;

namespace MvcAngular.Web.Models
{
    public class CalendarListResponse
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public int Records { get; set; }
        public List<CalendarBase> Rows { get; set; }
    }
}