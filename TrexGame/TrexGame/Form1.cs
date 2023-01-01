using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrexGame
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpspeed;
        int force = 12;
        int score = 0;
        int obstaclespeed = 10;
        Random random = new Random();
        int position;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            Trex.Top += jumpspeed;
            txtscore.Text = "Score: " + score;
            if(jumping == true && force < 0)
            {
                jumping = false;
            }
            if(jumping == true)
            {
                jumpspeed = -12;
                force -= 1;
            }
            else
            {
                jumpspeed = 12;
            }
            if(Trex.Top > 349 && jumping == false)
            {
                force = 12;
                Trex.Top = 350;
                jumpspeed = 0;

            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstaclespeed;
                    if(x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + random.Next(200,500) + (x.Width * 15);
                        score++;
                    }
                    if (Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        Gametimer.Stop();
                        Trex.Image = Properties.Resources.dead;
                        txtscore.Text += "Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }
            if(score > 5)
            {
                obstaclespeed = 15;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if(jumping == true)
            {
                jumping = false;
            }
            if(e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
        private void GameReset()
        {
             jumping = false;
             jumpspeed = 0;
             force = 12;
             score = 0;
             obstaclespeed = 10;
            txtscore.Text = "Score: " + score;
            Trex.Image = Properties.Resources.running;
             isGameOver = false;
            Trex.Top = 350;
            foreach(Control x in Trex.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }
            }
            Gametimer.Start();
        }
    }
}
