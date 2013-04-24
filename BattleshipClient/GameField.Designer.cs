namespace BattleshipClient
{
    partial class GameField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameField));
			this.labelPlayerField = new System.Windows.Forms.Label();
			this.labelEnemy = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.suspendGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.myStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highscoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button2 = new System.Windows.Forms.Button();
			this.gamesControl1 = new BattleshipClient.GamesControl();
			this.boardControl2 = new BattleshipClient.BoardControl();
			this.boardControl1 = new BattleshipClient.BoardControl();
			this.shipControl1 = new BattleshipClient.ShipControl();
			this.chatControl1 = new BattleshipClient.ChatControl();
			this.createControl1 = new BattleshipClient.CreateControl();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelPlayerField
			// 
			this.labelPlayerField.AutoSize = true;
			this.labelPlayerField.Location = new System.Drawing.Point(9, 30);
			this.labelPlayerField.Name = "labelPlayerField";
			this.labelPlayerField.Size = new System.Drawing.Size(64, 13);
			this.labelPlayerField.TabIndex = 4;
			this.labelPlayerField.Text = "Player Field:";
			this.labelPlayerField.Visible = false;
			// 
			// labelEnemy
			// 
			this.labelEnemy.AutoSize = true;
			this.labelEnemy.Location = new System.Drawing.Point(553, 30);
			this.labelEnemy.Name = "labelEnemy";
			this.labelEnemy.Size = new System.Drawing.Size(67, 13);
			this.labelEnemy.TabIndex = 5;
			this.labelEnemy.Text = "Enemy Field:";
			this.labelEnemy.Visible = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.highscoreToolStripMenuItem,
            this.suspendGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.newGameToolStripMenuItem.Text = "Select Player";
			// 
			// highscoreToolStripMenuItem
			// 
			this.highscoreToolStripMenuItem.Name = "highscoreToolStripMenuItem";
			this.highscoreToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.highscoreToolStripMenuItem.Text = "Highscore";
			// 
			// suspendGameToolStripMenuItem
			// 
			this.suspendGameToolStripMenuItem.Name = "suspendGameToolStripMenuItem";
			this.suspendGameToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.suspendGameToolStripMenuItem.Text = "Suspend game";
			this.suspendGameToolStripMenuItem.Click += new System.EventHandler(this.suspendGameToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// statisticsToolStripMenuItem
			// 
			this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myStatisticsToolStripMenuItem,
            this.highscoreToolStripMenuItem1});
			this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
			this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.statisticsToolStripMenuItem.Text = "Statistics";
			// 
			// myStatisticsToolStripMenuItem
			// 
			this.myStatisticsToolStripMenuItem.Name = "myStatisticsToolStripMenuItem";
			this.myStatisticsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.myStatisticsToolStripMenuItem.Text = "Player1 statistics";
			// 
			// highscoreToolStripMenuItem1
			// 
			this.highscoreToolStripMenuItem1.Name = "highscoreToolStripMenuItem1";
			this.highscoreToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
			this.highscoreToolStripMenuItem1.Text = "Player2 statistics";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Checked = true;
			this.aboutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// rulesToolStripMenuItem
			// 
			this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
			this.rulesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.rulesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.rulesToolStripMenuItem.Text = "Rules";
			// 
			// aboutUsToolStripMenuItem
			// 
			this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
			this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.aboutUsToolStripMenuItem.Text = "About us";
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(740, 624);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "Start";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// gamesControl1
			// 
			this.gamesControl1.Location = new System.Drawing.Point(512, 58);
			this.gamesControl1.Name = "gamesControl1";
			this.gamesControl1.Size = new System.Drawing.Size(256, 174);
			this.gamesControl1.TabIndex = 31;
			// 
			// boardControl2
			// 
			this.boardControl2.Location = new System.Drawing.Point(10, 48);
			this.boardControl2.Name = "boardControl2";
			this.boardControl2.Size = new System.Drawing.Size(430, 430);
			this.boardControl2.TabIndex = 30;
			this.boardControl2.Visible = false;
			this.boardControl2.X = 0;
			this.boardControl2.Y = 0;
			// 
			// boardControl1
			// 
			this.boardControl1.Location = new System.Drawing.Point(556, 48);
			this.boardControl1.Name = "boardControl1";
			this.boardControl1.Size = new System.Drawing.Size(430, 430);
			this.boardControl1.TabIndex = 29;
			this.boardControl1.Visible = false;
			this.boardControl1.X = 0;
			this.boardControl1.Y = 0;
			// 
			// shipControl1
			// 
			this.shipControl1.Location = new System.Drawing.Point(531, 484);
			this.shipControl1.Name = "shipControl1";
			this.shipControl1.Size = new System.Drawing.Size(477, 134);
			this.shipControl1.TabIndex = 28;
			this.shipControl1.Visible = false;
			// 
			// chatControl1
			// 
			this.chatControl1.Location = new System.Drawing.Point(0, 484);
			this.chatControl1.Name = "chatControl1";
			this.chatControl1.Size = new System.Drawing.Size(514, 249);
			this.chatControl1.TabIndex = 27;
			this.chatControl1.Visible = false;
			// 
			// createControl1
			// 
			this.createControl1.Location = new System.Drawing.Point(10, 58);
			this.createControl1.Name = "createControl1";
			this.createControl1.Size = new System.Drawing.Size(177, 161);
			this.createControl1.TabIndex = 26;
			this.createControl1.Bezar += new BattleshipClient.BezarHandler(this.createControl1_Bezar);
			// 
			// GameField
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.gamesControl1);
			this.Controls.Add(this.boardControl2);
			this.Controls.Add(this.boardControl1);
			this.Controls.Add(this.shipControl1);
			this.Controls.Add(this.chatControl1);
			this.Controls.Add(this.createControl1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.labelPlayerField);
			this.Controls.Add(this.labelEnemy);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "GameField";
			this.Text = "GameField";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameField_FormClosing);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameField_MouseClick);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameField_MouseMove);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label labelPlayerField;
		private System.Windows.Forms.Label labelEnemy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
		private System.Windows.Forms.Button button2;
		private CreateControl createControl1;
		private ChatControl chatControl1;
		private ShipControl shipControl1;
		private BoardControl boardControl1;
		private BoardControl boardControl2;
        private System.Windows.Forms.ToolStripMenuItem suspendGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private GamesControl gamesControl1;
    }
}