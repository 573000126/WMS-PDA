using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MESWinCEClient.ReelMove.Dtos;
using MESWinCEClient.ReelMove;

namespace MESWinCEClient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void listViewMenus_ItemActivate(object sender, EventArgs e)
        {
            this.Hide();
            var tag = ((ListView)sender).FocusedItem.Tag;
            if (tag is ReelMoveMethodDto)
            {
                var reelMoveMethodDto = tag as ReelMoveMethodDto;
                new frmReelMove(reelMoveMethodDto).ShowDialog();

            }
            else if (tag is string)
            {
                switch (((ListView)sender).FocusedItem.Tag.ToString())
                {
                    case "退出":
                        this.Close();
                        break;
                }
            }


            this.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 获取所有调拨策略
            var reelMoveMethods = WinCEUtils.HttpHelp.PostAbp<WinCEUtils.PagedResultDto<ReelMoveMethodDto>>
                ("/api/services/app/ReelMoveMethod/GetAll", new WinCEUtils.PagedResultRequestMESDto() { SkipCount = 0, MaxResultCount = int.MaxValue }).Result.Items;
            if (reelMoveMethods.Count > 0)
            {
                foreach (var item in reelMoveMethods)
                {
                    listViewMenus.Items.Add(new ListViewItem() { Tag = item, Text = item.Name });
                }

            }
            // 添加退出按钮
            listViewMenus.Items.Add(new ListViewItem() { Tag = "退出", Text = "退出" });
        }


    }
}