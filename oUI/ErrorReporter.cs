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
    public partial class ErrorReporter : Form
    {
        Action action;
        int TaskCode=0;
        public ErrorReporter(string Error,string Title,int taskCode)
        {

            if (!Plugins.oPlugin.GetPluginExist(new Plugins.Plugin("oUI.oplugin")))
            {
                try { this.Close(); } catch { }
             
            }
            InitializeComponent();
            richTextBox1.Text = Error;
            label1.Text = Title;
            TaskCode = taskCode;
            button1.Visible = false;
        }
        public ErrorReporter(string Error, string Title,Action Erroraction, int taskCode)
        {
            InitializeComponent();
            richTextBox1.Text = Error;
            label1.Text = Title;
            TaskCode = taskCode;
            action = Erroraction;
            button1.Visible = true;
        }
       

        private void ErrorReporter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oTasks.DoAction(action, TaskCode);
            this.Close();
            

        }
    }
}
