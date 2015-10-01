using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebCalendar.Areas.Cal.Models;
using WebCalendar.Models.CodeFastEntities;
using WebCalendar.Models.CodeFastEntities.Master;

namespace WebCalendar.Models
{
    public class WorkingShareContext : DbContext
    {
        public DbSet<CalendarBase> CalendarBases { get; set; }

        public DbSet<CalDate> CalDates { get; set; }

        public DbSet<Log> Logs { get; set; }

        public DbSet<Menu> Menus { get; set; }

        //public DbSet<User> Users { get; set; }

        //public DbSet<UserProfile> UserProfiles { get; set; }

        //public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CalendarBase>()
            //    .Property(f => f.CreateDate)
            //    .HasColumnType("datetime2")
            //    .HasPrecision(0);
            base.OnModelCreating(modelBuilder);
        }

    }
}