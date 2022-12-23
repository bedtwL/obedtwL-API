namespace obedtwLAPI.oUI
{
    partial class oVideoViewControl
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
            this.BTN_PauseControl = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_PauseControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_PauseControl
            // 
            this.BTN_PauseControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_PauseControl.Location = new System.Drawing.Point(0, 0);
            this.BTN_PauseControl.Name = "BTN_PauseControl";
            this.BTN_PauseControl.Size = new System.Drawing.Size(64, 64);
            this.BTN_PauseControl.TabIndex = 0;
            this.BTN_PauseControl.TabStop = false;
            this.BTN_PauseControl.Click += new System.EventHandler(this.BTN_PauseControl_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(64, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(452, 64);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // oVideoViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BTN_PauseControl);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "oVideoViewControl";
            this.Size = new System.Drawing.Size(512, 64);
            this.Load += new System.EventHandler(this.oVideoViewControl_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.oVideoViewControl_ControlAdded);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_PauseControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BTN_PauseControl;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}
