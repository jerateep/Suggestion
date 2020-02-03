using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGO.Models.MySQL
{
    public class SGO_HEAD
    {

        [Key]
        public string SGO_ID { get; set; }
        public string Fname { get; set; }
        public string LName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Dep_name { get; set; }
        public string Dep_Section { get; set; }
        public int Shift { get; set; }
        public int Dep_ID_Request { get; set; }
        public string SGOType_ID { get; set; }
        public string Subject { get; set; }
        public string Detail_Now { get; set; }
        public string Detail_Future { get; set; }
        public string Detail_Result { get; set; }
        public string Status { get; set; }
        public string cod_Requester { get; set; }
        public DateTime? dtm_Request { get; set; }
        public string cod_creator { get; set; }
        public DateTime? dtm_create { get; set; }
        public string cod_update { get; set; }
        public DateTime? dtm_update { get; set; }
    }
}
                                                                