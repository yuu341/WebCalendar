using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebCalendar.Models
{
    /// <summary>
    /// 日付に関するスケジュール項目
    /// </summary>
    public class DateItem
    {
        /// <summary>
        /// PK
        /// </summary>
        [DisplayName("PK")]
        public int Id { get; set; }

        /// <summary>
        /// スケジュール登録者
        /// </summary>
        [DisplayName("ユーザID")]
        public int UserId { get; set; }

        /// <summary>
        /// 日付
        /// </summary>
        [DisplayName("登録日")]
        [DisplayFormat(DataFormatString = "{0:yyyy年MM月dd日}")]
        public DateTime Date { get; set; }

        /// <summary>
        /// 完了フラグ
        /// </summary>
        [DisplayName("完了")]
        public bool Complete { get; set; }

        /// <summary>
        /// スケジュールの区分
        /// 0:一時保存
        /// 2:削除
        /// 11:登録済
        /// 12:登録済重要
        /// 19:登録済完了
        /// </summary>
        [DisplayName("区分")]
        public int ItemKbn { get; set; }

        [NotMapped]
        public string ListItemKbn
        {
            get
            {
                switch (ItemKbn)
                {
                    case 0:
                        return "一時保存";
                    case 11:
                        return "登録";
                    case 12:
                        return "重要";
                    case 19:
                        return "完了";
                    case 2:
                        return "削除";
                    default:
                        return "-";
                }
            }
        }
    }
}