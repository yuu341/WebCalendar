using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebCalendar.Models.CodeFastEntities;

namespace WebCalendar.Models
{
    public class SampleDataInitializer : DropCreateDatabaseAlways<WorkingShareContext>
    {
        protected override void Seed(WorkingShareContext context)
        {
            base.Seed(context);

            var items = new List<TaskBase>()
            {
                new TaskBase(){ Date= DateTime.Parse("2015-10-12"), ItemKbn = 0 , UserId = 0, Complete = false, },
                new TaskBase(){ Date= DateTime.Parse("2015-10-13"), ItemKbn = 11 , UserId = 0, Complete = true, },
                new TaskBase(){ Date= DateTime.Parse("2015-10-14"), ItemKbn = 12 , UserId = 0, Complete = false, },
                new TaskBase(){ Date= DateTime.Parse("2015-10-15"), ItemKbn = 19 , UserId = 0, Complete = true, },
                new TaskBase(){ Date= DateTime.Parse("2015-10-16"), ItemKbn = 2 , UserId = 0, Complete = false, },
                new TaskBase(){ Date= DateTime.Parse("2015-10-17"), ItemKbn = 0 , UserId = 0, Complete = false, },
                new TaskBase(){ Date= DateTime.Parse("2015-10-18"), ItemKbn = 11 , UserId = 0, Complete = true, },
            };

            //items.ForEach(m => context.DateItems.Add(m));
            context.DateItems.AddRange(items);
            context.SaveChanges();
        }
    }
}