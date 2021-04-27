using ConsoleApp1.Services;
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonService = new ImportJsonService();
            var jsonDatas = jsonService.LoadDataFromFile(Utils.FilePath.GetFullPath("臺中市公車業者資料.txt"));
            Console.WriteLine(string.Format("有{0}筆資料", jsonDatas.Count));
            jsonDatas.ForEach(x =>
            {
                Console.WriteLine(string.Format("客運業者:{0}  電話:{1}  地址:{2}  服務時段:{3}  " +
                    "申訴專線:{4}",x.客運業者,x.電話,x.地址,x.服務時段,x.申訴專線));


            }
            );
            Console.ReadKey();
        }
    }
}
