namespace _2025_05_09_kaihatsunojugyoNo1
{
    partial class Frm_GameScreen
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_chrUseName = new System.Windows.Forms.Label();
            this.lbl_chrTypingChar = new System.Windows.Forms.Label();
            this.tbx_inpTypingChar = new System.Windows.Forms.TextBox();
            this.pbr_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_chrPoint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_chrScorePoint = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_chrUseName
            // 
            this.lbl_chrUseName.Font = new System.Drawing.Font("ＭＳ ゴシック", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrUseName.Location = new System.Drawing.Point(171, 68);
            this.lbl_chrUseName.Name = "lbl_chrUseName";
            this.lbl_chrUseName.Size = new System.Drawing.Size(145, 261);
            this.lbl_chrUseName.TabIndex = 0;
            this.lbl_chrUseName.Text = "UserName";
            this.lbl_chrUseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_chrTypingChar
            // 
            this.lbl_chrTypingChar.AutoSize = true;
            this.lbl_chrTypingChar.Font = new System.Drawing.Font("ＭＳ ゴシック", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrTypingChar.Location = new System.Drawing.Point(382, 248);
            this.lbl_chrTypingChar.Name = "lbl_chrTypingChar";
            this.lbl_chrTypingChar.Size = new System.Drawing.Size(389, 34);
            this.lbl_chrTypingChar.TabIndex = 1;
            this.lbl_chrTypingChar.Text = "（ここに文字が出ます）";
            // 
            // tbx_inpTypingChar
            // 
            this.tbx_inpTypingChar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbx_inpTypingChar.Location = new System.Drawing.Point(388, 304);
            this.tbx_inpTypingChar.Name = "tbx_inpTypingChar";
            this.tbx_inpTypingChar.Size = new System.Drawing.Size(396, 25);
            this.tbx_inpTypingChar.TabIndex = 2;
            // 
            // pbr_ProgressBar
            // 
            this.pbr_ProgressBar.Location = new System.Drawing.Point(339, 68);
            this.pbr_ProgressBar.Name = "pbr_ProgressBar";
            this.pbr_ProgressBar.Size = new System.Drawing.Size(489, 25);
            this.pbr_ProgressBar.TabIndex = 3;
            // 
            // lbl_chrPoint
            // 
            this.lbl_chrPoint.AutoSize = true;
            this.lbl_chrPoint.Font = new System.Drawing.Font("ＭＳ ゴシック", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrPoint.Location = new System.Drawing.Point(932, 130);
            this.lbl_chrPoint.Name = "lbl_chrPoint";
            this.lbl_chrPoint.Size = new System.Drawing.Size(38, 26);
            this.lbl_chrPoint.TabIndex = 4;
            this.lbl_chrPoint.Text = "pt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.lbl_chrScorePoint);
            this.panel1.Controls.Add(this.tbx_inpTypingChar);
            this.panel1.Controls.Add(this.lbl_chrPoint);
            this.panel1.Controls.Add(this.lbl_chrTypingChar);
            this.panel1.Controls.Add(this.lbl_chrUseName);
            this.panel1.Controls.Add(this.pbr_ProgressBar);
            this.panel1.Location = new System.Drawing.Point(59, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 526);
            this.panel1.TabIndex = 5;
            // 
            // lbl_chrScorePoint
            // 
            this.lbl_chrScorePoint.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_chrScorePoint.Location = new System.Drawing.Point(820, 116);
            this.lbl_chrScorePoint.Name = "lbl_chrScorePoint";
            this.lbl_chrScorePoint.Size = new System.Drawing.Size(106, 44);
            this.lbl_chrScorePoint.TabIndex = 5;
            this.lbl_chrScorePoint.Text = "120";
            this.lbl_chrScorePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(446, 362);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 34);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "(ここに文字が出ます)";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Frm_GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Frm_GameScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_chrUseName;
        private System.Windows.Forms.Label lbl_chrTypingChar;
        private System.Windows.Forms.TextBox tbx_inpTypingChar;
        private System.Windows.Forms.ProgressBar pbr_ProgressBar;
        private System.Windows.Forms.Label lbl_chrPoint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_chrScorePoint;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

