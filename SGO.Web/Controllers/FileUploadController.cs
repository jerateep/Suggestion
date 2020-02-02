using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SGO.Web.Controllers
{
    public class FileUploadController : Controller
    {
        [HttpPost]
        public IActionResult Upload(IFormFile[] files)
        {
            // Iterate through uploaded files array
            foreach (var file in files)
            {
                // Extract file name from whatever was posted by browser
                var fileName = System.IO.Path.GetFileName(file.FileName);

                // If file with same name exists delete it
                if (System.IO.File.Exists(fileName))
                {
                    System.IO.File.Delete(fileName);
                }

                // Create new local file and copy contents of uploaded file
                using (var localFile = System.IO.File.OpenWrite(fileName))
                using (var uploadedFile = file.OpenReadStream())
                {
                    uploadedFile.CopyTo(localFile);
                }
            }

            ViewBag.Message = "Files successfully uploaded";

            return View();
        }

        public IActionResult SaveFile(IFormFile[] files)
        {
                return View();
        }
    }  
}