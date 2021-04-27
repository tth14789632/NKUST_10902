using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BusCompanyData
{
    public class BusCompany
    {
        [JsonProperty("客運業者")]
        public string 客運業者 { get; set; }

        [JsonProperty("電話")]
        public string 電話 { get; set; }

        [JsonProperty("地址")]
        public string 地址 { get; set; }

        [JsonProperty("服務時段")]
        public string 服務時段 { get; set; }

        [JsonProperty("申訴專線")]
        public string 申訴專線 { get; set; }

    }
}
