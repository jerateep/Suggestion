using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_Status
    {
        [Key]
        public int Status_id { get; set; }
        public string Status_name { get; set; }
        public string Status_code { get; set; }
        public string Cod_group { get; set; }
        public string Status_Desc { get; set; }
        public string Active { get; set; }
    }
}
