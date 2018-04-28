using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MESWinCEClient
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WinCEUtils.IniFilesHelp.Ini.UpdateParam("BaseUrl", txtSerIp.Text);
            WinCEUtils.IniFilesHelp.Ini.UpdateParam("LightSer", txtLightSer.Text);
            try
            {
                WinCEUtils.Tenant tenant = (WinCEUtils.Tenant)cboTenant.SelectedItem;

                WinCEUtils.IniFilesHelp.Ini.UpdateParam("TenantId", tenant.TenantId);
                WinCEUtils.IniFilesHelp.Ini.UpdateParam("TenantName", tenant.Name);


            }
            catch
            {


            }

            this.Close();
        }

        private void btnQueryTenant_Click(object sender, EventArgs e)
        {
            var tenant = WinCEUtils.HttpHelp.GetTenantByKeyName(cboTenant.Text);

            if (tenant == null)
            {
                MessageBox.Show("请确保服务器IP设置正确");
                return;
            }
            cboTenant.Items.Clear();
            foreach (var item in tenant)
            {
                cboTenant.Items.Add(item);
            }
        }

        private void frmSet_Load(object sender, EventArgs e)
        {
            txtSerIp.Text = WinCEUtils.IniFilesHelp.Ini.GetParam("BaseUrl", "http://localhost");
            txtLightSer.Text = WinCEUtils.IniFilesHelp.Ini.GetParam("LightSer", "http://localhost");

            try
            {
                var tenantId = WinCEUtils.IniFilesHelp.Ini.GetParam("TenantId", "");
                var tenantName = WinCEUtils.IniFilesHelp.Ini.GetParam("TenantName", "主机");

                cboTenant.Items.Add(new WinCEUtils.Tenant() { Name = tenantName, TenantId = tenantId });

                cboTenant.SelectedIndex = 0;

            }
            catch
            {


            }
        }


    }
}