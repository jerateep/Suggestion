using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_Type
    {
        [Key]
        public int SGOType_ID { get; set; }
        public string SGOType_name { get; set; }
        public string SGOType_desc { get; set; }
        public string Cod_group { get; set; }
        public string SGOType_Status { get; set; }
    }
}
