using ConsoleApp1.BusCompanyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class ImportJsonService
    {
        public List<BusCompany> LoadDataFromFile(string filepath) {
            var str = System.IO.File.ReadAllText(filepath);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<BusCompany>>(str);
        }
    }
}
