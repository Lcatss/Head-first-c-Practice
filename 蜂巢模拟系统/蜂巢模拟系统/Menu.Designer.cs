namespace WindowsFormsApplication1
{
    partial class Menu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.maxBeeNumber = new System.Windows.Forms.Label();
            this.MaxBeeNumberBar = new System.Windows.Forms.TrackBar();
            this.InitialBeeNumber = new System.Windows.Forms.Label();
            this.InitialBeeNumberBar = new System.Windows.Forms.TrackBar();
            this.Fps = new System.Windows.Forms.Label();
            this.FpsBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBeeNumberBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialBeeNumberBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FpsBar)).BeginInit();
            this.SuspendLayout();
            // 
            // maxBeeNumber
            // 
            this.maxBeeNumber.AutoSize = true;
            this.maxBeeNumber.Location = new System.Drawing.Point(12, 86);
            this.maxBeeNumber.Name = "maxBeeNumber";
            this.maxBeeNumber.Size = new System.Drawing.Size(143, 15);
            this.maxBeeNumber.TabIndex = 0;
            this.maxBeeNumber.Text = "Max Bee Number:30";
            // 
            // MaxBeeNumberBar
            // 
            this.MaxBeeNumberBar.Location = new System.Drawing.Point(212, 86);
            this.MaxBeeNumberBar.Maximum = 100;
            this.MaxBeeNumberBar.Minimum = 1;
            this.MaxBeeNumberBar.Name = "MaxBeeNumberBar";
            this.MaxBeeNumberBar.Size = new System.Drawing.Size(104, 56);
            this.MaxBeeNumberBar.TabIndex = 1;
            this.MaxBeeNumberBar.TickFrequency = 10;
            this.MaxBeeNumberBar.Value = 30;
            this.MaxBeeNumberBar.Scroll += new System.EventHandler(this.MaxBeeNumberBar_Scroll);
            // 
            // InitialBeeNumber
            // 
            this.InitialBeeNumber.AutoSize = true;
            this.InitialBeeNumber.Location = new System.Drawing.Point(12, 41);
            this.InitialBeeNumber.Name = "InitialBeeNumber";
            this.InitialBeeNumber.Size = new System.Drawing.Size(167, 15);
            this.InitialBeeNumber.TabIndex = 2;
            this.InitialBeeNumber.Text = "Initial Bee Number:6";
            // 
            // InitialBeeNumberBar
            // 
            this.InitialBeeNumberBar.Location = new System.Drawing.Point(212, 24);
            this.InitialBeeNumberBar.Maximum = 50;
            this.InitialBeeNumberBar.Minimum = 1;
            this.InitialBeeNumberBar.Name = "InitialBeeNumberBar";
            this.InitialBeeNumberBar.Size = new System.Drawing.Size(104, 56);
            this.InitialBeeNumberBar.TabIndex = 3;
            this.InitialBeeNumberBar.TickFrequency = 5;
            this.InitialBeeNumberBar.Value = 6;
            this.InitialBeeNumberBar.Scroll += new System.EventHandler(this.InitialBeeNumberBar_Scroll);
            // 
            // Fps
            // 
            this.Fps.AutoSize = true;
            this.Fps.Location = new System.Drawing.Point(13, 137);
            this.Fps.Name = "Fps";
            this.Fps.Size = new System.Drawing.Size(55, 15);
            this.Fps.TabIndex = 4;
            this.Fps.Text = "FPS:20";
            // 
            // FpsBar
            // 
            this.FpsBar.Location = new System.Drawing.Point(212, 137);
            this.FpsBar.Maximum = 100;
            this.FpsBar.Minimum = 1;
            this.FpsBar.Name = "FpsBar";
            this.FpsBar.Size = new System.Drawing.Size(104, 56);
            this.FpsBar.TabIndex = 5;
            this.FpsBar.TickFrequency = 10;
            this.FpsBar.Value = 20;
            this.FpsBar.Scroll += new System.EventHandler(this.FpsBar_Scroll);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(328, 377);
            this.ControlBox = false;
            this.Controls.Add(this.FpsBar);
            this.Controls.Add(this.Fps);
            this.Controls.Add(this.InitialBeeNumberBar);
            this.Controls.Add(this.InitialBeeNumber);
            this.Controls.Add(this.MaxBeeNumberBar);
            this.Controls.Add(this.maxBeeNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.MaxBeeNumberBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialBeeNumberBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FpsBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maxBeeNumber;
        private System.Windows.Forms.TrackBar MaxBeeNumberBar;
        private System.Windows.Forms.Label InitialBeeNumber;
        private System.Windows.Forms.TrackBar InitialBeeNumberBar;
        private System.Windows.Forms.Label Fps;
        private System.Windows.Forms.TrackBar FpsBar;
    }
}