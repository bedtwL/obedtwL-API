namespace obedtwLAPI.oUI
{
    partial class oVideoView
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.oVideoViewCore = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.oVideoViewCore)).BeginInit();
            this.SuspendLayout();
            // 
            // oVideoViewCore
            // 
            this.oVideoViewCore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oVideoViewCore.BackColor = System.Drawing.Color.Black;
            this.oVideoViewCore.Location = new System.Drawing.Point(0, 0);
            this.oVideoViewCore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.oVideoViewCore.Name = "oVideoViewCore";
            this.oVideoViewCore.Size = new System.Drawing.Size(325, 300);
            this.oVideoViewCore.Spu = -1;
            this.oVideoViewCore.TabIndex = 0;
            this.oVideoViewCore.Text = "vlcControl1";
            this.oVideoViewCore.VlcLibDirectory = vlclib;
            this.oVideoViewCore.VlcMediaplayerOptions = null;
            this.oVideoViewCore.MediaChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerMediaChangedEventArgs>(this.oVideoViewCore_MediaChanged);
            this.oVideoViewCore.TimeChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerTimeChangedEventArgs>(this.oVideoViewCore_TimeChanged);
            this.oVideoViewCore.Click += new System.EventHandler(this.oVideoViewCore_Click);
            // 
            // oVideoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oVideoViewCore);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "oVideoView";
            this.Size = new System.Drawing.Size(325, 300);
            this.Load += new System.EventHandler(this.oVideoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oVideoViewCore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Vlc.DotNet.Forms.VlcControl oVideoViewCore;
    }
}
