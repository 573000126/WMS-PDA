namespace MESWinCEClient
{
    partial class frmSet
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboTenant = new System.Windows.Forms.ComboBox();
            this.btnQueryTenant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLightSer = new MESWinCEClient.TextInput();
            this.txtSerIp = new MESWinCEClient.TextInput();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.Text = "SerIp:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnSave.Location = new System.Drawing.Point(109, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnClose.Location = new System.Drawing.Point(175, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboTenant
            // 
            this.cboTenant.Location = new System.Drawing.Point(66, 48);
            this.cboTenant.Name = "cboTenant";
            this.cboTenant.Size = new System.Drawing.Size(118, 23);
            this.cboTenant.TabIndex = 6;
            // 
            // btnQueryTenant
            // 
            this.btnQueryTenant.Location = new System.Drawing.Point(187, 48);
            this.btnQueryTenant.Name = "btnQueryTenant";
            this.btnQueryTenant.Size = new System.Drawing.Size(48, 24);
            this.btnQueryTenant.TabIndex = 5;
            this.btnQueryTenant.Text = "查询";
            this.btnQueryTenant.Click += new System.EventHandler(this.btnQueryTenant_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.Text = "SerIp:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.Text = "登陆到:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.Text = "LSerIp:";
            // 
            // txtLightSer
            // 
            this.txtLightSer.BackColor = System.Drawing.SystemColors.Window;
            this.txtLightSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLightSer.Location = new System.Drawing.Point(66, 77);
            this.txtLightSer.Name = "txtLightSer";
            this.txtLightSer.Size = new System.Drawing.Size(169, 28);
            this.txtLightSer.TabIndex = 12;
            this.txtLightSer.Txt = "";
            this.txtLightSer.TxtFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            // 
            // txtSerIp
            // 
            this.txtSerIp.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerIp.Location = new System.Drawing.Point(66, 13);
            this.txtSerIp.Name = "txtSerIp";
            this.txtSerIp.Size = new System.Drawing.Size(169, 28);
            this.txtSerIp.TabIndex = 11;
            this.txtSerIp.Txt = "";
            this.txtSerIp.TxtFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            // 
            // frmSet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.txtLightSer);
            this.Controls.Add(this.txtSerIp);
            this.Controls.Add(this.cboTenant);
            this.Controls.Add(this.btnQueryTenant);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSet";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.frmSet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboTenant;
        private System.Windows.Forms.Button btnQueryTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TextInput txtSerIp;
        private TextInput txtLightSer;
    }
}