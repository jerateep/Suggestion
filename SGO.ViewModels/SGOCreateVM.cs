using SGO.Models.MySQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGO.ViewModels
{
    public class SGOCreateVM : SGO_HEAD
    {
        public string Status_name { get; set; }
        public List<SGO_Department> department { get; set;}
        public List<SGO_Type> SGOType { get; set; }
        public List<SGO_TEAM> Team { get; set; }
        public List<SGO_Approver> Approver { get; set; }
        public List<SGO_SHIFT> SHIFT { get; set; }
        public List<SGO_Status> StatusAppMng { get; set; }
        public List<SGO_Files> LsFils { get; set; }
        public List<FSTableVM> TopicFs { get; set; }
        public List<FSTableVM> TopicNFs { get; set; }
        public List<SGO_Score> score { get; set; }
    }
}
