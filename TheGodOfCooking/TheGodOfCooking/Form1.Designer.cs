namespace TheGodOfCooking
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFront = new System.Windows.Forms.Label();
            this.txtFront = new System.Windows.Forms.TextBox();
            this.txtManagement = new System.Windows.Forms.TextBox();
            this.lblManagement = new System.Windows.Forms.Label();
            this.txtResource = new System.Windows.Forms.TextBox();
            this.lblResource = new System.Windows.Forms.Label();
            this.cbFront = new System.Windows.Forms.ComboBox();
            this.cbManagement = new System.Windows.Forms.ComboBox();
            this.cbResrouce = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtMasterFront = new System.Windows.Forms.TextBox();
            this.lblMasterFront = new System.Windows.Forms.Label();
            this.txtMasterManagement = new System.Windows.Forms.TextBox();
            this.lblMasterManagement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnt_position = new System.Windows.Forms.Button();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.btn_FileUplpad = new System.Windows.Forms.Button();
            this.lstSites = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_RedisKey = new System.Windows.Forms.TextBox();
            this.btn_DelRedis = new System.Windows.Forms.Button();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.Location = new System.Drawing.Point(3, 30);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(35, 12);
            this.lblFront.TabIndex = 0;
            this.lblFront.Text = "前台:";
            // 
            // txtFront
            // 
            this.txtFront.Location = new System.Drawing.Point(50, 27);
            this.txtFront.Name = "txtFront";
            this.txtFront.Size = new System.Drawing.Size(150, 21);
            this.txtFront.TabIndex = 1;
            // 
            // txtManagement
            // 
            this.txtManagement.Location = new System.Drawing.Point(293, 27);
            this.txtManagement.Name = "txtManagement";
            this.txtManagement.Size = new System.Drawing.Size(150, 21);
            this.txtManagement.TabIndex = 3;
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Location = new System.Drawing.Point(246, 30);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(35, 12);
            this.lblManagement.TabIndex = 2;
            this.lblManagement.Text = "后台:";
            // 
            // txtResource
            // 
            this.txtResource.Location = new System.Drawing.Point(547, 27);
            this.txtResource.Name = "txtResource";
            this.txtResource.Size = new System.Drawing.Size(150, 21);
            this.txtResource.TabIndex = 5;
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Location = new System.Drawing.Point(500, 30);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(35, 12);
            this.lblResource.TabIndex = 4;
            this.lblResource.Text = "资源:";
            // 
            // cbFront
            // 
            this.cbFront.FormattingEnabled = true;
            this.cbFront.Location = new System.Drawing.Point(50, 63);
            this.cbFront.Name = "cbFront";
            this.cbFront.Size = new System.Drawing.Size(120, 20);
            this.cbFront.TabIndex = 6;
            // 
            // cbManagement
            // 
            this.cbManagement.Location = new System.Drawing.Point(293, 63);
            this.cbManagement.Name = "cbManagement";
            this.cbManagement.Size = new System.Drawing.Size(120, 20);
            this.cbManagement.TabIndex = 9;
            // 
            // cbResrouce
            // 
            this.cbResrouce.FormattingEnabled = true;
            this.cbResrouce.Location = new System.Drawing.Point(547, 63);
            this.cbResrouce.Name = "cbResrouce";
            this.cbResrouce.Size = new System.Drawing.Size(120, 20);
            this.cbResrouce.TabIndex = 8;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(316, 145);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Button_MouseClick);
            // 
            // txtMasterFront
            // 
            this.txtMasterFront.Location = new System.Drawing.Point(410, 100);
            this.txtMasterFront.Name = "txtMasterFront";
            this.txtMasterFront.Size = new System.Drawing.Size(150, 21);
            this.txtMasterFront.TabIndex = 14;
            // 
            // lblMasterFront
            // 
            this.lblMasterFront.AutoSize = true;
            this.lblMasterFront.Location = new System.Drawing.Point(363, 103);
            this.lblMasterFront.Name = "lblMasterFront";
            this.lblMasterFront.Size = new System.Drawing.Size(47, 12);
            this.lblMasterFront.TabIndex = 13;
            this.lblMasterFront.Text = "主前台:";
            // 
            // txtMasterManagement
            // 
            this.txtMasterManagement.Location = new System.Drawing.Point(167, 100);
            this.txtMasterManagement.Name = "txtMasterManagement";
            this.txtMasterManagement.Size = new System.Drawing.Size(150, 21);
            this.txtMasterManagement.TabIndex = 12;
            // 
            // lblMasterManagement
            // 
            this.lblMasterManagement.AutoSize = true;
            this.lblMasterManagement.Location = new System.Drawing.Point(120, 103);
            this.lblMasterManagement.Name = "lblMasterManagement";
            this.lblMasterManagement.Size = new System.Drawing.Size(47, 12);
            this.lblMasterManagement.TabIndex = 11;
            this.lblMasterManagement.Text = "主后台:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtManagement);
            this.panel1.Controls.Add(this.txtMasterFront);
            this.panel1.Controls.Add(this.lblFront);
            this.panel1.Controls.Add(this.lblMasterFront);
            this.panel1.Controls.Add(this.txtFront);
            this.panel1.Controls.Add(this.txtMasterManagement);
            this.panel1.Controls.Add(this.lblManagement);
            this.panel1.Controls.Add(this.lblMasterManagement);
            this.panel1.Controls.Add(this.lblResource);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.txtResource);
            this.panel1.Controls.Add(this.cbResrouce);
            this.panel1.Controls.Add(this.cbFront);
            this.panel1.Controls.Add(this.cbManagement);
            this.panel1.Location = new System.Drawing.Point(43, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 183);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstSites);
            this.panel2.Controls.Add(this.bnt_position);
            this.panel2.Controls.Add(this.txt_Position);
            this.panel2.Controls.Add(this.btn_FileUplpad);
            this.panel2.Location = new System.Drawing.Point(43, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 398);
            this.panel2.TabIndex = 16;
            // 
            // bnt_position
            // 
            this.bnt_position.Location = new System.Drawing.Point(514, 17);
            this.bnt_position.Name = "bnt_position";
            this.bnt_position.Size = new System.Drawing.Size(75, 23);
            this.bnt_position.TabIndex = 19;
            this.bnt_position.Text = "选择路径";
            this.bnt_position.UseVisualStyleBackColor = true;
            this.bnt_position.Click += new System.EventHandler(this.Bnt_position_Click);
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(33, 19);
            this.txt_Position.Multiline = true;
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(460, 147);
            this.txt_Position.TabIndex = 18;
            // 
            // btn_FileUplpad
            // 
            this.btn_FileUplpad.Location = new System.Drawing.Point(622, 17);
            this.btn_FileUplpad.Name = "btn_FileUplpad";
            this.btn_FileUplpad.Size = new System.Drawing.Size(75, 23);
            this.btn_FileUplpad.TabIndex = 17;
            this.btn_FileUplpad.Text = "上传";
            this.btn_FileUplpad.UseVisualStyleBackColor = true;
            this.btn_FileUplpad.Click += new System.EventHandler(this.Btn_FileUplpad_Click);
            // 
            // lstSites
            // 
            this.lstSites.FormattingEnabled = true;
            this.lstSites.ItemHeight = 12;
            this.lstSites.Location = new System.Drawing.Point(33, 192);
            this.lstSites.Name = "lstSites";
            this.lstSites.Size = new System.Drawing.Size(460, 172);
            this.lstSites.TabIndex = 20;
            this.lstSites.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstSites_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_Database);
            this.panel3.Controls.Add(this.btn_DelRedis);
            this.panel3.Controls.Add(this.txt_RedisKey);
            this.panel3.Location = new System.Drawing.Point(44, 616);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 105);
            this.panel3.TabIndex = 17;
            // 
            // txt_RedisKey
            // 
            this.txt_RedisKey.Location = new System.Drawing.Point(32, 29);
            this.txt_RedisKey.Multiline = true;
            this.txt_RedisKey.Name = "txt_RedisKey";
            this.txt_RedisKey.Size = new System.Drawing.Size(460, 51);
            this.txt_RedisKey.TabIndex = 0;
            // 
            // btn_DelRedis
            // 
            this.btn_DelRedis.Location = new System.Drawing.Point(633, 43);
            this.btn_DelRedis.Name = "btn_DelRedis";
            this.btn_DelRedis.Size = new System.Drawing.Size(75, 23);
            this.btn_DelRedis.TabIndex = 1;
            this.btn_DelRedis.Text = "删除";
            this.btn_DelRedis.UseVisualStyleBackColor = true;
            this.btn_DelRedis.Click += new System.EventHandler(this.Btn_DelRedis_Click);
            // 
            // txt_Database
            // 
            this.txt_Database.Location = new System.Drawing.Point(513, 43);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(100, 21);
            this.txt_Database.TabIndex = 2;
            this.txt_Database.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 733);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFront;
        private System.Windows.Forms.TextBox txtFront;
        private System.Windows.Forms.TextBox txtManagement;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.TextBox txtResource;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.ComboBox cbFront;
        private System.Windows.Forms.ComboBox cbManagement;
        private System.Windows.Forms.ComboBox cbResrouce;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtMasterFront;
        private System.Windows.Forms.Label lblMasterFront;
        private System.Windows.Forms.TextBox txtMasterManagement;
        private System.Windows.Forms.Label lblMasterManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_FileUplpad;
        private System.Windows.Forms.Button bnt_position;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.ListBox lstSites;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_DelRedis;
        private System.Windows.Forms.TextBox txt_RedisKey;
        private System.Windows.Forms.TextBox txt_Database;
    }
}

