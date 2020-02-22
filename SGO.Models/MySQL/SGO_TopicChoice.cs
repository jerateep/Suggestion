using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_TopicChoice
    {
        [Key]
        public int choie_id { get; set; }
        public string choice_row { get; set; }
        public string choice_name { get; set; }
        public int topic_id { get; set; }
        public string status { get; set; }
    }
}
