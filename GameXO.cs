using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project2
{
    public partial class GameXO : Form
    {
        public GameXO()
        {
            InitializeComponent();
        }

        int Player1Results = 0;
        int Player2Results = 0;
        static int Player = 1;
        static int Step = 0;

        /*
            1  2   4 
            8  16  32 
            64 128 256
            0 1 2
            3 4 5
            6 7 8
        */
        int[] Array = { 1, 2, 4, 8, 16, 32, 64, 128, 256 };

        bool Condition(int Results, int Index1, int Index2, int Index3)
        {
            return ((Results & Array[Index1]) == Array[Index1]) && ((Results & Array[Index2]) == Array[Index2]) && ((Results & Array[Index3]) == Array[Index3]);

            //return (Results & Array[Index1]) == Array[Index1] ? ((Results & Array[Index2]) == Array[Index2] ? ((Results & Array[Index3]) == Array[Index3]) : false) : false;
        }

        void GameOverMessage()
        {
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool CheckToResults(int Results)
        {
            //if (Condition(7, 0, 1, 2))
            if (((Results & Array[0]) == Array[0]) && ((Results & Array[1]) == Array[1]) && ((Results & Array[2]) == Array[2]))
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                return true;
            }
            //if(Condition(56, 3, 4, 5)) 
            if (((Results & Array[3]) == Array[3]) && ((Results & Array[4]) == Array[4]) && ((Results & Array[5]) == Array[5]))
            {
                btn8.BackColor = Color.Green;
                btn16.BackColor = Color.Green;
                btn32.BackColor = Color.Green;
                return true;    
            }
            //if(Condition(448, 6, 7, 8))
            if (((Results & Array[6]) == Array[6]) && ((Results & Array[7]) == Array[7]) && ((Results & Array[8]) == Array[8]))
            {
                btn64.BackColor = Color.Green;
                btn128.BackColor = Color.Green;
                btn256.BackColor = Color.Green;
                return true;
            }
            //if (Condition(273, 0, 4, 8)) 
            if (((Results & Array[0]) == Array[0]) && ((Results & Array[4]) == Array[4]) && ((Results & Array[8]) == Array[8]))
            {
                btn1.BackColor = Color.Green;
                btn16.BackColor = Color.Green;
                btn256.BackColor = Color.Green;
                return true;
            }
            //if (Condition(84, 2, 4, 6))
            if (((Results & Array[2]) == Array[2]) && ((Results & Array[4]) == Array[4]) && ((Results & Array[6]) == Array[6]))
            {
                btn4.BackColor = Color.Green;
                btn16.BackColor = Color.Green;
                btn64.BackColor = Color.Green;
                return true;
            }
            //if(Condition(73, 0, 3, 6))
            if (((Results & Array[0]) == Array[0]) && ((Results & Array[3]) == Array[3]) && ((Results & Array[6]) == Array[6]))
            {
                btn1.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn64.BackColor = Color.Green;
                return true;
            }
            //if(Condition(146, 1, 4, 7))
            if (((Results & Array[1]) == Array[1]) && ((Results & Array[4]) == Array[4]) && ((Results & Array[7]) == Array[7]))
            {
                btn2.BackColor = Color.Green;
                btn16.BackColor = Color.Green;
                btn128.BackColor = Color.Green;
                return true;
            }
            //if(Condition(292, 2, 4, 8))
            if (((Results & Array[2]) == Array[4]) && ((Results & Array[4]) == Array[4]) && ((Results & Array[8]) == Array[8]))
            {
                btn4.BackColor = Color.Green;
                btn32.BackColor = Color.Green;
                btn256.BackColor = Color.Green;
                return true;
            }
            return false;
        }
        void SetCheckedButton(string Symbol, int ClickedBy)
        {
            if (btn1.Text == "?" && ClickedBy == 1)
            {
                btn1.Text = Symbol;
                btn1.ForeColor = Color.BlueViolet;
                return;
            }
            if (btn2.Text == "?" && ClickedBy == 2)
            {
                btn2.Text = Symbol;
                btn2.ForeColor = Color.BlueViolet;
                return;
            }
            if (btn4.Text == "?" && ClickedBy == 4)
            {
                btn4.Text = Symbol;
                btn4.ForeColor = Color.BlueViolet;
                return;
            }
            if (btn8.Text == "?" && ClickedBy == 8)
            {
                btn8.Text = Symbol;
                btn8.ForeColor = Color.BlueViolet;
                return;
            }
            if (btn16.Text == "?" && ClickedBy == 16)
            {
                btn16.Text = Symbol;
                btn16.ForeColor = Color.BlueViolet;
                return;
            }
            if (btn32.Text == "?" && ClickedBy == 32)
            {
                btn32.Text = Symbol;
                btn32.ForeColor = Color.BlueViolet;
                return;
            }
            if (btn64.Text == "?" && ClickedBy == 64)
            {
                btn64.Text = Symbol;
                btn64.ForeColor = Color.BlueViolet;
                return;
            }
            if (btn128.Text == "?" && ClickedBy == 128)
            {
                btn128.Text = Symbol;
                btn128.ForeColor = Color.BlueViolet;
                return;
            }
            if (btn256.Text == "?" && ClickedBy == 256)
            {
                btn256.Text = Symbol;
                btn256.ForeColor = Color.BlueViolet;
                return;
            }
        }
        void ErrorMessage()
        {
            MessageBox.Show("This Choice is Choiced", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        bool CheckToCheckedButton(string Symbol, int ClickedBy)
        {
            if ((btn1.Text == "X" || btn1.Text == "O") && ClickedBy == 1) 
            {
                ErrorMessage();
                return false;
            }
            if ((btn2.Text == "X" || btn2.Text == "O") && ClickedBy == 2)
            {
                ErrorMessage();
                return false;
            }
            if ((btn4.Text == "X" || btn4.Text == "O") && ClickedBy == 4)
            {
                ErrorMessage();
                return false;
            }
            if ((btn8.Text == "X" || btn8.Text == "O") && ClickedBy == 8)
            {
                ErrorMessage();
                return false;
            }
            if ((btn16.Text == "X" || btn16.Text == "O") && ClickedBy == 16)
            {
                ErrorMessage();
                return false;
            }
            if ((btn32.Text == "X" || btn32.Text == "O") && ClickedBy == 32)
            {
                ErrorMessage();
                return false;
            }
            if ((btn64.Text == "X" || btn64.Text == "O") && ClickedBy == 64)
            {
                ErrorMessage();
                return false;
            }
            if ((btn128.Text == "X" || btn128.Text == "O") && ClickedBy == 128)
            {
                ErrorMessage();
                return false;
            }
            if ((btn256.Text == "X" || btn256.Text == "O") && ClickedBy == 256)
            {
                ErrorMessage();
                return false;
            }
            
            SetCheckedButton(Symbol, ClickedBy);
            return true;
        }
        bool SetGameResult(string Palyer, int Results, int Steps)
        {
            if(CheckToResults(Results))
            {
                lblWinnerInGame.Text = Palyer;
                lblWinnerInGame.TextAlign = ContentAlignment.MiddleCenter;
                return true;
            }
            if(Steps==9)
            {
                lblWinnerInGame.Text = "Draw";
                lblWinnerInGame.TextAlign = ContentAlignment.MiddleCenter;
                return true;
            }
            return false;

        }
        void SetPalyerInfo(int ClickedBy)
        {
            Step++;
            if (Player > 0)
            {
                if (!CheckToCheckedButton("X", ClickedBy))
                {
                    Player = -Player;
                }
                else
                {
                    Player1Results += ClickedBy;
                    CurrentPlayer.Text = "Ömer";
                    if(SetGameResult("Player 1", Player1Results, Step))
                    {
                        CurrentPlayer.Text = "Game Over";
                        GameOverMessage();

                    }
                }

            }
            else
            {
                if (!CheckToCheckedButton("O", ClickedBy))
                {
                    Player = -Player;
                }
                else
                {
                    CurrentPlayer.Text = "Player 1";
                    Player2Results += ClickedBy;
                    if (SetGameResult("Ömer", Player2Results, Step))
                    {
                        CurrentPlayer.Text = "Game Over";
                        GameOverMessage();

                    }

                }

            }
            Player = -Player;
        }
        private void GameXO_Paint(object sender, PaintEventArgs e)
        {
            Color Withe = Color.FromArgb(255, 255, 255, 255);

            Pen pen = new Pen(Withe);
            pen.Width = 15;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(pen, 400, 460, 1050, 460);
            
            e.Graphics.DrawLine(pen, 610, 140, 610, 620);
            e.Graphics.DrawLine(pen, 840, 140, 840, 620);

        }

        private void GameXO_Load(object sender, EventArgs e)
        {
        }

        private void btn256_Click(object sender, EventArgs e)
        {
            SetPalyerInfo(256);
        }

        private void btn128_Click(object sender, EventArgs e)
        {
            SetPalyerInfo(128);

        }

        private void btn64_Click(object sender, EventArgs e)
        {

            SetPalyerInfo(64);
        }

        private void btn32_Click(object sender, EventArgs e)
        {

            SetPalyerInfo(32);
        }

        private void btn16_Click(object sender, EventArgs e)
        {

            SetPalyerInfo(16);
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            SetPalyerInfo(8);
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            SetPalyerInfo(4);
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            SetPalyerInfo(2);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SetPalyerInfo(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Text = "?";
            btn2.Text = "?";
            btn4.Text = "?";    
            btn8.Text = "?";
            btn16.Text = "?";
            btn32.Text = "?";
            btn64.Text = "?";
            btn128.Text = "?";  
            btn256.Text = "?";
            CurrentPlayer.Text = "Player 1";
            lblWinnerInGame.Text = "In Progress";


            btn1.ForeColor = Color.Red;
            btn2.ForeColor = Color.Red;
            btn4.ForeColor = Color.Red;
            btn8.ForeColor = Color.Red;
            btn16.ForeColor = Color.Red;
            btn32.ForeColor = Color.Red;
            btn64.ForeColor = Color.Red;
            btn128.ForeColor = Color.Red;
            btn256.ForeColor = Color.Red;

            btn1.BackColor = Color.Black;
            btn2.BackColor = Color.Black;
            btn4.BackColor = Color.Black;
            btn8.BackColor = Color.Black;
            btn16.BackColor = Color.Black;
            btn32.BackColor = Color.Black;
            btn64.BackColor = Color.Black;
            btn128.BackColor = Color.Black;
            btn256.BackColor = Color.Black;

            Step = 0;

            Player1Results = 0;
            Player2Results = 0;

            Player = 1;






        }
    }
}

