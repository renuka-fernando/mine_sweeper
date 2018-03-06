namespace Mine_Sweeper
{
    partial class ResultSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultSheet));
            this.NameEasyText = new System.Windows.Forms.TextBox();
            this.TimeEasyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameMediumText = new System.Windows.Forms.TextBox();
            this.TimeMediumLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameHardText = new System.Windows.Forms.TextBox();
            this.TimeHardLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameEasyText
            // 
            this.NameEasyText.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEasyText.Location = new System.Drawing.Point(79, 58);
            this.NameEasyText.Name = "NameEasyText";
            this.NameEasyText.ReadOnly = true;
            this.NameEasyText.Size = new System.Drawing.Size(268, 24);
            this.NameEasyText.TabIndex = 0;
            this.NameEasyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameEasyText_KeyPress);
            // 
            // TimeEasyLabel
            // 
            this.TimeEasyLabel.AutoSize = true;
            this.TimeEasyLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeEasyLabel.Location = new System.Drawing.Point(388, 61);
            this.TimeEasyLabel.Name = "TimeEasyLabel";
            this.TimeEasyLabel.Size = new System.Drawing.Size(58, 17);
            this.TimeEasyLabel.TabIndex = 1;
            this.TimeEasyLabel.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Best Time";
            // 
            // NameMediumText
            // 
            this.NameMediumText.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameMediumText.Location = new System.Drawing.Point(79, 88);
            this.NameMediumText.Name = "NameMediumText";
            this.NameMediumText.ReadOnly = true;
            this.NameMediumText.Size = new System.Drawing.Size(268, 24);
            this.NameMediumText.TabIndex = 0;
            this.NameMediumText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameMediumText_KeyPress);
            // 
            // TimeMediumLabel
            // 
            this.TimeMediumLabel.AutoSize = true;
            this.TimeMediumLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeMediumLabel.Location = new System.Drawing.Point(388, 91);
            this.TimeMediumLabel.Name = "TimeMediumLabel";
            this.TimeMediumLabel.Size = new System.Drawing.Size(58, 17);
            this.TimeMediumLabel.TabIndex = 1;
            this.TimeMediumLabel.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Easy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Medium";
            // 
            // NameHardText
            // 
            this.NameHardText.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHardText.Location = new System.Drawing.Point(79, 119);
            this.NameHardText.Name = "NameHardText";
            this.NameHardText.ReadOnly = true;
            this.NameHardText.Size = new System.Drawing.Size(268, 24);
            this.NameHardText.TabIndex = 0;
            this.NameHardText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameHardText_KeyPress);
            // 
            // TimeHardLabel
            // 
            this.TimeHardLabel.AutoSize = true;
            this.TimeHardLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeHardLabel.Location = new System.Drawing.Point(388, 122);
            this.TimeHardLabel.Name = "TimeHardLabel";
            this.TimeHardLabel.Size = new System.Drawing.Size(58, 17);
            this.TimeHardLabel.TabIndex = 1;
            this.TimeHardLabel.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hard";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(363, 149);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(78, 26);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(301, 149);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(58, 25);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ResultSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 187);
            this.ControlBox = false;
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimeHardLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeMediumLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameHardText);
            this.Controls.Add(this.TimeEasyLabel);
            this.Controls.Add(this.NameMediumText);
            this.Controls.Add(this.NameEasyText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ResultSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameEasyText;
        private System.Windows.Forms.Label TimeEasyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameMediumText;
        private System.Windows.Forms.Label TimeMediumLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameHardText;
        private System.Windows.Forms.Label TimeHardLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ResetButton;
    }
}