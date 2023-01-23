using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obedtwLAPI.oUI
{
    internal class BetterLabbel:TextBox
    {
        public BetterLabbel() 
        {
            this.BorderStyle= BorderStyle.None;
            this.Capture = false;
            this.ReadOnly = true;
            
        }
    }
}
