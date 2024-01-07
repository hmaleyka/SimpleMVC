using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Business.Helpers
{
    public  static class FileManager
    {

        public static string Upload(this IFormFile file , string envPath, string foldername)
        {
            string filename = file.FileName;
            if (filename.Length > 64)
            {
                filename = filename.Substring(filename.Length - 64);
            }
            filename = Guid.NewGuid().ToString()+ filename;

            string path = envPath+foldername +filename;

            using(FileStream stream = new FileStream(path , FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return filename;
        }
    }
}
