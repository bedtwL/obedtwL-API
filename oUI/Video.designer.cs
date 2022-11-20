namespace obedtwLAPI.oUI
{
    partial class Video
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(6, 6);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(518, 256);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.guna2Button1_Click);
            this.PictureBox1.MouseEnter += new System.EventHandler(this.Video_MouseEnter);
            this.PictureBox1.MouseLeave += new System.EventHandler(this.Video_MouseLeave);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(535, 6);
            this.Label1.Margin = new System.Windows.Forms.Padding(6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(600, 222);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "VideoName";
            this.Label1.Click += new System.EventHandler(this.guna2Button1_Click);
            this.Label1.MouseEnter += new System.EventHandler(this.Video_MouseEnter);
            this.Label1.MouseLeave += new System.EventHandler(this.Video_MouseLeave);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox2.Location = new System.Drawing.Point(1075, 196);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(64, 64);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 2;
            this.PictureBox2.TabStop = false;
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.PictureBox2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Video";
            this.Size = new System.Drawing.Size(1150, 256);
            this.Load += new System.EventHandler(this.Video_Load);
            this.Click += new System.EventHandler(this.guna2Button1_Click);
            this.MouseEnter += new System.EventHandler(this.Video_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Video_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox PictureBox2;
    }
}
