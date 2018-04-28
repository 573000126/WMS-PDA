using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace MESWinCEClient
{
    public partial class TextInput : UserControl
    {
        public Font TxtFont
        {

            get
            {
                //TODO
                return this.textBox.Font;
            }
            set
            {
                //TODO
                this.textBox.Font = value;
            }

        }

        public string Txt
        {
            get
            {
                //TODO
                return this.textBox.Text;
            }
            set
            {
                //TODO
                this.textBox.Text = value;
            }
        }

        public new string Text
        {
            get
            {
                //TODO
                return this.textBox.Text;
            }
            set
            {
                //TODO
                this.textBox.Text = value;
            }
        }
        // public new event KeyPressEventHandler KeyPress;

        public TextInput()
        {
            InitializeComponent();

            this.Height = this.textBox.Height + 6;

            this.picInput.Height = this.textBox.Height;
            this.picInput.Width = this.Height / 9 * 16;
            this.textBox.Top = 1;
            this.textBox.Width = this.Width - this.picInput.Width - 2;
        }

        private void picInput_DoubleClick(object sender, EventArgs e)
        {
            InputPanel panl = new InputPanel();
            panl.Enabled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Height != this.textBox.Height + 6)
            {
                this.Height = this.textBox.Height + 6;

                this.picInput.Height = this.textBox.Height;
                this.picInput.Width = this.Height / 9 * 16;

                this.textBox.Width = this.Width - this.picInput.Width - 2;
                this.textBox.Top = 1;
            }


            base.OnPaint(e);

        }
    }
}
