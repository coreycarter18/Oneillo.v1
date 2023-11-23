namespace Oneilloassignment
{
    partial class Oneillogame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oneillogame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationPanel = new System.Windows.Forms.GroupBox();
            this.playerCountWhite = new System.Windows.Forms.Label();
            this.playerCountBlack = new System.Windows.Forms.Label();
            this.picturePlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.picturePlayer2 = new System.Windows.Forms.PictureBox();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.InformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(522, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Checked = true;
            this.settingsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationPanelToolStripMenuItem,
            this.speakToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // informationPanelToolStripMenuItem
            // 
            this.informationPanelToolStripMenuItem.Checked = true;
            this.informationPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.informationPanelToolStripMenuItem.Name = "informationPanelToolStripMenuItem";
            this.informationPanelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.informationPanelToolStripMenuItem.Text = "Information Panel";
            // 
            // speakToolStripMenuItem
            // 
            this.speakToolStripMenuItem.Name = "speakToolStripMenuItem";
            this.speakToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.speakToolStripMenuItem.Text = "speak";
            this.speakToolStripMenuItem.Click += new System.EventHandler(this.speakToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // InformationPanel
            // 
            this.InformationPanel.BackColor = System.Drawing.Color.Red;
            this.InformationPanel.Controls.Add(this.picturePlayer2);
            this.InformationPanel.Controls.Add(this.playerCountWhite);
            this.InformationPanel.Controls.Add(this.playerCountBlack);
            this.InformationPanel.Controls.Add(this.picturePlayer1);
            this.InformationPanel.Controls.Add(this.pictureBox2);
            this.InformationPanel.Controls.Add(this.pictureBox1);
            this.InformationPanel.Controls.Add(this.textBoxPlayer2);
            this.InformationPanel.Controls.Add(this.textBoxPlayer1);
            this.InformationPanel.Location = new System.Drawing.Point(12, 562);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(498, 93);
            this.InformationPanel.TabIndex = 1;
            this.InformationPanel.TabStop = false;
            this.InformationPanel.Text = "Information Panel";
            this.InformationPanel.Enter += new System.EventHandler(this.InformationPanel_Enter);
            // 
            // playerCountWhite
            // 
            this.playerCountWhite.AutoSize = true;
            this.playerCountWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCountWhite.Location = new System.Drawing.Point(7, 49);
            this.playerCountWhite.Name = "playerCountWhite";
            this.playerCountWhite.Size = new System.Drawing.Size(44, 29);
            this.playerCountWhite.TabIndex = 7;
            this.playerCountWhite.Text = "X2";
            // 
            // playerCountBlack
            // 
            this.playerCountBlack.AutoSize = true;
            this.playerCountBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCountBlack.Location = new System.Drawing.Point(247, 50);
            this.playerCountBlack.Name = "playerCountBlack";
            this.playerCountBlack.Size = new System.Drawing.Size(44, 29);
            this.playerCountBlack.TabIndex = 6;
            this.playerCountBlack.Text = "X2";
            // 
            // picturePlayer1
            // 
            this.picturePlayer1.Image = global::Oneilloassignment.Properties.Resources.YOUR_TURN2;
            this.picturePlayer1.Location = new System.Drawing.Point(57, 21);
            this.picturePlayer1.Name = "picturePlayer1";
            this.picturePlayer1.Size = new System.Drawing.Size(101, 50);
            this.picturePlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayer1.TabIndex = 4;
            this.picturePlayer1.TabStop = false;
            this.picturePlayer1.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Oneilloassignment.Properties.Resources.black_on_square;
            this.pictureBox2.Location = new System.Drawing.Point(164, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Oneilloassignment.Properties.Resources.white_on_square;
            this.pictureBox1.Location = new System.Drawing.Point(408, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Location = new System.Drawing.Point(302, 65);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayer2.TabIndex = 1;
            this.textBoxPlayer2.Text = "Player#2";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(56, 65);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlayer1.TabIndex = 0;
            this.textBoxPlayer1.Text = "Player#1";
            // 
            // picturePlayer2
            // 
            this.picturePlayer2.Image = global::Oneilloassignment.Properties.Resources.YOUR_TURN2;
            this.picturePlayer2.Location = new System.Drawing.Point(302, 21);
            this.picturePlayer2.Name = "picturePlayer2";
            this.picturePlayer2.Size = new System.Drawing.Size(101, 50);
            this.picturePlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlayer2.TabIndex = 8;
            this.picturePlayer2.TabStop = false;
            this.picturePlayer2.Visible = false;
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            // 
            // Oneillogame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(522, 667);
            this.Controls.Add(this.InformationPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Oneillogame";
            this.Text = "O\'Neillo Game V2";
            this.Load += new System.EventHandler(this.Oneillogame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox InformationPanel;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picturePlayer1;
        private System.Windows.Forms.ToolStripMenuItem informationPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakToolStripMenuItem;
        private System.Windows.Forms.Label playerCountBlack;
        private System.Windows.Forms.Label playerCountWhite;
        private System.Windows.Forms.PictureBox picturePlayer2;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
    }
}

