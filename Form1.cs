using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2025_05_09_kaihatsunojugyoNo1
{
    public partial class Frm_GameScreen : Form
    {

        // 入力させる文字を表示テキストに更新するリスト
        string[] arry_EasyDisplayStrings = { "Wait a minute", "Hold it up", "I lied", "We did", "Where is she?", "I like Cadillacs", "The price", "Wrong", "Just him", "He is dead tired" };
        string[] arry_NomalDisplayStrings = { "Mellow out", "I thought you were", "Listen to that", "Do not disturb my friend", "Dead? You thought wrong", "You are gonna love it","Any carry on luggage?" };
        string[] arry_HardDisplayStrings = { "Throw away that chickenshit gun", "Remember I promised to kill you last", "Come right here and get in this Cadillac", "My people got some business with you", "Open your mouth again and I will nail it shut" };
        private string[] strDisplayString;

        // 表示テキストのリストのインデックス
        private int idxDisplayStrings = 0;

        // タイピングの獲得点数の変数
        private int iScorePoint = 0;
        private int iMaxScorePoint;

        // タイピングの時間制限の変数
        private Timer timer;

        public Frm_GameScreen(string str_UserName, int Level_Time)
        {
            InitializeComponent();

            // ユーザーネームの表示
            lbl_chrUseName.Text = str_UserName;
            lbl_chrScorePoint.Text = iScorePoint.ToString();

            // 入力させるタイピングの文字列を表示
            // Todo 難易度別でタイマーと入力文字列の違いをする
            if (Level_Time == 60)
            {
                strDisplayString = arry_EasyDisplayStrings;
                iMaxScorePoint = 3000;

            }
            if (Level_Time == 30)
            {
                strDisplayString = arry_NomalDisplayStrings;
                iMaxScorePoint = 5000;
            }
            if(Level_Time == 15)
            {
                strDisplayString = arry_HardDisplayStrings;
                iMaxScorePoint = 8000;
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
                // 表示テキストを更新する
                if (idxDisplayStrings < strDisplayString.Length - 1)
                {

                    idxDisplayStrings++;
                    lbl_chrTypingChar.Text = strDisplayString[idxDisplayStrings];
                    iScorePoint = iScorePoint + CalculateScore(iMaxScorePoint);
                    lbl_chrScorePoint.Text = iScorePoint.ToString();

                }
                else
                {
                    // 画面遷移でPerfect表示
                    Frm_ResultScreen formR = new Frm_ResultScreen(lbl_chrUseName.Text, iMaxScorePoint, iScorePoint, pbr_ProgressBar.Value);

                    formR.Show();

                    this.Hide();

                    timer.Stop();

                    timer.Dispose();

                }

                // タイマーの値をMaxにリセットする
                pbr_ProgressBar.Value = pbr_ProgressBar.Maximum;

            }

        }


        private int CalculateScore(int MaxScore)
        {
            int denominator = pbr_ProgressBar.Maximum - pbr_ProgressBar.Value;

            // 分母が 0 になる可能性がある場合、デフォルト値を設定
            if (denominator == 0)
            {
                return MaxScore / strDisplayString.Length; // 例: (最高スコア/問題数)の値を返す
            }

            return (MaxScore / strDisplayString.Length) / denominator;

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
                // Todo 時間切れで強制的にリザルト画面へ遷移させる

                
                Frm_ResultScreen formR = new Frm_ResultScreen(lbl_chrUseName.Text, iMaxScorePoint, iScorePoint, pbr_ProgressBar.Value);

                formR.Show();

                this.Hide();

                timer.Stop();

                timer.Dispose();

            }
        }

        private void Frm_GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // フォームが閉じるときにタイマーを停止
            timer.Stop();
            timer.Dispose();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_GameScreen_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}


