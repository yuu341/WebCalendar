using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebCalendar.Models
{
    public class WorkingShareContext : DbContext
    {
        public DbSet<DateItem> DateItems { get; set; }
    }
}