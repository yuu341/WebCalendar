using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebCalendar.Areas.Cal.Models;
using WebCalendar.Models.CodeFastEntities;
using WebCalendar.Models.CodeFastEntities.Master;

namespace WebCalendar.Models
{
    public class SampleDataInitializer : DropCreateDatabaseAlways<WorkingShareContext>
    {
        protected override void Seed(WorkingShareContext context)
        {
            base.Seed(context);

            CreateMenus(context);

            CreateCalendarBase(context);
            
            context.SaveChanges();
        }
        private void CreateMenus(WorkingShareContext context)
        {
            var data = new List<Menu>();
            int order = 1;
            data.Add(new Menu { MenuName = "ホーム", Controller = "Home" , Order = order++ });
            data.Add(new Menu { MenuName = "カレンダー", Controller = "Calendars", Area = "Cal", Order = order++ });
            data.Add(new Menu { MenuName = "タスク", Controller = "Tasks", Area = "Cal", Order = order++ });
            data.Add(new Menu { MenuName = "ユーザ", Controller = "User", Area = "Master", Order = order++ });
            data.Add(new Menu { MenuName = "メニュー", Controller = "Menu", Area = "Master", Order = order++ });

            context.Menus.AddRange(data);
        }
        private void CreateCalendarBase(WorkingShareContext context)
        {
            var data = new List<CalendarBase>();

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 100; i++)
            {
                data.Add(CalendarBase.CreateSample(rand));
            }
            context.CalendarBases.AddRange(data);
        }
    }
}