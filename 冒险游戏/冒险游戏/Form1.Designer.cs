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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sword = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.ListBow = new System.Windows.Forms.PictureBox();
            this.ListRedPotion = new System.Windows.Forms.PictureBox();
            this.ListSword = new System.Windows.Forms.PictureBox();
            this.ListBluePotion = new System.Windows.Forms.PictureBox();
            this.ListMace = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.ProgressBar();
            this.ghostHitPoints = new System.Windows.Forms.ProgressBar();
            this.batHitPoints = new System.Windows.Forms.ProgressBar();
            this.playerHitPoints = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListMace)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(86, 179);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(30, 30);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sword.TabIndex = 3;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = ((System.Drawing.Image)(resources.GetObject("ghost.Image")));
            this.ghost.Location = new System.Drawing.Point(392, 88);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(30, 30);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghost.TabIndex = 4;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(332, 179);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(30, 30);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bow.TabIndex = 5;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
            this.bluePotion.Location = new System.Drawing.Point(262, 179);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(30, 30);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bluePotion.TabIndex = 6;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(178, 179);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(30, 30);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bat.TabIndex = 7;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
            this.redPotion.Location = new System.Drawing.Point(332, 95);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(30, 30);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redPotion.TabIndex = 8;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(414, 182);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 9;
            this.player.TabStop = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(245, 95);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(30, 30);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mace.TabIndex = 10;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = ((System.Drawing.Image)(resources.GetObject("ghoul.Image")));
            this.ghoul.Location = new System.Drawing.Point(113, 95);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(30, 30);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ghoul.TabIndex = 11;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // ListBow
            // 
            this.ListBow.BackColor = System.Drawing.Color.Transparent;
            this.ListBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListBow.Image = global::WindowsFormsApplication1.Properties.Resources.bow;
            this.ListBow.Location = new System.Drawing.Point(178, 321);
            this.ListBow.Name = "ListBow";
            this.ListBow.Size = new System.Drawing.Size(50, 50);
            this.ListBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ListBow.TabIndex = 12;
            this.ListBow.TabStop = false;
            this.ListBow.Visible = false;
            this.ListBow.Click += new System.EventHandler(this.ListBow_Click);
            // 
            // ListRedPotion
            // 
            this.ListRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.ListRedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListRedPotion.Image = global::WindowsFormsApplication1.Properties.Resources.potion_red;
            this.ListRedPotion.Location = new System.Drawing.Point(432, 321);
            this.ListRedPotion.Name = "ListRedPotion";
            this.ListRedPotion.Size = new System.Drawing.Size(50, 50);
            this.ListRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ListRedPotion.TabIndex = 13;
            this.ListRedPotion.TabStop = false;
            this.ListRedPotion.Visible = false;
            this.ListRedPotion.Click += new System.EventHandler(this.ListRedPotion_Click);
            // 
            // ListSword
            // 
            this.ListSword.BackColor = System.Drawing.Color.Transparent;
            this.ListSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListSword.Image = global::WindowsFormsApplication1.Properties.Resources.sword;
            this.ListSword.Location = new System.Drawing.Point(86, 321);
            this.ListSword.Name = "ListSword";
            this.ListSword.Size = new System.Drawing.Size(50, 50);
            this.ListSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ListSword.TabIndex = 14;
            this.ListSword.TabStop = false;
            this.ListSword.Visible = false;
            this.ListSword.Click += new System.EventHandler(this.ListSword_Click);
            // 
            // ListBluePotion
            // 
            this.ListBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.ListBluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListBluePotion.Image = global::WindowsFormsApplication1.Properties.Resources.potion_blue;
            this.ListBluePotion.Location = new System.Drawing.Point(342, 321);
            this.ListBluePotion.Name = "ListBluePotion";
            this.ListBluePotion.Size = new System.Drawing.Size(50, 50);
            this.ListBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ListBluePotion.TabIndex = 15;
            this.ListBluePotion.TabStop = false;
            this.ListBluePotion.Visible = false;
            this.ListBluePotion.Click += new System.EventHandler(this.ListBluePotion_Click);
            // 
            // ListMace
            // 
            this.ListMace.BackColor = System.Drawing.Color.Transparent;
            this.ListMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListMace.Image = global::WindowsFormsApplication1.Properties.Resources.mace;
            this.ListMace.Location = new System.Drawing.Point(262, 321);
            this.ListMace.Name = "ListMace";
            this.ListMace.Size = new System.Drawing.Size(50, 50);
            this.ListMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ListMace.TabIndex = 16;
            this.ListMace.TabStop = false;
            this.ListMace.Visible = false;
            this.ListMace.Click += new System.EventHandler(this.ListMace_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bat";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghost";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghoul";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.42012F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.57988F));
            this.tableLayoutPanel.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(618, 118);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(185, 133);
            this.tableLayoutPanel.TabIndex = 17;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ghoulHitPoints.Location = new System.Drawing.Point(80, 111);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(100, 15);
            this.ghoulHitPoints.TabIndex = 10;
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ghostHitPoints.Location = new System.Drawing.Point(80, 80);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(100, 15);
            this.ghostHitPoints.TabIndex = 9;
            // 
            // batHitPoints
            // 
            this.batHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batHitPoints.Location = new System.Drawing.Point(80, 45);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(100, 15);
            this.batHitPoints.TabIndex = 8;
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerHitPoints.Location = new System.Drawing.Point(80, 10);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(100, 15);
            this.playerHitPoints.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(815, 399);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.ListMace);
            this.Controls.Add(this.ListBluePotion);
            this.Controls.Add(this.ListSword);
            this.Controls.Add(this.ListRedPotion);
            this.Controls.Add(this.ListBow);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListMace)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox ListBow;
        private System.Windows.Forms.PictureBox ListRedPotion;
        private System.Windows.Forms.PictureBox ListSword;
        private System.Windows.Forms.PictureBox ListBluePotion;
        private System.Windows.Forms.PictureBox ListMace;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ProgressBar ghoulHitPoints;
        private System.Windows.Forms.ProgressBar ghostHitPoints;
        private System.Windows.Forms.ProgressBar batHitPoints;
        private System.Windows.Forms.ProgressBar playerHitPoints;

    }
}

