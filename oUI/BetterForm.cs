using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obedtwLAPI.oUI
{
    internal class BetterForm:Form
    {
        public bool CanToggleFullScreen=false;
        public bool IsFullScreen=false;
        public BetterForm() 
        {

        }
        public void UpdateFullScreen()
        {
            if (IsFullScreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                TopMost = true;
                WindowState = FormWindowState.Maximized;


            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                TopMost = false;
                WindowState = FormWindowState.Normal;
            }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            switch (e.KeyCode)
            {
                case Keys.F11:
                    if (CanToggleFullScreen == true)
                    {
                        if (IsFullScreen)
                        { IsFullScreen = false; UpdateFullScreen(); }
                        else { IsFullScreen = true; UpdateFullScreen(); }
                    }
                    break;
            }
        }
    }
}
