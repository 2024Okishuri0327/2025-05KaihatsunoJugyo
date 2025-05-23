using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2025_05_09_kaihatsunojugyoNo1
{
    public partial class Frm_StartScreen : Form
    {
        private bool bl_GameReady_inpName = false;
        private bool bl_GameReady_slcLevel = false;
        private string str_UserName;
        private int int_Level;

        public Frm_StartScreen()
        {
            InitializeComponent();
        }

        private void tbx_iptUserName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbx_iptUserName.Text))
            {
                bl_GameReady_inpName = true;
                str_UserName = tbx_iptUserName.Text;

                if (bl_GameReady_inpName == true && bl_GameReady_slcLevel == true)
                {

                    btn_chrStart.Visible = true;
                }
            }
        }

        private void rbt_chrLevelEasy_CheckedChanged(object sender, EventArgs e)
        {
            int_Level = 60;

            bl_GameReady_slcLevel = true;            

            if (bl_GameReady_inpName == true && bl_GameReady_slcLevel == true)
            {
                btn_chrStart.Visible = true;
            }
        }

        private void rbt_chrLevelNormal_CheckedChanged(object sender, EventArgs e)
        {
            int_Level = 30;

            bl_GameReady_slcLevel = true;

            if (bl_GameReady_inpName == true && bl_GameReady_slcLevel == true)
            {
                btn_chrStart.Visible = true;
            }
        }

        private void rbt_chrLevelHard_CheckedChanged(object sender, EventArgs e)
        {
            int_Level = 15;

            bl_GameReady_slcLevel = true;

            if (bl_GameReady_inpName == true && bl_GameReady_slcLevel == true)
            {
                btn_chrStart.Visible = true;
            }

        }

        private void btn_chrStart_Click(object sender, EventArgs e)
        {


            if (btn_chrStart.Visible == true)
            {

                Frm_GameScreen formG = new Frm_GameScreen(str_UserName, int_Level);

                formG.Show();

                this.Hide();
            }

        }

        private void Frm_StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}

