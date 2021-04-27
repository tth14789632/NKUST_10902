using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public static class FilePath
    {
        public static string GetFullPath(string filename) {
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"App_Data",filename);
        }
    }
}

