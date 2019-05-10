using Microsoft.Web.Administration;
using System.Drawing;
using System.Windows.Forms;

namespace TheGodOfCooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSites();
        }

        public void LoadSites()
        {
            using (ServerManager sm = ServerManager.OpenRemote("127.0.0.1"))
            {
                Control[] controls = new Control[sm.Sites.Count];
                foreach (var site in sm.Sites)
                {
                    Button button = new Button();
                    button.Name = "btn" + site.Name;
                    button.Text = site.Name;                    
                    button.Location = new Point(16, ((int)(site.Id-1) * 35) + 10);
                    button.MouseClick += Button_MouseClick;
                    Controls.Add(button);

                    TextBox textFront = new TextBox();
                    textFront.Name = "txt" + site.Name + "FrontUrl";
                    textFront.Location = new Point(128, ((int)(site.Id - 1) * 35) + 10);
                    Controls.Add(textFront);

                    TextBox textManagement = new TextBox();
                    textManagement.Name = "btxttn" + site.Name + "ManagementUrl";
                    textManagement.Location = new Point(256, ((int)(site.Id - 1) * 35) + 10);
                    Controls.Add(textManagement);

                    TextBox textResource = new TextBox();
                    textResource.Name = "txt" + site.Name + "ResourceUrl";
                    textResource.Location = new Point(384, ((int)(site.Id - 1) * 35) + 10);
                    Controls.Add(textResource);

                    Label label = new Label();
                    label.Name = "lbl" + site.Name;
                    label.Text = site.Applications[0].VirtualDirectories[0].PhysicalPath;
                    label.Location = new Point(512, ((int)(site.Id - 1) * 35) + 10);
                    label.Visible = false;
                    Controls.Add(label);
                }
            }
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            string sitename = button.Text;
            string frontUrl = Controls["txt" + sitename + "FrontUrl"].Text;
            string managementUrl = Controls["txt" + sitename + "ManagementUrl"].Text;
            string resourceUrl = Controls["txt" + sitename + "Resource"].Text;
            string filepath = Controls["lbl" + sitename].Text+"\\bin\\Handan.Config.dll";
        }
    }
}
