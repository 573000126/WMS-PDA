namespace MESWinCEClient
{
    partial class frmMain
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
            this.listViewMenus = new System.Windows.Forms.ListView();
            this.imageMenus = new System.Windows.Forms.ImageList();
            this.SuspendLayout();
            // 
            // listViewMenus
            // 
            this.listViewMenus.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMenus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewMenus.LargeImageList = this.imageMenus;
            this.listViewMenus.Location = new System.Drawing.Point(0, 0);
            this.listViewMenus.Name = "listViewMenus";
            this.listViewMenus.Size = new System.Drawing.Size(238, 270);
            this.listViewMenus.TabIndex = 7;
            this.listViewMenus.ItemActivate += new System.EventHandler(this.listViewMenus_ItemActivate);
            // 
            // imageMenus
            // 
            this.imageMenus.ImageSize = new System.Drawing.Size(65, 1);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.listViewMenus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "SMT-智能仓储";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMenus;
        private System.Windows.Forms.ImageList imageMenus;
    }
}