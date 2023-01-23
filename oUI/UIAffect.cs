using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obedtwLAPI.oUI
{
    internal class UIAffect
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // width of ellipse
int nHeightEllipse // height of ellipse
);
        public UIAffect() 
        {

        }
        public void Circle(Control control, PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, control.Width, control.Height);
            control.Region = new System.Drawing.Region(g);

        }
        public void Rounded(Control control,PaintEventArgs e)
        {
            control.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, 20, 20));
        }
    }
}
