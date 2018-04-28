using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsCE.Forms;

namespace WinCEControl
{
    public partial class TextBoxInput : UserControl
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

        public override string Text
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
        public new event KeyPressEventHandler KeyPress;

        public TextBoxInput()
        {
            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (KeyPress != null)
            {
                //TODO
                KeyPress(sender, e);
            }
        }

        private void picInput_DoubleClick(object sender, EventArgs e)
        {
            InputPanel panl = new InputPanel();
            panl.Enabled = true;
        }

        private void TextBoxInput_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}