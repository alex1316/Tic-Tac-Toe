namespace triliza
{
    partial class Draw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Draw));
            this.QuitButton = new System.Windows.Forms.PictureBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.PictureBox();
            this.PlayAgainButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayAgainButton)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Image = global::triliza.Properties.Resources.QuitButton;
            this.QuitButton.Location = new System.Drawing.Point(465, -5);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(199, 112);
            this.QuitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuitButton.TabIndex = 19;
            this.QuitButton.TabStop = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(205, 18);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(167, 50);
            this.MainLabel.TabIndex = 18;
            this.MainLabel.Text = "Τρίλιζα!";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuButton.Image = global::triliza.Properties.Resources.MainMenuButton;
            this.MainMenuButton.Location = new System.Drawing.Point(328, 350);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(283, 129);
            this.MainMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainMenuButton.TabIndex = 21;
            this.MainMenuButton.TabStop = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgainButton.Image = global::triliza.Properties.Resources.PlayAgainButton;
            this.PlayAgainButton.Location = new System.Drawing.Point(39, 350);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(283, 129);
            this.PlayAgainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayAgainButton.TabIndex = 20;
            this.PlayAgainButton.TabStop = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Το παιχνίδι έληξε ισοπαλία!";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.Snow;
            this.TimeLabel.Location = new System.Drawing.Point(12, 264);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(235, 30);
            this.TimeLabel.TabIndex = 23;
            this.TimeLabel.Text = "Χρόνος παιχνιδιού: ";
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::triliza.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Draw";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayAgainButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QuitButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.PictureBox MainMenuButton;
        private System.Windows.Forms.PictureBox PlayAgainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
    }
}