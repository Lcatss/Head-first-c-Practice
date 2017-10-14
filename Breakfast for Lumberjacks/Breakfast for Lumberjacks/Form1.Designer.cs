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
            this.label1 = new System.Windows.Forms.Label();
            this.LumberjackName = new System.Windows.Forms.TextBox();
            this.AddLumberjack = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.AddFlapjacks = new System.Windows.Forms.Button();
            this.nextInLine = new System.Windows.Forms.TextBox();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // LumberjackName
            // 
            this.LumberjackName.Location = new System.Drawing.Point(203, 43);
            this.LumberjackName.Name = "LumberjackName";
            this.LumberjackName.Size = new System.Drawing.Size(146, 25);
            this.LumberjackName.TabIndex = 1;
            // 
            // AddLumberjack
            // 
            this.AddLumberjack.Location = new System.Drawing.Point(33, 83);
            this.AddLumberjack.Name = "AddLumberjack";
            this.AddLumberjack.Size = new System.Drawing.Size(316, 23);
            this.AddLumberjack.TabIndex = 2;
            this.AddLumberjack.Text = "Add lumberjack";
            this.AddLumberjack.UseVisualStyleBackColor = true;
            this.AddLumberjack.Click += new System.EventHandler(this.AddLumberjack_Click);
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.ItemHeight = 15;
            this.line.Location = new System.Drawing.Point(33, 153);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(148, 364);
            this.line.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Breakfast Line";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.AddFlapjacks);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Location = new System.Drawing.Point(228, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 394);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(18, 30);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(120, 25);
            this.howMany.TabIndex = 0;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(18, 76);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(76, 19);
            this.crispy.TabIndex = 1;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(18, 114);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(68, 19);
            this.soggy.TabIndex = 2;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(18, 151);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(84, 19);
            this.browned.TabIndex = 3;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(18, 187);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(76, 19);
            this.banana.TabIndex = 4;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // AddFlapjacks
            // 
            this.AddFlapjacks.Location = new System.Drawing.Point(6, 222);
            this.AddFlapjacks.Name = "AddFlapjacks";
            this.AddFlapjacks.Size = new System.Drawing.Size(160, 23);
            this.AddFlapjacks.TabIndex = 5;
            this.AddFlapjacks.Text = "Add flapjacks";
            this.AddFlapjacks.UseVisualStyleBackColor = true;
            this.AddFlapjacks.Click += new System.EventHandler(this.AddFlapjacks_Click);
            // 
            // nextInLine
            // 
            this.nextInLine.Location = new System.Drawing.Point(6, 260);
            this.nextInLine.Multiline = true;
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(160, 56);
            this.nextInLine.TabIndex = 6;
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(6, 353);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(160, 23);
            this.nextLumberjack.TabIndex = 7;
            this.nextLumberjack.Text = "Next lumberjack";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.line);
            this.Controls.Add(this.AddLumberjack);
            this.Controls.Add(this.LumberjackName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Breakfast for Lumberjacks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LumberjackName;
        private System.Windows.Forms.Button AddLumberjack;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.TextBox nextInLine;
        private System.Windows.Forms.Button AddFlapjacks;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.NumericUpDown howMany;
    }
}

