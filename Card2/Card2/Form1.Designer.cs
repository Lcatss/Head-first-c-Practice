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
            this.deck1ListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deck2ListBox = new System.Windows.Forms.ListBox();
            this.reset1 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.shuffle2 = new System.Windows.Forms.Button();
            this.deck1Label = new System.Windows.Forms.Label();
            this.deck2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deck1ListBox
            // 
            this.deck1ListBox.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deck1ListBox.FormattingEnabled = true;
            this.deck1ListBox.ItemHeight = 23;
            this.deck1ListBox.Location = new System.Drawing.Point(12, 34);
            this.deck1ListBox.Name = "deck1ListBox";
            this.deck1ListBox.Size = new System.Drawing.Size(177, 257);
            this.deck1ListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deck2ListBox
            // 
            this.deck2ListBox.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deck2ListBox.FormattingEnabled = true;
            this.deck2ListBox.ItemHeight = 23;
            this.deck2ListBox.Location = new System.Drawing.Point(287, 34);
            this.deck2ListBox.Name = "deck2ListBox";
            this.deck2ListBox.Size = new System.Drawing.Size(177, 257);
            this.deck2ListBox.TabIndex = 3;
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(12, 315);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(177, 27);
            this.reset1.TabIndex = 4;
            this.reset1.Text = "Reset Deck #1";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // shuffle1
            // 
            this.shuffle1.Location = new System.Drawing.Point(12, 367);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(177, 27);
            this.shuffle1.TabIndex = 5;
            this.shuffle1.Text = "Shuffle Deck #1";
            this.shuffle1.UseVisualStyleBackColor = true;
            this.shuffle1.Click += new System.EventHandler(this.shuffle1_Click);
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(287, 315);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(177, 27);
            this.reset2.TabIndex = 6;
            this.reset2.Text = "Reset Deck #2";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // shuffle2
            // 
            this.shuffle2.Location = new System.Drawing.Point(287, 367);
            this.shuffle2.Name = "shuffle2";
            this.shuffle2.Size = new System.Drawing.Size(174, 27);
            this.shuffle2.TabIndex = 7;
            this.shuffle2.Text = "Shuffle Deck #2";
            this.shuffle2.UseVisualStyleBackColor = true;
            this.shuffle2.Click += new System.EventHandler(this.shuffle2_Click);
            // 
            // deck1Label
            // 
            this.deck1Label.AutoSize = true;
            this.deck1Label.Location = new System.Drawing.Point(9, 13);
            this.deck1Label.Name = "deck1Label";
            this.deck1Label.Size = new System.Drawing.Size(0, 15);
            this.deck1Label.TabIndex = 8;
            // 
            // deck2Label
            // 
            this.deck2Label.AutoSize = true;
            this.deck2Label.Location = new System.Drawing.Point(284, 13);
            this.deck2Label.Name = "deck2Label";
            this.deck2Label.Size = new System.Drawing.Size(0, 15);
            this.deck2Label.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 441);
            this.Controls.Add(this.deck2Label);
            this.Controls.Add(this.deck1Label);
            this.Controls.Add(this.shuffle2);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.reset1);
            this.Controls.Add(this.deck2ListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deck1ListBox);
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deck1ListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox deck2ListBox;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button shuffle2;
        private System.Windows.Forms.Label deck1Label;
        private System.Windows.Forms.Label deck2Label;

    }
}

