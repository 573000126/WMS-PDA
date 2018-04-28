namespace MESWinCEClient
{
    partial class frmLogin
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
            this.libSet = new System.Windows.Forms.LinkLabel();
            this.cbxRePwd = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUid = new MESWinCEClient.TextInput();
            this.SuspendLayout();
            // 
            // libSet
            // 
            this.libSet.Location = new System.Drawing.Point(157, 158);
            this.libSet.Name = "libSet";
            this.libSet.Size = new System.Drawing.Size(51, 20);
            this.libSet.TabIndex = 5;
            this.libSet.Text = "设置";
            this.libSet.Click += new System.EventHandler(this.libSet_Click);
            // 
            // cbxRePwd
            // 
            this.cbxRePwd.Location = new System.Drawing.Point(53, 155);
            this.cbxRePwd.Name = "cbxRePwd";
            this.cbxRePwd.Size = new System.Drawing.Size(89, 20);
            this.cbxRePwd.TabIndex = 2;
            this.cbxRePwd.Text = "记住密码";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular);
            this.btnExit.Location = new System.Drawing.Point(149, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular);
            this.btnLogin.Location = new System.Drawing.Point(12, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.txtPwd.Location = new System.Drawing.Point(53, 125);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(180, 22);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.Text = "123qwe";
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.Text = "用户名";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.Text = "SMT-智能仓储";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUid
            // 
            this.txtUid.BackColor = System.Drawing.SystemColors.Window;
            this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUid.Location = new System.Drawing.Point(53, 82);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(180, 28);
            this.txtUid.TabIndex = 9;
            this.txtUid.Txt = "admin";
            this.txtUid.TxtFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.txtUid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUid_KeyPress);
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.libSet);
            this.Controls.Add(this.cbxRePwd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmLogin_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel libSet;
        private System.Windows.Forms.CheckBox cbxRePwd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TextInput txtUid;
       
    }
}

