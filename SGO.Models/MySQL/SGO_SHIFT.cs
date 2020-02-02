using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_SHIFT
    {
        [Key]
        public int Shift_id { get; set; }
        public string Shift_Time { get; set; }
        public string Shift_Desc { get; set; }
        public string Ship_status { get; set; }
    }
}
