using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebCalendar.Models.CodeFastEntities.Master;

namespace WebCalendar.Areas.Cal.Models
{
    public class Cal
    {
        public int Id { get; set; }

        /// <summary>
        /// 完了
        /// </summary>
        public bool EndFlg { get; set; }

        /// <summary>
        /// 一時保存
        /// </summary>
        public bool TempFlg { get; set; }

        /// <summary>
        /// 削除
        /// </summary>
        public bool DeleteFlg { get; set; }

        /// <summary>
        /// 公開制限
        /// </summary>
        [DisplayName("制限")]
        public int PublicLevel { get; set; }

        /// <summary>
        /// ユーザ
        /// </summary>
        public ICollection<User> Users { get; set; }

        [StringLength(20)]
        public string Title { get; set; }
        /// <summary>
        /// 作成日
        /// </summary>
        public DateTime CreateDate { get; set; }


    }
}