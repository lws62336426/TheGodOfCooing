using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGodOfCooking
{
    public class CustomerConfig
    {
        public string Guid { get; set; }
        public string RegisterNum { get; set; }
        public string OnlineNum { get; set; }
        public string SMSGuid { get; set; }
        public string SMSCode { get; set; }
        public string MasterFrontUrl { get; set; }
        public string MasterAdminUrl { get; set; }
        public string ImageUrl { get; set; }

        public JObject LoadConfig(string path)
        {
            string jsonStr = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<JObject>(jsonStr);
        }

        public void SaveConfig(string path,JObject jObject)
        {
            string content = JsonConvert.SerializeObject(jObject);
            File.WriteAllText(path, content);
        }
    }

    public class ServerConfig
    {
        public string FrontUrl { get; set; }
        public string AdminUrl { get; set; }
    }
}
