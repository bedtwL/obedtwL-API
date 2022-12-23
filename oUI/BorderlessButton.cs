using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obedtwLAPI.oUI
{
    public partial class BorderlessButton : UserControl
    {
        Label label;
        public BorderlessButton()
        {
            Console.WriteLine("[obedtwL API] BorderlessButton Enabling");
            label = new Label();
            label.AutoSize = false;
            label.Size = Size;
            label.Location = new Point(0, 0);
            label.Font = Font;
            label.Click += Label_Click;
            label.ForeColor = ForeColor;
            label.BackColor=BackColor;
            label.Text = Text;
            this.Controls.Add(label);
            
        }

        private void Label_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            
            base.OnTextChanged(e);
            label.Text = Text;

        }
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            label.BackColor = BackColor;
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            label.ForeColor = ForeColor;

        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            label.Font = Font;
        }
        protected override void Dispose(bool disposing)
        {
            Console.WriteLine("[obedtwL API] BorderlessButton Disposing");
            base.Dispose(disposing);
        }
    }
}
