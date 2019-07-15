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
        /// <summary>
        /// 前台域名
        /// </summary>
        public string FrontUrl { get; set; }

        /// <summary>
        /// 后台域名
        /// </summary>
        public string AdminUrl { get; set; }

        /// <summary>
        /// 图片域名
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 主房间前台地址
        /// </summary>
        public string MasterFrontUrl { get; set; }

        /// <summary>
        /// 主房间后台地址
        /// </summary>
        public string MasterAdminUrl { get; set; }

        public JObject LoadConfig(string path)
        {
            string jsonStr = System.IO.File.ReadAllText(path);
            return  JsonConvert.DeserializeObject<JObject>(jsonStr);
        }
    }
}
