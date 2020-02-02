using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_TEAM
    {
        [Key]
        public int Team_id  { get; set; }
        public string SGO_ID { get; set; }
        public int Team_rownum { get; set; }
        public string pers_id { get; set; }
        public string pers_position { get; set; }
        public string txt_comment { get; set; }
        public string Team_Status { get; set; }
        public DateTime? dtm_approved { get; set; }
        public string cod_creator { get; set; }
        public string cod_update { get; set; }
        public DateTime? dtm_create { get; set; }
        public DateTime? dtm_update { get; set; }
    }
}
