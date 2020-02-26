using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGO.Models;
using SGO.Models.API;
using SGO.Models.MySQL;
using SGO.ViewModels;
using SGO.Web.Data;
using SGO.WebService;
using static System.Net.WebRequestMethods;

namespace SGO.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly MySQLContext _entMy;
        public HomeController(MySQLContext entMy)
        {
            _entMy = entMy;
        }
        public IActionResult MainSGO()
        {
            var CookieUser = Request.Cookies["USER"];
            if (CookieUser != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }
        }
        public IActionResult CreateSGO(string _sgoID) 
        {
            SGOCreateVM Create = new SGOCreateVM();
            var CookieUser = Request.Cookies["USER"];
            //for test
            CookieUser = "B-00000";
            string Requester = CookieUser;
            if (string.IsNullOrEmpty(Requester))
            {
                return RedirectToAction("Login", "Auth");
            }
            else
            {
                var topic = new DummyData().GetTopic();
                var choice = new DummyData().GetTopicDetails();
                if (!string.IsNullOrEmpty(_sgoID))
                {
                    //requester edit

                    //for show Approver

                    //for show Account
                }
                else
                {
                    //New Sgo
                    // Call emp WebService
                    Employee EmpData = EmployeeService.GetEmployee(Requester);
                    Create.SGO_ID = "";
                    Create.Status_name = "เอกสารใหม่";
                    Create.cod_Requester = Requester;
                    Create.Fname = "นายเจ้าของ";
                    Create.LName = "เอกสาร";
                    Create.Dep_name = "IT";
                    Create.Dep_Section = "IT Application";
                    Create.dtm_Request = DateTime.Now.Date;
                    //Call WebService Get Approver
                    Create.Approver = new List<SGO_Approver>{ new SGO_Approver { App_pers_id = "B-1143", App_position = "IT Manager", App_name = "คุณเจอร์เทส เจอร์เทส"} };
                    Create.Team = new List<SGO_TEAM> { new SGO_TEAM { pers_id = Requester, pers_name = "นายเจ้าของ เอกสาร" , pers_position = "IT Support"} };
                    Create.LsFils = FileStore.Files;
                    //MasterData
                    Create.StatusAppMng = _entMy.SGO_Status.Where(k => k.Cod_group == "APP").ToList();
                    Create.department = _entMy.SGO_Department.ToList();
                    Create.SGOType = _entMy.SGO_Type.Where(x => x.Cod_group == "SGO" && x.SGOType_Status == "A").ToList();
                    Create.SHIFT = _entMy.SGO_SHIFT.ToList();
                    //FS
                    Create.TopicFs = (from c in choice
                              join t in topic.Where(g => g.@group == "FS") on c.topic_id equals t.topic_id
                              select new FSTableVM
                              {
                                  topic = t.topic,
                                  topic_id = c.topic_id,
                                  choice_row = c.choice_row,
                                  choie_id = c.choie_id,
                                  choice_name = c.choice_name
                              }).ToList();
                    var HeaderFS = Create.TopicFs.Select(s => s.choice_row).Distinct();
                    ViewData["HeaderFS"] = HeaderFS;
                    ViewData["topicFS"] = Create.TopicFs.Select(s => s.topic_id).Distinct();
                    ViewBag.indexFS = HeaderFS.Count();
                    //NonFS
                    Create.TopicNFs = (from c in choice
                                      join t in topic.Where(g => g.@group == "NFS") on c.topic_id equals t.topic_id
                                      select new FSTableVM
                                      {
                                          topic = t.topic,
                                          topic_id = c.topic_id,
                                          choice_row = c.choice_row,
                                          choie_id = c.choie_id,
                                          choice_name = c.choice_name
                                      }).ToList();
                    var HeaderNFS = Create.TopicNFs.Select(s => s.choice_row).Distinct();
                    ViewData["HeaderNFS"] = HeaderNFS;
                    ViewData["topicNFS"] = Create.TopicNFs.Select(s => s.topic_id).Distinct();
                    ViewBag.indexNFS = HeaderNFS.Count();
                }
            }
  
            return View(Create);
        }
        public IActionResult Save(SGOCreateVM SGO, List<string> lsSGO)
        {
            List<SGO_Files> LsFile = FileStore.Files;
            FileStore.Files = null;
            string _FullPath = @"C:\Users\jerateeps\Desktop\Storefile\";
            if (!Directory.Exists(_FullPath))
            {
                Directory.CreateDirectory(_FullPath);
            }

            foreach (var k in LsFile)
            {
                string Result = FilesMng.SaveFile(_FullPath + "\\" +k.FileName, k.bin_file);
                if (Result != "OK")
                {
                    break;
                }
            }
            foreach (var k in LsFile)
            {
                _entMy.SGO_Files.Add(new SGO_Files
                {
                    SGO_ID = SGO.SGO_ID,
                    FileName = k.FileName,
                    Description = k.Description,
                    ContentType = k.ContentType,
                    FullPath = _FullPath + "\\" + k.FileName,
                });
            }
            _entMy.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
