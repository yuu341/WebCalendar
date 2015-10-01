using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCalendar.Areas.Cal.Models
{
    public class CalDate
    {
        public int Id { get; set; }

        /// <summary>
        /// 指定日
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// から
        /// </summary>
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// まで
        /// </summary>
        public DateTime? ToDate { get; set; }

        [StringLength(50)]
        public string Summary { get; set; }
    }
}