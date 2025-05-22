using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2025_05_09_kaihatsunojugyoNo1
{
    public partial class Frm_GameScreen : Form
    {

        // 入力させる文字を表示テキストに更新するリスト
        string[] arry_EasyDisplayStrings = { "Wait a minute", "Hold it up", "He is one gigantic motherfucker", "Remember I promised to kill you last", "" };
        string[] arry_NomalDisplayStrings = { "Wait a minute", "Hold it up", "He is one gigantic motherfucker", "Remember I promised to kill you last", "" };
        string[] arry_HardDisplayStrings = { };
        private string[] strDisplayString;
        // 表示テキストのリストのインデックス
        private int idxDisplayStrings = 0;

        // タイピングの時間制限の変数
        private Timer timer;

        public Frm_GameScreen(string str_UserName, int Level_Time)
        {
            InitializeComponent();

            // ユーザーネームの表示
            lbl_chrUseName.Text = str_UserName;


            // 入力させるタイピングの文字列を表示
            // Todo 難易度別でタイマーと入力文字列の違いをする
            if (Level_Time == 60)
            {
                strDisplayString = arry_EasyDisplayStrings;
                
            }
            if (Level_Time == 30)
            {
                strDisplayString = arry_NomalDisplayStrings;
            }
            if(Level_Time == 15)
            {
                strDisplayString = arry_HardDisplayStrings;
            }
            lbl_chrTypingChar.Text = strDisplayString[idxDisplayStrings];

            // タイピングの時間制限
            pbr_ProgressBar.Maximum = Level_Time;
            pbr_ProgressBar.Value = Level_Time;
            timer = new Timer();
            timer.Interval = 1000; // 1秒ごとに処理
            timer.Tick += Timer_Tick;
            timer.Start();

            // エンターキーが入力された時に文字列を比較する
            tbx_inpTypingChar.KeyDown += new KeyEventHandler(tbx_inpTypingChar_KeyDown);

            // フォームが閉じられたらタイマーを停止させる処理
            this.FormClosing += Frm_GameScreen_FormClosing;


        }

        private void tbx_inpTypingChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // **エンターキーのデフォルト動作を抑制**
                TypingMatch(lbl_chrTypingChar.Text, tbx_inpTypingChar.Text);
                tbx_inpTypingChar.Text = "";
            }
        }

        private void TypingMatch(string Matcher, string Matchee)
        {
            if (Matcher == Matchee)
            {
                // Todo タイマーの値をMaxにリセットする
                pbr_ProgressBar.Value = pbr_ProgressBar.Maximum;

                // 表示テキストを更新する
                if (idxDisplayStrings <= strDisplayString.Length - 1)
                {

                    idxDisplayStrings++;
                    lbl_chrTypingChar.Text = strDisplayString[idxDisplayStrings];

                  
                }
                else
                {
                    // Todo 画面遷移でPerfect表示
                }


            }



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pbr_ProgressBar.Value > 0)
            {
                pbr_ProgressBar.Value--;
            }
            else
            {
                // Todo:ifでゲーム画面が閉じたらメッセージを表示させないようにする

                timer.Stop();
                MessageBox.Show("時間切れ！", "ゲーム終了", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // **フォームが閉じるときにタイマーを停止**
            timer.Stop();
            timer.Dispose();
            MessageBox.Show("タイマーを停止しました。");
        }

    }
}


