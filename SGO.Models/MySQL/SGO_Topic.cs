using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_Topic
    {
        [Key]
        public int topic_id { get; set; }
        public string topic { get; set; }
        public string group { get; set; }
        public string status { get; set; }
    }
}
