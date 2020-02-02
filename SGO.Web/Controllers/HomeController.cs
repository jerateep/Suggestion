using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGO.Models;
using SGO.ViewModels;
using SGO.Web.Data;

namespace SGO.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly MySQLContext _entMy;
        public HomeController(MySQLContext entMy)
        {
            _entMy = entMy;
        }
        public IActionResult CreateSGO() 
        {
            SGOCreateVM Create = new SGOCreateVM();
            Create.SGO_ID = "SGO-IT-2020-001";
            Create.Status_name = "เอกสารใหม่";
            Create.cod_Requester = "B-xxxx";
            Create.FName = "Demo";
            Create.LName = "SGO";
            Create.dtm_Request = DateTime.Now.Date;
            Create.Dep_name = "B-IT";
            Create.Subdep_name = "APP";
            Create.department = _entMy.SGO_Department.ToList();
            Create.SGOType = _entMy.SGO_Type.Where(x => x.Cod_group == "SGO" && x.SGOType_Status == "A").ToList();
            Create.SHIFT = _entMy.SGO_SHIFT.ToList();
            Create.Approver = new List<Models.MySQL.SGO_Approver>{ new Models.MySQL.SGO_Approver { App_pers_id = "B-1143",} };
            Create.StatusAppMng = _entMy.SGO_Status.Where(k => k.Cod_group == "Approved").ToList(); 
            return View(Create);
        }


        public IActionResult Save(SGOCreateVM SGO, List<string> cod_config)
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
