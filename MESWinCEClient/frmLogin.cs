using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CompactWebServer;
using System.Net;
using PubSubApi;
using System.Diagnostics;

namespace MESWinCEClient
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            // 登陆成功开启 亮灯服务
            //  StartServer();
        }

        private void libSet_Click(object sender, EventArgs e)
        {
            new frmSet().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var res = WinCEUtils.HttpHelp.Login(txtUid.Text, txtPwd.Text);

            if (res)
            {
                // WinCEUtils.Common.MessageBoxInfo("登陆成功");

                if (cbxRePwd.Checked)
                {
                    WinCEUtils.IniFilesHelp.Ini.UpdateParam("Pwd", WinCEUtils.Common.EncryptDES(txtPwd.Text, "mescloud"));
                    WinCEUtils.IniFilesHelp.Ini.UpdateParam("RePwd", "1");
                }
                else
                {
                    WinCEUtils.IniFilesHelp.Ini.UpdateParam("Pwd", WinCEUtils.Common.EncryptDES("", "mescloud"));
                    WinCEUtils.IniFilesHelp.Ini.UpdateParam("RePwd", "0");
                }
                WinCEUtils.IniFilesHelp.Ini.UpdateParam("Uid", txtUid.Text);
                this.Hide();
                // 登陆成功开启 亮灯服务
                // StartServer();


                new frmMain().ShowDialog();


                this.Close();

            }
            else
            {
                WinCEUtils.Common.MessageBoxEor("用户名或密码错误,登陆失败!!!");
            }
        }


        private void StartServer()
        {
            webConf = new WebServerConfiguration();
            webConf.IPAddress = IPAddress.Any;
            webConf.Port = DefaultSettings.BrokerPort;

            webServer = new WebServer(webConf);
            webServer.OnLogEvent += Log;
            webServer.Start();
        }
        private void Log(string type, string message)
        {
            // 可将 Log 记录到服务器 或者文本文件
        }


        WebServer webServer;
        WebServerConfiguration webConf;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUid.Text = WinCEUtils.IniFilesHelp.Ini.GetParam("Uid", "admin");
            if (WinCEUtils.IniFilesHelp.Ini.GetParam("RePwd", "0") == "1")
            {
                cbxRePwd.Checked = true;
                txtPwd.Text = WinCEUtils.Common.DecryptDES(WinCEUtils.IniFilesHelp.Ini.GetParam("Pwd", WinCEUtils.Common.EncryptDES("", "mescloud")), "mescloud");
                txtPwd.Focus();
                txtPwd.SelectAll();
            }
            else
            {
                txtPwd.Text = "";
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void txtUid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPwd.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Closing(object sender, CancelEventArgs e)
        {
            // 关闭窗口关闭亮灯服务
            // webServer.Stop();

            Process.GetCurrentProcess().Kill();
        }
    }
}