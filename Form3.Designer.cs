namespace _2025_05_09_kaihatsunojugyoNo1
{
    partial class Frm_ResultScreen
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
            this.lbl_chrResult = new System.Windows.Forms.Label();
            this.lbl_slcLogout = new System.Windows.Forms.Label();
            this.lbl_slcContinue = new System.Windows.Forms.Label();
            this.lbl_chrUserName = new System.Windows.Forms.Label();
            this.lbl_chrScorePoint = new System.Windows.Forms.Label();
            this.lbl_chrPerfect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_chrResult
            // 
            this.lbl_chrResult.AutoSize = true;
            this.lbl_chrResult.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrResult.Location = new System.Drawing.Point(826, 359);
            this.lbl_chrResult.Name = "lbl_chrResult";
            this.lbl_chrResult.Size = new System.Drawing.Size(127, 100);
            this.lbl_chrResult.TabIndex = 0;
            this.lbl_chrResult.Text = "pt";
            // 
            // lbl_slcLogout
            // 
            this.lbl_slcLogout.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_slcLogout.Location = new System.Drawing.Point(168, 556);
            this.lbl_slcLogout.Name = "lbl_slcLogout";
            this.lbl_slcLogout.Size = new System.Drawing.Size(170, 32);
            this.lbl_slcLogout.TabIndex = 1;
            this.lbl_slcLogout.Text = "Exit";
            this.lbl_slcLogout.Click += new System.EventHandler(this.lbl_slcLogout_Click);
            // 
            // lbl_slcContinue
            // 
            this.lbl_slcContinue.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_slcContinue.Location = new System.Drawing.Point(961, 557);
            this.lbl_slcContinue.Name = "lbl_slcContinue";
            this.lbl_slcContinue.Size = new System.Drawing.Size(223, 31);
            this.lbl_slcContinue.TabIndex = 2;
            this.lbl_slcContinue.Text = "Continue";
            this.lbl_slcContinue.Click += new System.EventHandler(this.lbl_slcContinue_Click);
            // 
            // lbl_chrUserName
            // 
            this.lbl_chrUserName.Font = new System.Drawing.Font("MS UI Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrUserName.Location = new System.Drawing.Point(140, 36);
            this.lbl_chrUserName.Name = "lbl_chrUserName";
            this.lbl_chrUserName.Size = new System.Drawing.Size(138, 347);
            this.lbl_chrUserName.TabIndex = 3;
            this.lbl_chrUserName.Text = "label1";
            this.lbl_chrUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_chrScorePoint
            // 
            this.lbl_chrScorePoint.Font = new System.Drawing.Font("MS UI Gothic", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrScorePoint.Location = new System.Drawing.Point(344, 291);
            this.lbl_chrScorePoint.Name = "lbl_chrScorePoint";
            this.lbl_chrScorePoint.Size = new System.Drawing.Size(500, 200);
            this.lbl_chrScorePoint.TabIndex = 4;
            this.lbl_chrScorePoint.Text = "label1";
            this.lbl_chrScorePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_chrPerfect
            // 
            this.lbl_chrPerfect.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrPerfect.Location = new System.Drawing.Point(336, 143);
            this.lbl_chrPerfect.Name = "lbl_chrPerfect";
            this.lbl_chrPerfect.Size = new System.Drawing.Size(492, 76);
            this.lbl_chrPerfect.TabIndex = 5;
            this.lbl_chrPerfect.Text = "Perfect!!";
            this.lbl_chrPerfect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_chrPerfect.Visible = false;
            // 
            // Frm_ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.lbl_chrPerfect);
            this.Controls.Add(this.lbl_chrScorePoint);
            this.Controls.Add(this.lbl_chrUserName);
            this.Controls.Add(this.lbl_slcContinue);
            this.Controls.Add(this.lbl_slcLogout);
            this.Controls.Add(this.lbl_chrResult);
            this.Name = "Frm_ResultScreen";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ResultScreen_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chrResult;
        private System.Windows.Forms.Label lbl_slcLogout;
        private System.Windows.Forms.Label lbl_slcContinue;
        private System.Windows.Forms.Label lbl_chrUserName;
        private System.Windows.Forms.Label lbl_chrScorePoint;
        private System.Windows.Forms.Label lbl_chrPerfect;
    }
}