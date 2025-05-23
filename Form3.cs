using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_05_09_kaihatsunojugyoNo1
{
    public partial class Frm_ResultScreen : Form
    {

        private int iLevelTemp;

        public Frm_ResultScreen(string strUserName, int iMaxScore, int iScorePoint, int Time)
        {
            InitializeComponent();

            lbl_chrUserName.Text = strUserName;

            lbl_chrScorePoint.Text = iScorePoint.ToString();


            if (iMaxScore == 3000)
            {
                iLevelTemp = 60;
            }
            if(iMaxScore == 5000)
            {
                iLevelTemp = 30;
            }
            if(iMaxScore == 8000)
            {
                iLevelTemp = 15;
            }

            if (Time > 0)
            {
                if (iScorePoint == iMaxScore)
                {
                    lbl_chrPerfect.Visible = true;
                    lbl_chrPerfect.Text = "Perfect!!";
                }
                else
                {
                    lbl_chrPerfect.Visible = true;
                    lbl_chrPerfect.Text = "Game Clear";
                }
            }
            else
            {
                lbl_chrPerfect.Visible = true;
                lbl_chrPerfect.Text = "Game Over";
            }
        }




        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void cbx_slcContinueOR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_slcLogout_Click(object sender, EventArgs e)
        {
            Frm_StartScreen formS = new Frm_StartScreen();

            formS.Show();

            this.Hide();

        }

        private void lbl_slcContinue_Click(object sender, EventArgs e)
        {
            Frm_GameScreen formG = new Frm_GameScreen(lbl_chrUserName.Text, iLevelTemp);

            formG.Show();

            this.Hide();
        }

        private void Frm_ResultScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
