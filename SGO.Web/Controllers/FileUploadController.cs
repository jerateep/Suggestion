using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGO.ViewModels;

namespace SGO.Web.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly Data.MySQLContext _ent;
        public FileUploadController(Data.MySQLContext ent)
        {
            _ent = ent; ;
        }
        public void OnGet()
        {
        }

        public JsonResult OnPostUpload(List<IFormFile> files,string desc)
        {
            List<SGO.Models.MySQL.SGO_Files> lsFile = new List<Models.MySQL.SGO_Files>();
            lsFile = FileStore.Files != null ? FileStore.Files : null;
            int index = 1;
            if (lsFile != null)
            {
                index = (from c in lsFile orderby c.Id descending select c.Id).FirstOrDefault();
                index = index + 1;
            }
            else
            {
                lsFile = new List<Models.MySQL.SGO_Files>();
            }
            foreach (var k in files)
            {
                byte[] fileBytes;
                using (var ms = new MemoryStream())
                {
                    k.CopyTo(ms);
                    fileBytes = ms.ToArray();
                }
                lsFile.Add(new Models.MySQL.SGO_Files {
                    Id = index,
                    FileName = k.FileName,
                    Description = desc,
                    ContentType = k.ContentType,
                    bin_file = fileBytes
                });
                index ++;
            }
            var JsonResult = lsFile.Select(k => new {k.Id, k.FileName,k.Description }).ToList();
            SGO.ViewModels.FileStore.Files = lsFile;
            return Json(JsonResult);
        }

        public JsonResult OnPostDelete(int id)
        {
            List<SGO.Models.MySQL.SGO_Files> lsFile = new List<Models.MySQL.SGO_Files>();
            lsFile = FileStore.Files;
            lsFile.RemoveAll(x => x.Id == id);
            int index = 1;
            foreach (var k in lsFile)
            {
                k.Id = index;
                index++;
            }
            FileStore.Files = lsFile;
            var JsonResult = lsFile.Select(k => new { k.Id, k.FileName, k.Description }).ToList();
            SGO.ViewModels.FileStore.Files = lsFile;
            return Json(JsonResult);
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

    }
}