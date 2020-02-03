using System;
using System.Collections.Generic;
using System.Text;
using SGO.Models.MySQL;

namespace SGO.ViewModels
{
    public class DummyData
    {
        public List<SGO_Approver> GetManagerApprover()
        {
            List<SGO_Approver> lsData = new List<SGO_Approver>
            {
                new SGO_Approver{App_id = 1, SGO_ID = "SGO-IT-2020-001", App_rownum = 1, App_pers_id = "B-12345",App_position = "IT Manager", txt_comment = "เข้าเงื่อนไข", App_status = "A", dtm_approved = DateTime.Now},
                new SGO_Approver{App_id = 2, SGO_ID = "SGO-IT-2020-002", App_rownum = 1, App_pers_id = "B-00002",App_position = "HR Manager", txt_comment = "ไม่เข้าเงื่อนไข", App_status = "D", dtm_approved = DateTime.Now}
            };
            return lsData;
        }
        public List<SGO_Department> GetDepartment()
        {
            List<SGO_Department> lsData = new List<SGO_Department>
            {
                new SGO_Department{dep_id = 1, dep_name = "IT",dep_status = "A"},
                new SGO_Department{dep_id = 2, dep_name = "HR",dep_status = "A"},
                new SGO_Department{dep_id = 3, dep_name = "AC",dep_status = "A"},
                new SGO_Department{dep_id = 4, dep_name = "Admin",dep_status = "A"},
                new SGO_Department{dep_id = 5, dep_name = "FM",dep_status = "A"}
            };
            return lsData;
        }
        public List<SGO_SHIFT> GetShift()
        {
            List<SGO_SHIFT> lsData = new List<SGO_SHIFT>
            {
                new SGO_SHIFT{Shift_id = 1, Shift_Time = "8.30 - 17.30",Shift_Desc = "", Ship_status = "A"},
                new SGO_SHIFT{Shift_id = 2, Shift_Time = "9.30 - 18.30",Shift_Desc = "", Ship_status = "A"},
                new SGO_SHIFT{Shift_id = 3, Shift_Time = "10.30 - 19.30",Shift_Desc = "", Ship_status = "A"},
                new SGO_SHIFT{Shift_id = 4, Shift_Time = "11.30 - 20.30",Shift_Desc = "", Ship_status = "A"},
                new SGO_SHIFT{Shift_id = 5, Shift_Time = "12.30 - 21.30",Shift_Desc = "", Ship_status = "A"}
            };
            return lsData;
        }
        public List<SGO_TEAM> GetTeamApprover()
        {
            List<SGO_TEAM> lsData = new List<SGO_TEAM>
            {
                new SGO_TEAM{Team_id = 1, SGO_ID = "SGO-IT-2020-001", Team_rownum = 1, pers_id = "B-00000", pers_position = "IT SUPPORT", Team_Status = "A",dtm_approved = DateTime.Now },
                new SGO_TEAM{Team_id = 2, SGO_ID = "SGO-IT-2020-001", Team_rownum = 2, pers_id = "B-00001", pers_position = "IT HELPDESK", Team_Status = ""},
                new SGO_TEAM{Team_id = 3, SGO_ID = "SGO-IT-2020-002", Team_rownum = 1, pers_id = "B-00003", pers_position = "HR Office", Team_Status = "A",dtm_approved = DateTime.Now }
            };
            return lsData;
        }
        public List<SGO_Status> GetStatus()
        {
            List<SGO_Status> lsData = new List<SGO_Status>
            {
                new SGO_Status{Status_id = 1, Status_code = "A", Status_name = "อนุมัติ", Cod_group = "APP",Status_Desc = "Approved / Active", Active = "A" },
                new SGO_Status{Status_id = 2, Status_code = "D", Status_name = "ไม่อนุมัติ", Cod_group = "APP",Status_Desc = "DisApproved / Not Active", Active = "A" },
                new SGO_Status{Status_id = 3, Status_code = "N", Status_name = "เอกสารใหม่", Cod_group = "DOC",Status_Desc = "สถานะเอกสาร", Active = "A" },
                new SGO_Status{Status_id = 4, Status_code = "DR", Status_name = "เอกสารฉบับร่าง", Cod_group = "DOC",Status_Desc = "สถานะเอกสาร", Active = "A" },
                new SGO_Status{Status_id = 5, Status_code = "WT", Status_name = "รอทีมตรวจสอบ", Cod_group = "DOC",Status_Desc = "สถานะเอกสาร", Active = "A" },
                new SGO_Status{Status_id = 6, Status_code = "WM", Status_name = "รอหัวหน้าตรวจสอบ", Cod_group = "DOC",Status_Desc = "สถานะเอกสาร", Active = "A" },
                new SGO_Status{Status_id = 7, Status_code = "WF", Status_name = "รอการเงินตรวจสอบ", Cod_group = "DOC",Status_Desc = "สถานะเอกสาร", Active = "A" },
                new SGO_Status{Status_id = 8, Status_code = "AP", Status_name = "เอกสารผ่านการตรวจสอบแล้ว", Cod_group = "DOC",Status_Desc = "สถานะเอกสาร", Active = "A" },
                new SGO_Status{Status_id = 9, Status_code = "C", Status_name = "ยกเลิกเอกสาร", Cod_group = "DOC",Status_Desc = "สถานะเอกสาร", Active = "A" },
                new SGO_Status{Status_id = 10, Status_code = "DA", Status_name = "เอกสารไม่ผ่านการอนุมัติ", Cod_group = "DOC",Status_Desc = "สถานะเอกสาร", Active = "A" }
            };
            return lsData;
        }
        public List<SGO_Type> GetTypeSGO()
        {
            List<SGO_Type> lsData = new List<SGO_Type>
            {
                new SGO_Type{ SGOType_ID = 1, SGOType_name = "ปรับปรุงเรื่องคุณภาพ", SGOType_desc = "ข้อเสนอแนะ", Cod_group = "SGO",SGOType_Status = "A"},
                new SGO_Type{ SGOType_ID = 2, SGOType_name = "ความปลอดภัย", SGOType_desc = "ข้อเสนอแนะ", Cod_group = "SGO",SGOType_Status = "A"},
                new SGO_Type{ SGOType_ID = 3, SGOType_name = "เพิ่มผลผลิต", SGOType_desc = "ข้อเสนอแนะ", Cod_group = "SGO",SGOType_Status = "A"},
                new SGO_Type{ SGOType_ID = 4, SGOType_name = "5 ส.", SGOType_desc = "ข้อเสนอแนะ", Cod_group = "SGO",SGOType_Status = "A"}
            };
            return lsData;
        }
        public List<SGO_HEAD> GetHead()
        {
            List<SGO_HEAD> lsData = new List<SGO_HEAD>();
            SGO_HEAD Doc1 = new SGO_HEAD();
            Doc1.SGO_ID = "SGO-IT-2020-001";
            Doc1.cod_Requester = "B-00000";
            Doc1.Fname = "TEST";
            Doc1.LName = "SGO";
            Doc1.Position = "Programmer";
            Doc1.Phone = "1144";
            Doc1.Dep_name = "IT";
            Doc1.Dep_Section = "Application";
            Doc1.dtm_Request = DateTime.Now;
            Doc1.Shift = 1;
            Doc1.Dep_ID_Request = 1;
            Doc1.SGOType_ID = "1,3";
            Doc1.Subject = "เสนอเปลี่ยนคอม";
            Doc1.Detail_Now = "คอมช้า";
            Doc1.Detail_Future = "เปลี่ยนคอมแม่งทั้งแผนก";
            Doc1.Detail_Result = "ได้คอมใหม่ ไวขึ้น";
            Doc1.Status = "WM";
            Doc1.cod_creator = "B-00000";
            Doc1.dtm_create = DateTime.Now;
            Doc1.cod_update = "";
            //Doc1.dtm_update = null;
            lsData.Add(Doc1);
            return lsData;
        }

    }
}
