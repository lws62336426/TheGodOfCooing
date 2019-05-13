using Newtonsoft.Json;
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
        /// 客户Guid
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// 注册人数
        /// </summary>
        public int RegisterNum { get; set; }

        /// <summary>
        /// 在线人数
        /// </summary>
        public int OnlineNum { get; set; }

        /// <summary>
        /// 管理人数
        /// </summary>
        public int ManagerNum { get; set; }

        /// <summary>
        /// 机器人数
        /// </summary>
        public int RobotNum { get; set; }

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
        /// 客户短信GUID
        /// </summary>
        public string SMSGuid { get; set; }

        /// <summary>
        /// 客户短信标识
        /// </summary>
        public string SMSCode { get; set; }

        /// <summary>
        /// 主房间前台地址
        /// </summary>
        public string MasterFrontUrl { get; set; }

        /// <summary>
        /// 主房间后台地址
        /// </summary>
        public string MasterAdminUrl { get; set; }

        private string FrontFilepath { get; set; }
        private string ManagementFilepath { get; set; }

        public CustomerConfig(string frontFilepath,string managementFilepath)
        {
            FrontFilepath = frontFilepath;
            ManagementFilepath = managementFilepath;
        }

        public CustomerConfig LoadConfig()
        {
            var content = File.ReadAllText(FrontFilepath);
            return JsonConvert.DeserializeObject<CustomerConfig>(content);
        }

        public void SaveConfig(CustomerConfig config)
        {
            string content = JsonConvert.SerializeObject(config);
            File.WriteAllText(FrontFilepath, content);
            File.WriteAllText(ManagementFilepath, content);
        }
    }
}
