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
            this.SuspendLayout();
            // 
            // lbl_chrResult
            // 
            this.lbl_chrResult.AutoSize = true;
            this.lbl_chrResult.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrResult.Location = new System.Drawing.Point(510, 128);
            this.lbl_chrResult.Name = "lbl_chrResult";
            this.lbl_chrResult.Size = new System.Drawing.Size(127, 100);
            this.lbl_chrResult.TabIndex = 0;
            this.lbl_chrResult.Text = "pt";
            // 
            // lbl_slcLogout
            // 
            this.lbl_slcLogout.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_slcLogout.Location = new System.Drawing.Point(109, 347);
            this.lbl_slcLogout.Name = "lbl_slcLogout";
            this.lbl_slcLogout.Size = new System.Drawing.Size(110, 32);
            this.lbl_slcLogout.TabIndex = 1;
            this.lbl_slcLogout.Text = "Log out";
            this.lbl_slcLogout.Click += new System.EventHandler(this.lbl_slcLogout_Click);
            // 
            // lbl_slcContinue
            // 
            this.lbl_slcContinue.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_slcContinue.Location = new System.Drawing.Point(578, 347);
            this.lbl_slcContinue.Name = "lbl_slcContinue";
            this.lbl_slcContinue.Size = new System.Drawing.Size(126, 31);
            this.lbl_slcContinue.TabIndex = 2;
            this.lbl_slcContinue.Text = "Continue";
            // 
            // Frm_ResultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 444);
            this.Controls.Add(this.lbl_slcContinue);
            this.Controls.Add(this.lbl_slcLogout);
            this.Controls.Add(this.lbl_chrResult);
            this.Name = "Frm_ResultScreen";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chrResult;
        private System.Windows.Forms.Label lbl_slcLogout;
        private System.Windows.Forms.Label lbl_slcContinue;
    }
}