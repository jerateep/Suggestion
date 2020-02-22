using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_Score
    {
        [Key]
        public int score_id { get; set; }
        public string SGO_ID { get; set; }
        public int num_row { get; set; }
        public int choice_id { get; set; }
        //public int score { get; set; }
    }
}
