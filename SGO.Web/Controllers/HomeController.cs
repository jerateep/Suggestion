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
using SGO.Models.MySQL;
using SGO.ViewModels;
using SGO.Web.Data;
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
        public IActionResult CreateSGO(string empid) 
        {

            SGOCreateVM Create = new SGOCreateVM();
            Models.MySQL.SGO_HEAD Data = new DummyData().GetHead().SingleOrDefault();
            Create.SGO_ID = Data.SGO_ID;
            Create.Status_name = "New";
            Create.cod_Requester = Data.cod_Requester;
            Create.Fname = Data.Fname;
            Create.LName = Data.LName;
            Create.dtm_Request = DateTime.Now.Date;
            Create.Dep_name = Data.Dep_name;
            Create.Dep_Section = Data.Dep_Section;
            Create.department = _entMy.SGO_Department.ToList();
            Create.SGOType = _entMy.SGO_Type.Where(x => x.Cod_group == "SGO" && x.SGOType_Status == "A").ToList();
            Create.SHIFT = _entMy.SGO_SHIFT.ToList();
            Create.Approver = new List<Models.MySQL.SGO_Approver>{ new Models.MySQL.SGO_Approver { App_pers_id = "B-1143",} };
            Create.StatusAppMng = _entMy.SGO_Status.Where(k => k.Cod_group == "Approved").ToList();
            if (Create.Status_name == "New")
            {
                Create.LsFils = FileStore.Files;
            }
            else
            {
               //from query database
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


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DownloadFile(int Id)
        {
            var Getall = FileStore.Files;
            var file = Getall.SingleOrDefault(k => k.Id == Id);
            string fullpath = @"C:\Users\jerateeps\Downloads\" + file.FileName;
            byte[] fileBytes = System.IO.File.ReadAllBytes(fullpath);
            // string fileName = "test";
            return File(fileBytes, file.ContentType, file.FileName);
        }
        public IActionResult MainSGO()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
