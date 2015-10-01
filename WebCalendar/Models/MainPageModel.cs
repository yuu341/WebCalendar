using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCalendar.Models.CodeFastEntities.Master;

namespace WebCalendar.Models
{
    public class MainPageModel
    {
        public IEnumerable<Menu> Menus { get; set; }
    }
}