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
    public partial class oVideoViewControl : UserControl
    {
        /// <summary>
        /// The VideoView that you want to Control
        /// </summary>
        public oVideoView oVideoViewCore;
        public oVideoViewControl()
        {
            InitializeComponent();
            try 
            {

            } 
            catch { }
        }

        private void oVideoViewControl_Load(object sender, EventArgs e)
        {

        }

        private void BTN_PauseControl_Click(object sender, EventArgs e)
        {
            oVideoViewCore.oVideoViewCore.Pause();
            
        }
        private void UpdateTrackBar()
        {
            trackBar1.Value = (int)oVideoViewCore.oVideoViewCore.Time;
            trackBar1.Value = (int)oVideoViewCore.oVideoViewCore.Length;
        }
        private async void oVideoViewControl_ControlAdded(object sender, ControlEventArgs e)
        {
            try 
            {
                do 
                { 
                    try 
                    {
                        if (oVideoViewCore.oVideoViewCore.State == Vlc.DotNet.Core.Interops.Signatures.MediaStates.Paused)
                        {
                            BTN_PauseControl.BackgroundImage = global::obedtwLAPI.Properties.Resources.obedtwLAPI_oUI_oVideoViewControl_PlayIcon;
                        }
                        else if (oVideoViewCore.oVideoViewCore.State == Vlc.DotNet.Core.Interops.Signatures.MediaStates.Playing)
                        { BTN_PauseControl.BackgroundImage = global::obedtwLAPI.Properties.Resources.obedtwLAPI_oUI_oVideoViewControl_PauseIcon; }
                        else { BTN_PauseControl.BackgroundImage = global::obedtwLAPI.Properties.Resources.obedtwLAPI_oUI_oVideoViewControl_StopIcon; }
                        UpdateTrackBar();
                    }
                    catch
                    {

                    }
                    await Task.Delay(500);
                }
                while (true);
            }
            catch { }
        }
        private void SetTime(int Time)
        {
            try {oVideoViewCore.oVideoViewCore.Time= long.Parse(Time.ToString()); } catch { }
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SetTime(trackBar1.Value);
        }
    }
}
