using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SGO.Web
{
    public class FilesMng
    {
        public static string SaveFile(string _FullPath, byte [] file)
        {
            string Result = "OK";
            try
            {
                File.WriteAllBytes(_FullPath, file);

            }
            catch (Exception ex)
            {

                Result = ex.Message;
            }
            return Result;
        }
    }
}
