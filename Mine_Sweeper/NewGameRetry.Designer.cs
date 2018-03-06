namespace Mine_Sweeper
{
    partial class NewGameRetry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGameRetry));
            this.NewGameButton = new System.Windows.Forms.Button();
            this.RetryGameButton = new System.Windows.Forms.Button();
            this.CancelGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.NewGameButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.Location = new System.Drawing.Point(52, 12);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(330, 45);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            // 
            // RetryGameButton
            // 
            this.RetryGameButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.RetryGameButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryGameButton.Location = new System.Drawing.Point(52, 63);
            this.RetryGameButton.Name = "RetryGameButton";
            this.RetryGameButton.Size = new System.Drawing.Size(330, 45);
            this.RetryGameButton.TabIndex = 0;
            this.RetryGameButton.Text = "Retry this game";
            this.RetryGameButton.UseVisualStyleBackColor = true;
            // 
            // CancelGameButton
            // 
            this.CancelGameButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelGameButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelGameButton.Location = new System.Drawing.Point(52, 114);
            this.CancelGameButton.Name = "CancelGameButton";
            this.CancelGameButton.Size = new System.Drawing.Size(330, 45);
            this.CancelGameButton.TabIndex = 0;
            this.CancelGameButton.Text = "Cancel";
            this.CancelGameButton.UseVisualStyleBackColor = true;
            // 
            // NewGameRetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 172);
            this.ControlBox = false;
            this.Controls.Add(this.CancelGameButton);
            this.Controls.Add(this.RetryGameButton);
            this.Controls.Add(this.NewGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewGameRetry";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Don\'t Worry, Play again!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button RetryGameButton;
        private System.Windows.Forms.Button CancelGameButton;
    }
}