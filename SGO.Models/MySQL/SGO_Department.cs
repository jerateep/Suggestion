using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_Department
    {
        [Key]
        public int dep_id { get; set; }
        public string dep_name { get; set; }
        public string dep_status { get; set; }
    }
}
