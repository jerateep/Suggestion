using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SGO.Web.Controllers
{
    public class FileUploadController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;
        public FileUploadController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public void OnGet()
        {
        }

        public JsonResult OnPostUpload(List<IFormFile> files,string desc)
        {
            List<SGO.Models.MySQL.SGO_Files> lsFile = new List<Models.MySQL.SGO_Files>();
            foreach (var k in files)
            {
                SGO.Models.MySQL.SGO_Files FileData = new Models.MySQL.SGO_Files();
                FileData.FileName = k.FileName;
                FileData.Description = desc;
                using (var ms = new MemoryStream())
                {
                    k.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    //string s = Convert.ToBase64String(fileBytes);
                    FileData.bin_file = fileBytes;
                }
                lsFile.Add(FileData);
            }
            var JsonResult = lsFile.Select(k => new { k.FileName }).ToList();
            SGO.ViewModels.FileStore.Files = lsFile;


            //if (files != null && files.Count > 0)
            //{
            //    string folderName = "Upload";
            //    string webRootPath = _hostingEnvironment.WebRootPath;
            //    string newPath = Path.Combine(webRootPath, folderName);
            //    if (!Directory.Exists(newPath))
            //    {
            //        Directory.CreateDirectory(newPath);
            //    }
            //    foreach (IFormFile item in files)
            //    {
            //        if (item.Length > 0)
            //        {
            //            string fileName = ContentDispositionHeaderValue.Parse(item.ContentDisposition).FileName.Trim('"');
            //            string fullPath = Path.Combine(newPath, fileName);
            //            using (var stream = new FileStream(fullPath, FileMode.Create))
            //            {
            //                item.CopyTo(stream);
            //            }
            //        }
            //    }
            //    //return this.Content("Success");
            //}

            return Json(JsonResult);
        }


    }  
}