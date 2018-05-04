namespace MESWinCEClient.ReelMove
{
    partial class frmReelMove
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
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labReel = new System.Windows.Forms.Label();
            this.ckbIsContinuity = new System.Windows.Forms.CheckBox();
            this.txtShlefLab = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lvwReelInfo = new System.Windows.Forms.ListView();
            this.reelP = new System.Windows.Forms.ColumnHeader();
            this.reelV = new System.Windows.Forms.ColumnHeader();
            this.panKW = new System.Windows.Forms.Panel();
            this.txtmag = new System.Windows.Forms.TextBox();
            this.panReelInfo = new System.Windows.Forms.Panel();
            this.panReceiveds = new System.Windows.Forms.Panel();
            this.cboIQCCheckId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panKW.SuspendLayout();
            this.panReelInfo.SuspendLayout();
            this.panReceiveds.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnClose.Location = new System.Drawing.Point(175, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.Text = "库位标签";
            // 
            // labReel
            // 
            this.labReel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.labReel.Location = new System.Drawing.Point(3, 8);
            this.labReel.Name = "labReel";
            this.labReel.Size = new System.Drawing.Size(85, 20);
            this.labReel.Text = "料盘信息";
            // 
            // ckbIsContinuity
            // 
            this.ckbIsContinuity.Location = new System.Drawing.Point(73, 32);
            this.ckbIsContinuity.Name = "ckbIsContinuity";
            this.ckbIsContinuity.Size = new System.Drawing.Size(100, 20);
            this.ckbIsContinuity.TabIndex = 15;
            this.ckbIsContinuity.Text = "连续上架";
            // 
            // txtShlefLab
            // 
            this.txtShlefLab.Location = new System.Drawing.Point(73, 4);
            this.txtShlefLab.Name = "txtShlefLab";
            this.txtShlefLab.Size = new System.Drawing.Size(156, 23);
            this.txtShlefLab.TabIndex = 16;
            this.txtShlefLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShlefLab_KeyPress);
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(73, 3);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(156, 23);
            this.txtBarCode.TabIndex = 16;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // lvwReelInfo
            // 
            this.lvwReelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lvwReelInfo.Columns.Add(this.reelP);
            this.lvwReelInfo.Columns.Add(this.reelV);
            this.lvwReelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwReelInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            listViewItem13.BackColor = System.Drawing.SystemColors.Control;
            listViewItem13.Text = "料卷号";
            listViewItem14.BackColor = System.Drawing.SystemColors.Control;
            listViewItem14.Text = "料号";
            listViewItem15.BackColor = System.Drawing.SystemColors.Control;
            listViewItem15.Text = "数量";
            listViewItem16.BackColor = System.Drawing.SystemColors.Control;
            listViewItem16.Text = "生产日期";
            listViewItem17.BackColor = System.Drawing.SystemColors.Control;
            listViewItem17.Text = "批号";
            listViewItem18.BackColor = System.Drawing.SystemColors.Control;
            listViewItem18.Text = "供应商";
            this.lvwReelInfo.Items.Add(listViewItem13);
            this.lvwReelInfo.Items.Add(listViewItem14);
            this.lvwReelInfo.Items.Add(listViewItem15);
            this.lvwReelInfo.Items.Add(listViewItem16);
            this.lvwReelInfo.Items.Add(listViewItem17);
            this.lvwReelInfo.Items.Add(listViewItem18);
            this.lvwReelInfo.Location = new System.Drawing.Point(0, 141);
            this.lvwReelInfo.Name = "lvwReelInfo";
            this.lvwReelInfo.Size = new System.Drawing.Size(238, 52);
            this.lvwReelInfo.TabIndex = 17;
            this.lvwReelInfo.View = System.Windows.Forms.View.Details;
            // 
            // reelP
            // 
            this.reelP.Text = "料盘属性";
            this.reelP.Width = 75;
            // 
            // reelV
            // 
            this.reelV.Text = "属性值";
            this.reelV.Width = 150;
            // 
            // panKW
            // 
            this.panKW.Controls.Add(this.txtShlefLab);
            this.panKW.Controls.Add(this.label1);
            this.panKW.Controls.Add(this.ckbIsContinuity);
            this.panKW.Dock = System.Windows.Forms.DockStyle.Top;
            this.panKW.Location = new System.Drawing.Point(0, 60);
            this.panKW.Name = "panKW";
            this.panKW.Size = new System.Drawing.Size(238, 51);
            // 
            // txtmag
            // 
            this.txtmag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtmag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtmag.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.txtmag.Location = new System.Drawing.Point(0, 193);
            this.txtmag.Multiline = true;
            this.txtmag.Name = "txtmag";
            this.txtmag.ReadOnly = true;
            this.txtmag.Size = new System.Drawing.Size(238, 45);
            this.txtmag.TabIndex = 22;
            // 
            // panReelInfo
            // 
            this.panReelInfo.Controls.Add(this.txtBarCode);
            this.panReelInfo.Controls.Add(this.labReel);
            this.panReelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panReelInfo.Location = new System.Drawing.Point(0, 30);
            this.panReelInfo.Name = "panReelInfo";
            this.panReelInfo.Size = new System.Drawing.Size(238, 30);
            // 
            // panReceiveds
            // 
            this.panReceiveds.Controls.Add(this.cboIQCCheckId);
            this.panReceiveds.Controls.Add(this.label3);
            this.panReceiveds.Dock = System.Windows.Forms.DockStyle.Top;
            this.panReceiveds.Location = new System.Drawing.Point(0, 0);
            this.panReceiveds.Name = "panReceiveds";
            this.panReceiveds.Size = new System.Drawing.Size(238, 30);
            // 
            // cboIQCCheckId
            // 
            this.cboIQCCheckId.Location = new System.Drawing.Point(73, 5);
            this.cboIQCCheckId.Name = "cboIQCCheckId";
            this.cboIQCCheckId.Size = new System.Drawing.Size(156, 23);
            this.cboIQCCheckId.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.Text = "IQC检验单";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 32);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 30);
            this.panel1.Visible = false;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(73, 3);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(156, 23);
            this.txtQty.TabIndex = 16;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.Text = "数量";
            // 
            // frmReelMove
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.txtmag);
            this.Controls.Add(this.lvwReelInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panKW);
            this.Controls.Add(this.panReelInfo);
            this.Controls.Add(this.panReceiveds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReelMove";
            this.Text = "调拨";
            this.Load += new System.EventHandler(this.frmReelMove_Load);
            this.panKW.ResumeLayout(false);
            this.panReelInfo.ResumeLayout(false);
            this.panReceiveds.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labReel;
        private System.Windows.Forms.CheckBox ckbIsContinuity;
        private System.Windows.Forms.TextBox txtShlefLab;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.ListView lvwReelInfo;
        private System.Windows.Forms.ColumnHeader reelP;
        private System.Windows.Forms.ColumnHeader reelV;
        private System.Windows.Forms.Panel panKW;
        private System.Windows.Forms.TextBox txtmag;
        private System.Windows.Forms.Panel panReelInfo;
        private System.Windows.Forms.Panel panReceiveds;
        private System.Windows.Forms.ComboBox cboIQCCheckId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label2;
    }
}
