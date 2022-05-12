namespace Colour_Guessing_Game
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.ColourEntry = new System.Windows.Forms.TextBox();
            this.ColourOutput = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.HighscoreLabel = new System.Windows.Forms.Label();
            this.timerOutput = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "Restart ";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title.Location = new System.Drawing.Point(12, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(473, 50);
            this.title.TabIndex = 1;
            this.title.Text = "Guess the Colour";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Desc
            // 
            this.Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Desc.Location = new System.Drawing.Point(12, 91);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(473, 37);
            this.Desc.TabIndex = 2;
            this.Desc.Text = "Type the colour of the text into the box below.";
            this.Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColourEntry
            // 
            this.ColourEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ColourEntry.Location = new System.Drawing.Point(12, 315);
            this.ColourEntry.Name = "ColourEntry";
            this.ColourEntry.Size = new System.Drawing.Size(473, 32);
            this.ColourEntry.TabIndex = 3;
            this.ColourEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColourEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ColourEntry_KeyDown);
            // 
            // ColourOutput
            // 
            this.ColourOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ColourOutput.Location = new System.Drawing.Point(12, 247);
            this.ColourOutput.Name = "ColourOutput";
            this.ColourOutput.Size = new System.Drawing.Size(473, 38);
            this.ColourOutput.TabIndex = 4;
            this.ColourOutput.Text = "Type something into the box below to start.";
            this.ColourOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ScoreLabel.Location = new System.Drawing.Point(13, 181);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(473, 51);
            this.ScoreLabel.TabIndex = 5;
            this.ScoreLabel.Text = "Score: 0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighscoreLabel
            // 
            this.HighscoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HighscoreLabel.Location = new System.Drawing.Point(12, 133);
            this.HighscoreLabel.Name = "HighscoreLabel";
            this.HighscoreLabel.Size = new System.Drawing.Size(473, 44);
            this.HighscoreLabel.TabIndex = 6;
            this.HighscoreLabel.Text = "Highscore: 0";
            this.HighscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerOutput
            // 
            this.timerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.timerOutput.Location = new System.Drawing.Point(12, 379);
            this.timerOutput.Name = "timerOutput";
            this.timerOutput.Size = new System.Drawing.Size(473, 34);
            this.timerOutput.TabIndex = 7;
            this.timerOutput.Text = "Time Left: 0";
            this.timerOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(497, 433);
            this.Controls.Add(this.timerOutput);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.HighscoreLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ColourOutput);
            this.Controls.Add(this.ColourEntry);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.Text = "Guess the Colour";
            this.Load += new System.EventHandler(this.App_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.TextBox ColourEntry;
        private System.Windows.Forms.Label ColourOutput;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label HighscoreLabel;
        private System.Windows.Forms.Label timerOutput;
    }
}

