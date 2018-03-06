namespace Mine_Sweeper
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.EasyButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.AboutMeLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EasyButton
            // 
            this.EasyButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyButton.Location = new System.Drawing.Point(67, 56);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(247, 105);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.Text = "Easy\r\n       Grid      : 10 × 10\r\n       Bombs : 10";
            this.EasyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // MediumButton
            // 
            this.MediumButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumButton.Location = new System.Drawing.Point(67, 167);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(247, 105);
            this.MediumButton.TabIndex = 0;
            this.MediumButton.Text = "Medium\r\n       Grid      : 20 × 10\r\n       Bombs : 20";
            this.MediumButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.Click += new System.EventHandler(this.MediumButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardButton.Location = new System.Drawing.Point(67, 278);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(482, 105);
            this.HardButton.TabIndex = 0;
            this.HardButton.Text = "Hard\r\n       Grid      : 30 × 15\r\n       Bombs : 60";
            this.HardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultButton.Location = new System.Drawing.Point(320, 56);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(229, 215);
            this.ResultButton.TabIndex = 1;
            this.ResultButton.Text = "button1";
            this.ResultButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // AboutMeLabel
            // 
            this.AboutMeLabel.AutoSize = true;
            this.AboutMeLabel.Location = new System.Drawing.Point(431, 416);
            this.AboutMeLabel.Name = "AboutMeLabel";
            this.AboutMeLabel.Size = new System.Drawing.Size(179, 13);
            this.AboutMeLabel.TabIndex = 2;
            this.AboutMeLabel.TabStop = true;
            this.AboutMeLabel.Text = "Programmed By :  Renuka Fernando";
            this.AboutMeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutMeLabel_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 438);
            this.Controls.Add(this.AboutMeLabel);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.MediumButton);
            this.Controls.Add(this.EasyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mine Sweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button MediumButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.LinkLabel AboutMeLabel;
    }
}