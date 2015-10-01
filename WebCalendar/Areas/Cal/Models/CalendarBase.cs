using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebCalendar.Models.CodeFastEntities.Master;

namespace WebCalendar.Areas.Cal.Models
{
    public class CalendarBase
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


        ///// <summary>
        ///// ユーザ
        ///// </summary>
        //public List<User> Users { get; set; }

        /// <summary>
        /// タイトル
        /// </summary>
        [StringLength(20)]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 作成日
        /// </summary>
        public DateTime CreateDate { get; set; }

        public CalendarBase()
        {
            CreateDate = DateTime.Now;
        }
        /// <summary>
        /// サンプルデータを作る
        /// </summary>
        /// <returns>作成後のサンプルデータ</returns>
        public static CalendarBase CreateSample(Random rand)
        {
            CalendarBase sample = new CalendarBase();

            sample.DeleteFlg = rand.Next(0, 5) == 0;
            sample.TempFlg = rand.Next(0, 4) == 0;
            sample.PublicLevel = rand.Next(0, 2);
            sample.EndFlg = rand.Next(0, 3) == 0;


            string[] s1 = new string[]{
                "今日に、",
                "明日に、",
                "来月に、",
                "再来月に、",
            };

            string[] s2 = new string[]{
                "自宅で、",
                "会社で、",
                "駅で、",
                "図書館で、",
            };

            string[] s3 = new string[]{
                "同僚と、",
                "家族と、",
                "友達と、",
                "恋人と、",
            };

            string[] s4 = new string[]{
                "会議する。",
                "テストする。",
                "走る。",
                "腹筋する。",
            };
            sample.Title =
                s1[rand.Next(0, 3)] +
                s2[rand.Next(0, 3)] +
                s3[rand.Next(0, 3)] +
                s4[rand.Next(0, 3)];

            //sample.CreateDate = DateTime.Now;

            return sample;
        }
    }
}