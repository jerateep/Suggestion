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
        public List<SGO_Topic> GetTopic()
        {
            List<SGO_Topic> lsData = new List<SGO_Topic>
            {
                new SGO_Topic{ topic_id = 1, topic = "จำนวน ชม. (คิดต่อปฎิทิน)", group = "FS", status = "A"},
                new SGO_Topic{ topic_id = 2, topic = "รางวัล (บาท)", group = "FS", status = "A"},
                new SGO_Topic{ topic_id = 3, topic = "รางวัลแสตมป์ไอเดีย (ดวง)", group = "FS", status = "A"},
                new SGO_Topic{ topic_id = 4, topic = "ความคิดริเริ่ม / ความใหม่", group = "NFS", status = "A"},
                new SGO_Topic{ topic_id = 5, topic = "ความพยายาม / วิจัย / ค้นคว้า / ทดลอง", group = "NFS", status = "A"},
                new SGO_Topic{ topic_id = 6, topic = "ความสมบูรณ์ และ การประยุกต์ใช้", group = "NFS", status = "A"},
                new SGO_Topic{ topic_id = 7, topic = "คุณภาพ", group = "NFS", status = "A"},
                new SGO_Topic{ topic_id = 8, topic = "ความปลอดภัย หรือ สุขอนามัย", group = "NFS", status = "A"},
                new SGO_Topic{ topic_id = 9, topic = "ประสิทธิภาพ", group = "NFS", status = "A"},
            };
            return lsData;
        }
        public List<SGO_TopicChoice> GetTopicDetails()
        {

            List<SGO_TopicChoice> lsData = new List<SGO_TopicChoice>
            {
                new SGO_TopicChoice{ choie_id = 1, choice_row = "A", choice_name = "5000 UP ", topic_id = 1, status = "A"},
                new SGO_TopicChoice{ choie_id = 2, choice_row = "B", choice_name = "3500 - 4999", topic_id = 1, status = "A"},
                new SGO_TopicChoice{ choie_id = 3, choice_row = "C", choice_name = "2000 - 3499", topic_id = 1, status = "A"},
                new SGO_TopicChoice{ choie_id = 4, choice_row = "D", choice_name = "1000 - 1999", topic_id = 1, status = "A"},
                new SGO_TopicChoice{ choie_id = 5, choice_row = "E", choice_name = "500 - 999", topic_id = 1, status = "A"},
                new SGO_TopicChoice{ choie_id = 6, choice_row = "F", choice_name = "100 - 499", topic_id = 1, status = "A"},
                new SGO_TopicChoice{ choie_id = 7, choice_row = "G", choice_name = "30 - 99", topic_id = 1, status = "A"},
                new SGO_TopicChoice{ choie_id = 8, choice_row = "H", choice_name = "10 - 29", topic_id = 1, status = "A"},
                new SGO_TopicChoice{ choie_id = 9, choice_row = "I", choice_name = "1 - 9", topic_id = 1, status = "A"},

                new SGO_TopicChoice{ choie_id = 10, choice_row = "A", choice_name = "1,500", topic_id = 2, status = "A"},
                new SGO_TopicChoice{ choie_id = 11, choice_row = "B", choice_name = "1,000", topic_id = 2, status = "A"},
                new SGO_TopicChoice{ choie_id = 12, choice_row = "C", choice_name = "800", topic_id = 2, status = "A"},
                new SGO_TopicChoice{ choie_id = 13, choice_row = "D", choice_name = "500", topic_id = 2, status = "A"},
                new SGO_TopicChoice{ choie_id = 14, choice_row = "E", choice_name = "300", topic_id = 2, status = "A"},
                new SGO_TopicChoice{ choie_id = 15, choice_row = "F", choice_name = "150", topic_id = 2, status = "A"},
                new SGO_TopicChoice{ choie_id = 16, choice_row = "G", choice_name = "70", topic_id = 2, status = "A"},
                new SGO_TopicChoice{ choie_id = 17, choice_row = "H", choice_name = "60", topic_id = 2, status = "A"},
                new SGO_TopicChoice{ choie_id = 18, choice_row = "I", choice_name = "50", topic_id = 2, status = "A"},
                
                new SGO_TopicChoice{ choie_id = 19, choice_row = "A", choice_name = "75", topic_id = 3, status = "A"},
                new SGO_TopicChoice{ choie_id = 20, choice_row = "B", choice_name = "50", topic_id = 3, status = "A"},  
                new SGO_TopicChoice{ choie_id = 21, choice_row = "C", choice_name = "40", topic_id = 3, status = "A"},  
                new SGO_TopicChoice{ choie_id = 22, choice_row = "D", choice_name = "25", topic_id = 3, status = "A"},  
                new SGO_TopicChoice{ choie_id = 23, choice_row = "E", choice_name = "15", topic_id = 3, status = "A"},  
                new SGO_TopicChoice{ choie_id = 24, choice_row = "F", choice_name = "8", topic_id = 3, status = "A"},   
                new SGO_TopicChoice{ choie_id = 25, choice_row = "G", choice_name = "4", topic_id = 3, status = "A"},   
                new SGO_TopicChoice{ choie_id = 26, choice_row = "H", choice_name = "3", topic_id = 3, status = "A"},   
                new SGO_TopicChoice{ choie_id = 27, choice_row = "I", choice_name = "2", topic_id = 3, status = "A"},

                new SGO_TopicChoice{ choie_id = 28, choice_row = "5", choice_name = "ดีมาก แปลกใหม่", topic_id = 4, status = "A"},
                new SGO_TopicChoice{ choie_id = 29, choice_row = "4", choice_name = "พัฒนาจากแนวคิดเดิม", topic_id = 4, status = "A"},
                new SGO_TopicChoice{ choie_id = 30, choice_row = "3", choice_name = "พัฒนาจากแนวเดิมพอควร", topic_id = 4, status = "A"}, 
                new SGO_TopicChoice{ choie_id = 31, choice_row = "2", choice_name = "เกิดขึ้นเองแบบง่ายๆ", topic_id = 4, status = "A"},
                new SGO_TopicChoice{ choie_id = 32, choice_row = "1", choice_name = "ลอกเลียนแบบและปรับแต่ง", topic_id = 4, status = "A"}, 
                new SGO_TopicChoice{ choie_id = 33, choice_row = "0", choice_name = "ลอกเลียนแบบโดยไม่มีการพัฒนา", topic_id = 4, status = "A"},

                new SGO_TopicChoice{ choie_id = 34, choice_row = "5", choice_name = "มากที่สุด", topic_id = 5, status = "A"},
                new SGO_TopicChoice{ choie_id = 35, choice_row = "4", choice_name = "มาก", topic_id = 5, status = "A"},
                new SGO_TopicChoice{ choie_id = 36, choice_row = "3", choice_name = "ค่อนข้างมาก", topic_id = 5, status = "A"},
                new SGO_TopicChoice{ choie_id = 37, choice_row = "2", choice_name = "ปานกลาง", topic_id = 5, status = "A"},
                new SGO_TopicChoice{ choie_id = 38, choice_row = "1", choice_name = "เล็กน้อย", topic_id = 5, status = "A"},
                new SGO_TopicChoice{ choie_id = 39, choice_row = "0", choice_name = "ไม่มี", topic_id = 5, status = "A"},

                new SGO_TopicChoice{ choie_id = 40, choice_row = "5", choice_name = "ใช้ได้กับงาน / หน่วยงานอื่น", topic_id = 6, status = "A"},
                new SGO_TopicChoice{ choie_id = 41, choice_row = "4", choice_name = "ใช้ปฏิบัติได้แน่นอน", topic_id = 6, status = "A"},
                new SGO_TopicChoice{ choie_id = 42, choice_row = "3", choice_name = "ปรับแต่งเล็กน้อยก่อนใช้", topic_id = 6, status = "A"},
                new SGO_TopicChoice{ choie_id = 43, choice_row = "2", choice_name = "ปรับแต่งพอสมควรก่อนใช้", topic_id = 6, status = "A"},
                new SGO_TopicChoice{ choie_id = 44, choice_row = "1", choice_name = "ปรับแต่งมากก่อนใช้", topic_id = 6, status = "A"},
                new SGO_TopicChoice{ choie_id = 45, choice_row = "0", choice_name = "ปรับแต่งทั้งหมด", topic_id = 6, status = "A"},

                new SGO_TopicChoice{ choie_id = 46, choice_row = "5", choice_name = "คุณภาพดีเยี่ยม", topic_id = 7, status = "A"},
                new SGO_TopicChoice{ choie_id = 47, choice_row = "4", choice_name = "คุณภาพดีขึ้นมาก", topic_id = 7, status = "A"},
                new SGO_TopicChoice{ choie_id = 48, choice_row = "3", choice_name = "คุณภาพดีขึ้นพอสมควร", topic_id = 7, status = "A"},
                new SGO_TopicChoice{ choie_id = 49, choice_row = "2", choice_name = "คุณภาพดีขึ้นเล็กน้อย", topic_id = 7, status = "A"},
                new SGO_TopicChoice{ choie_id = 50, choice_row = "1", choice_name = "คุณภาพเหมือนเดิม", topic_id = 7, status = "A"},
                new SGO_TopicChoice{ choie_id = 51, choice_row = "0", choice_name = "ไม่เกี่ยวข้องกับคุณภาพ", topic_id = 7, status = "A"},
            };
            return lsData;
        }
    }
}
