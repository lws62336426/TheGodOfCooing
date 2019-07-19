using Microsoft.Web.Administration;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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

            Dictionary<string, string> dicSiteUrl = new Dictionary<string, string>
            {
                { cbFront.Text, frontUrl },
                { cbManagement.Text, managementUrl },
                { cbResrouce.Text, resourceUrl }
            };
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

                lstSites.DataSource = (from site in sm.Sites select new { site.Applications[0].VirtualDirectories[0].PhysicalPath, site.Name }).ToList();
                lstSites.ValueMember = "PhysicalPath";
                lstSites.DisplayMember = "Name";

                txt_Position.Text = sm.Sites[0].Applications[0].VirtualDirectories[0].PhysicalPath + "\\bin";
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

        private void Btn_FileUplpad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var filenames = fileDialog.FileNames;

                foreach (var filename in filenames)
                {
                    foreach (var sitePath in txt_Position.Text.Split(';'))
                    {
                        File.Copy(filename, sitePath.Replace("\r\n", "") + filename.Substring(filename.LastIndexOf("\\")), true);
                    }
                }

                MessageBox.Show("文件替换成功");
            }
        }

        private void Bnt_position_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();

            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = browserDialog.SelectedPath;
                txt_Position.Text = filePath;
            }
        }

        private void LstSites_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lstSites = (ListBox)sender;
            int startIndex = txt_Position.Text.LastIndexOf("Front\\", StringComparison.OrdinalIgnoreCase) + "Front".Length;
            if (startIndex == "Front".Length - 1) startIndex = txt_Position.Text.LastIndexOf("Management\\", StringComparison.OrdinalIgnoreCase) + "Management".Length;
            var commonPath = txt_Position.Text.Substring(startIndex);
            var appendPath = "\r\n" + lstSites.SelectedValue + commonPath;

            if (txt_Position.Text.Contains(appendPath))
            {
                txt_Position.Text = txt_Position.Text.Replace(appendPath, "");
            }
            else
            {
                txt_Position.Text += ";" + appendPath;
            }
        }

        private void Btn_DelRedis_Click(object sender, EventArgs e)
        {
            var sitePath = lstSites.SelectedValue;
            var redisConfigPath = sitePath + "\\bin\\Resource\\redisconfig.xml";
            XElement element = XElement.Load(redisConfigPath).Element("Item");
            var host = element.Element("RedisHost").Value;
            int port = int.Parse(element.Element("RedisPort").Value);
            var password = element.Element("RedisPWD").Value;

            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect($"{host}:{port},password={password}");
            var database = int.Parse(txt_Database.Text);

            string key = txt_RedisKey.Text;
            if (database == -1)
            {
                for (int i = 0; i < 15; i++)
                {
                    DelRedis(redis, host, port, i, key);
                }
            }
            else
            {
                DelRedis(redis, host, port, database, key);
            }

            MessageBox.Show("缓存清楚成功");
        }

        private void DelRedis(ConnectionMultiplexer redis, string host, int port, int database, string key)
        {
            IDatabase db;
            db = redis.GetDatabase(database);
            if (key.EndsWith("*"))
            {
                var keys = redis.GetServer(host, port).Keys(database, key);
                db.KeyDelete(keys.ToArray());
            }
            else
            {
                db.KeyDelete(key);
            }
        }
    }
}
