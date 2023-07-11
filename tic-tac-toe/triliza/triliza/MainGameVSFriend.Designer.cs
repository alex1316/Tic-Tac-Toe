namespace triliza
{
    partial class MainGameVSFriend
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameVSFriend));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.WhoPlaysLabel = new System.Windows.Forms.Label();
            this.Player2NameLabel = new System.Windows.Forms.Label();
            this.Player1NameLabel = new System.Windows.Forms.Label();
            this.NowPlayingLabel = new System.Windows.Forms.Label();
            this.Player2ShowLabel = new System.Windows.Forms.Label();
            this.Player1ShowLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.BackButton);
            this.TopPanel.Controls.Add(this.WhoPlaysLabel);
            this.TopPanel.Controls.Add(this.Player2NameLabel);
            this.TopPanel.Controls.Add(this.Player1NameLabel);
            this.TopPanel.Controls.Add(this.NowPlayingLabel);
            this.TopPanel.Controls.Add(this.Player2ShowLabel);
            this.TopPanel.Controls.Add(this.Player1ShowLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(570, 70);
            this.TopPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Image = global::triliza.Properties.Resources.BackButton1;
            this.BackButton.Location = new System.Drawing.Point(5, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(36, 35);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackButton.TabIndex = 6;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WhoPlaysLabel
            // 
            this.WhoPlaysLabel.AutoSize = true;
            this.WhoPlaysLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoPlaysLabel.Location = new System.Drawing.Point(133, 47);
            this.WhoPlaysLabel.Name = "WhoPlaysLabel";
            this.WhoPlaysLabel.Size = new System.Drawing.Size(0, 23);
            this.WhoPlaysLabel.TabIndex = 5;
            // 
            // Player2NameLabel
            // 
            this.Player2NameLabel.AutoSize = true;
            this.Player2NameLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2NameLabel.Location = new System.Drawing.Point(166, 25);
            this.Player2NameLabel.Name = "Player2NameLabel";
            this.Player2NameLabel.Size = new System.Drawing.Size(0, 23);
            this.Player2NameLabel.TabIndex = 4;
            // 
            // Player1NameLabel
            // 
            this.Player1NameLabel.AutoSize = true;
            this.Player1NameLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1NameLabel.Location = new System.Drawing.Point(166, 2);
            this.Player1NameLabel.Name = "Player1NameLabel";
            this.Player1NameLabel.Size = new System.Drawing.Size(0, 23);
            this.Player1NameLabel.TabIndex = 3;
            // 
            // NowPlayingLabel
            // 
            this.NowPlayingLabel.AutoSize = true;
            this.NowPlayingLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingLabel.Location = new System.Drawing.Point(3, 47);
            this.NowPlayingLabel.Name = "NowPlayingLabel";
            this.NowPlayingLabel.Size = new System.Drawing.Size(124, 23);
            this.NowPlayingLabel.TabIndex = 2;
            this.NowPlayingLabel.Text = "Now Playing:";
            // 
            // Player2ShowLabel
            // 
            this.Player2ShowLabel.AutoSize = true;
            this.Player2ShowLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2ShowLabel.Location = new System.Drawing.Point(46, 25);
            this.Player2ShowLabel.Name = "Player2ShowLabel";
            this.Player2ShowLabel.Size = new System.Drawing.Size(114, 23);
            this.Player2ShowLabel.TabIndex = 1;
            this.Player2ShowLabel.Text = "Player 2 | O:";
            // 
            // Player1ShowLabel
            // 
            this.Player1ShowLabel.AutoSize = true;
            this.Player1ShowLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1ShowLabel.Location = new System.Drawing.Point(47, 2);
            this.Player1ShowLabel.Name = "Player1ShowLabel";
            this.Player1ShowLabel.Size = new System.Drawing.Size(113, 23);
            this.Player1ShowLabel.TabIndex = 0;
            this.Player1ShowLabel.Text = "Player 1 | X:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainGameVSFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::triliza.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 549);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGameVSFriend";
            this.Text = "Tic Tac Toe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGameVSFriend_FormClosing);
            this.Load += new System.EventHandler(this.MainGameVSFriend_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Player1ShowLabel;
        private System.Windows.Forms.Label NowPlayingLabel;
        private System.Windows.Forms.Label Player2ShowLabel;
        private System.Windows.Forms.Label Player2NameLabel;
        private System.Windows.Forms.Label Player1NameLabel;
        private System.Windows.Forms.Label WhoPlaysLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox BackButton;
    }
}