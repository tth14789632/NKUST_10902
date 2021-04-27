using ConsoleApp1.BusCompanyData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class BusCompanyController : Controller
    {
        public IActionResult Index()
        {
            var service = new ConsoleApp1.Services.ImportJsonService();
            var file_path = ConsoleApp1.Utils.FilePath.GetFullPath("臺中市公車業者資料.json");
            List<BusCompany> datas = service.LoadDataFromFile(file_path);
            return View(datas);
        }
    }
}
