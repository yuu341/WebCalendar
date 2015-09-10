using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebCalendar.Models.CodeFastEntities;

namespace WebCalendar.Models
{
    public class WorkingShareContext : DbContext
    {
        public DbSet<TaskBase> DateItems { get; set; }
    }
}