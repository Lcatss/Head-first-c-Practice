namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.jobComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignButton);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.jobComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(10, 96);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(229, 33);
            this.assignButton.TabIndex = 4;
            this.assignButton.Text = "Assign this job to a bee";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(199, 51);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(72, 25);
            this.shifts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shifts";
            // 
            // jobComboBox
            // 
            this.jobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.Items.AddRange(new object[] {
            "Nectar collector",
            "Egg care",
            "Hive maintenance",
            "Baby bee tutoring",
            "Honey manufacturing",
            "String patrol"});
            this.jobComboBox.Location = new System.Drawing.Point(10, 53);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(168, 23);
            this.jobComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Bee Job";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 121);
            this.button1.TabIndex = 1;
            this.button1.Text = "Work The Next Shift";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(39, 203);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(662, 289);
            this.reportTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 536);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox jobComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.Button assignButton;
    }
}

