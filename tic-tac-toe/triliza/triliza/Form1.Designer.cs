namespace triliza
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.SetNamePlayer1Label = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.SetNamePlayer2Label = new System.Windows.Forms.Label();
            this.PlayAgaistLabel = new System.Windows.Forms.Label();
            this.PCSelect = new System.Windows.Forms.RadioButton();
            this.FriendSelect = new System.Windows.Forms.RadioButton();
            this.DimensionsLabel = new System.Windows.Forms.Label();
            this.DimensionText = new System.Windows.Forms.TextBox();
            this.MultipleLabel = new System.Windows.Forms.Label();
            this.DimensionMirror = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.QuitButton = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.εναντίονΥπολογιστήToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εναντίονΦίλουToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εναντίονΥπολογιστήToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetNamePlayer1Label
            // 
            this.SetNamePlayer1Label.AutoSize = true;
            this.SetNamePlayer1Label.BackColor = System.Drawing.Color.Transparent;
            this.SetNamePlayer1Label.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetNamePlayer1Label.ForeColor = System.Drawing.Color.White;
            this.SetNamePlayer1Label.Location = new System.Drawing.Point(12, 95);
            this.SetNamePlayer1Label.Name = "SetNamePlayer1Label";
            this.SetNamePlayer1Label.Size = new System.Drawing.Size(374, 50);
            this.SetNamePlayer1Label.TabIndex = 0;
            this.SetNamePlayer1Label.Text = "Όνομα 1ου παίκτη:";
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(231, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(167, 50);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "Τρίλιζα!";
            // 
            // Player1Name
            // 
            this.Player1Name.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.Location = new System.Drawing.Point(401, 108);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(159, 37);
            this.Player1Name.TabIndex = 2;
            // 
            // Player2Name
            // 
            this.Player2Name.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Name.Location = new System.Drawing.Point(401, 243);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(159, 37);
            this.Player2Name.TabIndex = 4;
            this.Player2Name.Visible = false;
            // 
            // SetNamePlayer2Label
            // 
            this.SetNamePlayer2Label.AutoSize = true;
            this.SetNamePlayer2Label.BackColor = System.Drawing.Color.Transparent;
            this.SetNamePlayer2Label.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetNamePlayer2Label.ForeColor = System.Drawing.Color.White;
            this.SetNamePlayer2Label.Location = new System.Drawing.Point(12, 230);
            this.SetNamePlayer2Label.Name = "SetNamePlayer2Label";
            this.SetNamePlayer2Label.Size = new System.Drawing.Size(374, 50);
            this.SetNamePlayer2Label.TabIndex = 3;
            this.SetNamePlayer2Label.Text = "Όνομα 2ου παίκτη:";
            this.SetNamePlayer2Label.Visible = false;
            // 
            // PlayAgaistLabel
            // 
            this.PlayAgaistLabel.AutoSize = true;
            this.PlayAgaistLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayAgaistLabel.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgaistLabel.ForeColor = System.Drawing.Color.White;
            this.PlayAgaistLabel.Location = new System.Drawing.Point(11, 164);
            this.PlayAgaistLabel.Name = "PlayAgaistLabel";
            this.PlayAgaistLabel.Size = new System.Drawing.Size(305, 50);
            this.PlayAgaistLabel.TabIndex = 5;
            this.PlayAgaistLabel.Text = "Παίξε εναντίον:";
            // 
            // PCSelect
            // 
            this.PCSelect.AutoSize = true;
            this.PCSelect.BackColor = System.Drawing.Color.Transparent;
            this.PCSelect.Checked = true;
            this.PCSelect.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCSelect.ForeColor = System.Drawing.Color.White;
            this.PCSelect.Location = new System.Drawing.Point(322, 178);
            this.PCSelect.Name = "PCSelect";
            this.PCSelect.Size = new System.Drawing.Size(163, 34);
            this.PCSelect.TabIndex = 6;
            this.PCSelect.TabStop = true;
            this.PCSelect.Text = "Υπολογιστή";
            this.PCSelect.UseVisualStyleBackColor = false;
            this.PCSelect.CheckedChanged += new System.EventHandler(this.PCSelect_CheckedChanged);
            // 
            // FriendSelect
            // 
            this.FriendSelect.AutoSize = true;
            this.FriendSelect.BackColor = System.Drawing.Color.Transparent;
            this.FriendSelect.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendSelect.ForeColor = System.Drawing.Color.White;
            this.FriendSelect.Location = new System.Drawing.Point(491, 178);
            this.FriendSelect.Name = "FriendSelect";
            this.FriendSelect.Size = new System.Drawing.Size(98, 34);
            this.FriendSelect.TabIndex = 7;
            this.FriendSelect.TabStop = true;
            this.FriendSelect.Text = "Φίλου";
            this.FriendSelect.UseVisualStyleBackColor = false;
            this.FriendSelect.CheckedChanged += new System.EventHandler(this.FriendSelect_CheckedChanged);
            // 
            // DimensionsLabel
            // 
            this.DimensionsLabel.AutoSize = true;
            this.DimensionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DimensionsLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DimensionsLabel.ForeColor = System.Drawing.Color.White;
            this.DimensionsLabel.Location = new System.Drawing.Point(12, 301);
            this.DimensionsLabel.Name = "DimensionsLabel";
            this.DimensionsLabel.Size = new System.Drawing.Size(425, 38);
            this.DimensionsLabel.TabIndex = 10;
            this.DimensionsLabel.Text = "Δώσε διαστάσεις παιχνιδού:";
            // 
            // DimensionText
            // 
            this.DimensionText.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DimensionText.Location = new System.Drawing.Point(430, 302);
            this.DimensionText.Name = "DimensionText";
            this.DimensionText.Size = new System.Drawing.Size(33, 37);
            this.DimensionText.TabIndex = 11;
            this.DimensionText.TextChanged += new System.EventHandler(this.DimensionText_TextChanged);
            // 
            // MultipleLabel
            // 
            this.MultipleLabel.AutoSize = true;
            this.MultipleLabel.BackColor = System.Drawing.Color.Transparent;
            this.MultipleLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleLabel.ForeColor = System.Drawing.Color.White;
            this.MultipleLabel.Location = new System.Drawing.Point(469, 300);
            this.MultipleLabel.Name = "MultipleLabel";
            this.MultipleLabel.Size = new System.Drawing.Size(38, 38);
            this.MultipleLabel.TabIndex = 12;
            this.MultipleLabel.Text = "X";
            // 
            // DimensionMirror
            // 
            this.DimensionMirror.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DimensionMirror.Enabled = false;
            this.DimensionMirror.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DimensionMirror.Location = new System.Drawing.Point(513, 301);
            this.DimensionMirror.Name = "DimensionMirror";
            this.DimensionMirror.ReadOnly = true;
            this.DimensionMirror.Size = new System.Drawing.Size(33, 37);
            this.DimensionMirror.TabIndex = 13;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Image = global::triliza.Properties.Resources.play_game;
            this.PlayButton.Location = new System.Drawing.Point(188, 357);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(275, 122);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayButton.TabIndex = 14;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Image = global::triliza.Properties.Resources.QuitButton;
            this.QuitButton.Location = new System.Drawing.Point(459, -4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(203, 93);
            this.QuitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuitButton.TabIndex = 15;
            this.QuitButton.TabStop = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.εναντίονΥπολογιστήToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // εναντίονΥπολογιστήToolStripMenuItem
            // 
            this.εναντίονΥπολογιστήToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.εναντίονΥπολογιστήToolStripMenuItem1,
            this.εναντίονΦίλουToolStripMenuItem});
            this.εναντίονΥπολογιστήToolStripMenuItem.Name = "εναντίονΥπολογιστήToolStripMenuItem";
            this.εναντίονΥπολογιστήToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.εναντίονΥπολογιστήToolStripMenuItem.Text = "Παίξε Εναντίον:";
            // 
            // εναντίονΦίλουToolStripMenuItem
            // 
            this.εναντίονΦίλουToolStripMenuItem.Name = "εναντίονΦίλουToolStripMenuItem";
            this.εναντίονΦίλουToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.εναντίονΦίλουToolStripMenuItem.Text = "Εναντίον Φίλου";
            this.εναντίονΦίλουToolStripMenuItem.Click += new System.EventHandler(this.εναντίονΦίλουToolStripMenuItem_Click);
            // 
            // εναντίονΥπολογιστήToolStripMenuItem1
            // 
            this.εναντίονΥπολογιστήToolStripMenuItem1.Name = "εναντίονΥπολογιστήToolStripMenuItem1";
            this.εναντίονΥπολογιστήToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.εναντίονΥπολογιστήToolStripMenuItem1.Text = "Εναντίον Υπολογιστή";
            this.εναντίονΥπολογιστήToolStripMenuItem1.Click += new System.EventHandler(this.εναντίονΥπολογιστήToolStripMenuItem1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::triliza.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.DimensionMirror);
            this.Controls.Add(this.MultipleLabel);
            this.Controls.Add(this.DimensionText);
            this.Controls.Add(this.DimensionsLabel);
            this.Controls.Add(this.FriendSelect);
            this.Controls.Add(this.PCSelect);
            this.Controls.Add(this.PlayAgaistLabel);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.SetNamePlayer2Label);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.SetNamePlayer1Label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Tic Tac Toe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SetNamePlayer1Label;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.Label SetNamePlayer2Label;
        private System.Windows.Forms.Label PlayAgaistLabel;
        private System.Windows.Forms.RadioButton PCSelect;
        private System.Windows.Forms.RadioButton FriendSelect;
        private System.Windows.Forms.Label DimensionsLabel;
        private System.Windows.Forms.TextBox DimensionText;
        private System.Windows.Forms.Label MultipleLabel;
        private System.Windows.Forms.TextBox DimensionMirror;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.PictureBox QuitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem εναντίονΥπολογιστήToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εναντίονΦίλουToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εναντίονΥπολογιστήToolStripMenuItem1;
    }
}

