namespace MESWinCEClient
{
    partial class TextInput
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextInput));
            this.textBox = new System.Windows.Forms.TextBox();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(63, 23);
            this.textBox.TabIndex = 4;
            // 
            // picInput
            // 
            this.picInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.picInput.Image = ((System.Drawing.Image)(resources.GetObject("picInput.Image")));
            this.picInput.Location = new System.Drawing.Point(69, 0);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(37, 70);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInput.DoubleClick += new System.EventHandler(this.picInput_DoubleClick);
            // 
            // TextInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.picInput);
            this.Name = "TextInput";
            this.Size = new System.Drawing.Size(106, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.PictureBox picInput;
    }
}
