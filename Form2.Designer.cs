namespace _2025_05_09_kaihatsunojugyoNo1
{
    partial class Frm_StartScreen
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
            this.tbx_iptUserName = new System.Windows.Forms.TextBox();
            this.lbl_inpUserName = new System.Windows.Forms.Label();
            this.lbl_chrTitle = new System.Windows.Forms.Label();
            this.btn_chrStart = new System.Windows.Forms.Button();
            this.rbt_chrLevelEasy = new System.Windows.Forms.RadioButton();
            this.rbt_chrLevelNormal = new System.Windows.Forms.RadioButton();
            this.rbt_chrLevelHard = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_iptUserName
            // 
            this.tbx_iptUserName.BackColor = System.Drawing.Color.White;
            this.tbx_iptUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_iptUserName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbx_iptUserName.Location = new System.Drawing.Point(336, 231);
            this.tbx_iptUserName.MaxLength = 20;
            this.tbx_iptUserName.Name = "tbx_iptUserName";
            this.tbx_iptUserName.Size = new System.Drawing.Size(440, 25);
            this.tbx_iptUserName.TabIndex = 1;
            this.tbx_iptUserName.TextChanged += new System.EventHandler(this.tbx_iptUserName_TextChanged);
            // 
            // lbl_inpUserName
            // 
            this.lbl_inpUserName.Font = new System.Drawing.Font("MS UI Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_inpUserName.Location = new System.Drawing.Point(329, 168);
            this.lbl_inpUserName.Name = "lbl_inpUserName";
            this.lbl_inpUserName.Size = new System.Drawing.Size(221, 60);
            this.lbl_inpUserName.TabIndex = 2;
            this.lbl_inpUserName.Text = "名前";
            this.lbl_inpUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_chrTitle
            // 
            this.lbl_chrTitle.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrTitle.Location = new System.Drawing.Point(159, 54);
            this.lbl_chrTitle.Name = "lbl_chrTitle";
            this.lbl_chrTitle.Size = new System.Drawing.Size(938, 70);
            this.lbl_chrTitle.TabIndex = 3;
            this.lbl_chrTitle.Text = "うどん打～讃岐流タイピング修行～";
            this.lbl_chrTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_chrStart
            // 
            this.btn_chrStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_chrStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_chrStart.FlatAppearance.BorderSize = 0;
            this.btn_chrStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chrStart.Font = new System.Drawing.Font("MS UI Gothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_chrStart.Location = new System.Drawing.Point(397, 389);
            this.btn_chrStart.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chrStart.Name = "btn_chrStart";
            this.btn_chrStart.Size = new System.Drawing.Size(343, 78);
            this.btn_chrStart.TabIndex = 4;
            this.btn_chrStart.Text = "Start";
            this.btn_chrStart.UseVisualStyleBackColor = false;
            this.btn_chrStart.Visible = false;
            this.btn_chrStart.Click += new System.EventHandler(this.btn_chrStart_Click);
            // 
            // rbt_chrLevelEasy
            // 
            this.rbt_chrLevelEasy.AutoSize = true;
            this.rbt_chrLevelEasy.Location = new System.Drawing.Point(336, 315);
            this.rbt_chrLevelEasy.Name = "rbt_chrLevelEasy";
            this.rbt_chrLevelEasy.Size = new System.Drawing.Size(69, 22);
            this.rbt_chrLevelEasy.TabIndex = 5;
            this.rbt_chrLevelEasy.TabStop = true;
            this.rbt_chrLevelEasy.Text = "Easy";
            this.rbt_chrLevelEasy.UseVisualStyleBackColor = true;
            this.rbt_chrLevelEasy.CheckedChanged += new System.EventHandler(this.rbt_chrLevelEasy_CheckedChanged);
            // 
            // rbt_chrLevelNormal
            // 
            this.rbt_chrLevelNormal.AutoSize = true;
            this.rbt_chrLevelNormal.Location = new System.Drawing.Point(516, 315);
            this.rbt_chrLevelNormal.Name = "rbt_chrLevelNormal";
            this.rbt_chrLevelNormal.Size = new System.Drawing.Size(86, 22);
            this.rbt_chrLevelNormal.TabIndex = 6;
            this.rbt_chrLevelNormal.TabStop = true;
            this.rbt_chrLevelNormal.Text = "Normal";
            this.rbt_chrLevelNormal.UseVisualStyleBackColor = true;
            this.rbt_chrLevelNormal.CheckedChanged += new System.EventHandler(this.rbt_chrLevelNormal_CheckedChanged);
            // 
            // rbt_chrLevelHard
            // 
            this.rbt_chrLevelHard.AutoSize = true;
            this.rbt_chrLevelHard.Location = new System.Drawing.Point(707, 315);
            this.rbt_chrLevelHard.Name = "rbt_chrLevelHard";
            this.rbt_chrLevelHard.Size = new System.Drawing.Size(69, 22);
            this.rbt_chrLevelHard.TabIndex = 7;
            this.rbt_chrLevelHard.TabStop = true;
            this.rbt_chrLevelHard.Text = "Hard";
            this.rbt_chrLevelHard.UseVisualStyleBackColor = true;
            this.rbt_chrLevelHard.CheckedChanged += new System.EventHandler(this.rbt_chrLevelHard_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_chrTitle);
            this.panel1.Controls.Add(this.btn_chrStart);
            this.panel1.Controls.Add(this.rbt_chrLevelHard);
            this.panel1.Controls.Add(this.tbx_iptUserName);
            this.panel1.Controls.Add(this.lbl_inpUserName);
            this.panel1.Controls.Add(this.rbt_chrLevelEasy);
            this.panel1.Controls.Add(this.rbt_chrLevelNormal);
            this.panel1.Location = new System.Drawing.Point(40, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 514);
            this.panel1.TabIndex = 8;
            // 
            // Frm_StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Frm_StartScreen";
            this.Text = "S";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_iptUserName;
        private System.Windows.Forms.Label lbl_inpUserName;
        private System.Windows.Forms.Label lbl_chrTitle;
        private System.Windows.Forms.Button btn_chrStart;
        private System.Windows.Forms.RadioButton rbt_chrLevelEasy;
        private System.Windows.Forms.RadioButton rbt_chrLevelNormal;
        private System.Windows.Forms.RadioButton rbt_chrLevelHard;
        private System.Windows.Forms.Panel panel1;
    }
}