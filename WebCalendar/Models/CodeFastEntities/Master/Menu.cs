using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebCalendar.Models.CodeFastEntities.Master
{
    public class Menu
    {
        public int Id { get; set; }

        public int? ParentMenuId { get; set; }

        public ICollection<Menu> Menus { get; set; }

        public string MenuName { get; set; }

        public string Area { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Option { get; set; }

        public bool Visibility { get; set; }

        public int Order { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public Menu()
        {
            Action = "Index";
            Visibility = true;
            Order = 0;
            CreateDate = DateTime.Now;
        }
    }
}