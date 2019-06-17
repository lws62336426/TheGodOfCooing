using Microsoft.Web.Administration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TheGodOfCooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSites(cbFront, cbManagement, cbResrouce);
        }

        private void Button_MouseClick(object sender, EventArgs e)
        {
            string frontUrl = txtFront.Text;
            string managementUrl = txtManagement.Text;
            string resourceUrl = txtResource.Text;
            string masterFrontUrl = txtMasterFront.Text;
            string masterManagementUrl = txtMasterManagement.Text;
            string frontFilepath = cbFront.SelectedValue + "\\bin\\Handan.Config.dll";
            string managementFilepath = cbManagement.SelectedValue + "\\bin\\Handan.Config.dll";

            CustomerConfig customerConfig = new CustomerConfig(frontFilepath, managementFilepath);
            var config = customerConfig.LoadConfig();
            if (!string.IsNullOrEmpty(frontUrl)) config.FrontUrl = frontUrl;
            if (!string.IsNullOrEmpty(managementUrl)) config.AdminUrl = managementUrl;
            if (!string.IsNullOrEmpty(resourceUrl)) config.ImageUrl = $"http://{resourceUrl}";
            if (!string.IsNullOrEmpty(masterFrontUrl)) config.MasterFrontUrl = masterFrontUrl;
            if (!string.IsNullOrEmpty(masterManagementUrl)) config.MasterAdminUrl = masterManagementUrl;
            customerConfig.SaveConfig(config);
            MessageBox.Show("Config文件已替换");

            Dictionary<string, string> dicSiteUrl = new Dictionary<string, string>();
            dicSiteUrl.Add(cbFront.Text, frontUrl);
            dicSiteUrl.Add(cbManagement.Text, managementUrl);
            dicSiteUrl.Add(cbResrouce.Text, resourceUrl);
            BindUrl(dicSiteUrl);
            MessageBox.Show("域名已添加");

        }

        public void LoadSites(params ComboBox[] comboBox)
        {
            using (ServerManager sm = ServerManager.OpenRemote("127.0.0.1"))
            {
                //同一数据源会触发同一个选择事件
                //var list= (from site in sm.Sites select new { site.Id, site.Name }).ToList();
                foreach (var cb in comboBox)
                {
                    cb.DataSource = (from site in sm.Sites select new { site.Applications[0].VirtualDirectories[0].PhysicalPath, site.Name }).ToList();
                    cb.ValueMember = "PhysicalPath";
                    cb.DisplayMember = "Name";
                }

                for (int i = 0; i < comboBox.Length; i++)
                {
                    comboBox[i].SelectedIndex = i;
                }
            }
        }

        public void BindUrl(string sitename, string url)
        {
            using (ServerManager sm = ServerManager.OpenRemote("127.0.0.1"))
            {
                string str = sm.Sites[sitename].Bindings[0].Host.Split(new char[] { ',' })[0];
                string bindingInformation = "*:80:" + str + "." + url;
                sm.Sites[sitename].Bindings.Add(bindingInformation, "http");
                sm.CommitChanges();
            }
        }

        public void BindUrl(IDictionary<string, string> dicSiteUrl)
        {
            using (ServerManager sm = ServerManager.OpenRemote("127.0.0.1"))
            {
                foreach (var info in dicSiteUrl)
                {
                    var allUrl = new List<string>();
                    foreach (var site in sm.Sites[info.Key].Bindings)
                    {
                        string str = site.Host.Split(new char[] { ',' })[0];
                        allUrl.Add(str);
                    }
                    string bindingInformation = "*:80:" + info.Value;
                    if (!allUrl.Contains(info.Value) && !string.IsNullOrEmpty(info.Value))
                        sm.Sites[info.Key].Bindings.Add(bindingInformation, "http");
                }
                sm.CommitChanges();
            }
        }
    }
}
