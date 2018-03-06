namespace Mine_Sweeper
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.GamePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ShowBombCount = new System.Windows.Forms.Label();
            this.TimeShow = new System.Windows.Forms.Label();
            this.PlayTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.PausePanel = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.GamePanel.SuspendLayout();
            this.PausePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePanel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.GamePanel.Controls.Add(this.button1);
            this.GamePanel.Controls.Add(this.PauseButton);
            this.GamePanel.Controls.Add(this.ShowBombCount);
            this.GamePanel.Controls.Add(this.TimeShow);
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(400, 60);
            this.GamePanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Mine_Sweeper.Properties.Resources.Flag;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(208, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseButton.Location = new System.Drawing.Point(357, 14);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(31, 30);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "| |";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // ShowBombCount
            // 
            this.ShowBombCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowBombCount.AutoSize = true;
            this.ShowBombCount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBombCount.ForeColor = System.Drawing.Color.White;
            this.ShowBombCount.Location = new System.Drawing.Point(254, 15);
            this.ShowBombCount.Name = "ShowBombCount";
            this.ShowBombCount.Size = new System.Drawing.Size(37, 29);
            this.ShowBombCount.TabIndex = 1;
            this.ShowBombCount.Text = "40";
            // 
            // TimeShow
            // 
            this.TimeShow.AutoSize = true;
            this.TimeShow.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeShow.ForeColor = System.Drawing.Color.White;
            this.TimeShow.Location = new System.Drawing.Point(12, 14);
            this.TimeShow.Name = "TimeShow";
            this.TimeShow.Size = new System.Drawing.Size(97, 29);
            this.TimeShow.TabIndex = 1;
            this.TimeShow.Text = "00:00:00";
            // 
            // PlayTimeTimer
            // 
            this.PlayTimeTimer.Interval = 1000;
            this.PlayTimeTimer.Tick += new System.EventHandler(this.PlayTimeTimer_Tick);
            // 
            // PausePanel
            // 
            this.PausePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PausePanel.Controls.Add(this.PlayButton);
            this.PausePanel.Location = new System.Drawing.Point(0, 60);
            this.PausePanel.Name = "PausePanel";
            this.PausePanel.Size = new System.Drawing.Size(400, 272);
            this.PausePanel.TabIndex = 1;
            this.PausePanel.Visible = false;
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(339, 19);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(49, 32);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "►";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.PausePanel);
            this.Controls.Add(this.GamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mine Sweeper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.PausePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Timer PlayTimeTimer;
        private System.Windows.Forms.Label TimeShow;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Panel PausePanel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ShowBombCount;



    }
}

