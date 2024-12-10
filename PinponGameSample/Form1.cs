using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinponGameSample
{
    public partial class GameForm : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;

        public GameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None; 
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds; 

            Racket.Top = this.ClientSize.Height - (this.ClientSize.Height / 20); 
            Gameover_lbl.Left = (this.ClientSize.Width / 2) - (Gameover_lbl.Width / 2);
            Gameover_lbl.Top = (this.ClientSize.Height / 2) - (Gameover_lbl.Height / 2);
            Gameover_lbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);
            Ball_lbl.Left += speed_left;
            Ball_lbl.Top += speed_top;
            if (Ball_lbl.Left <= 0)
            {
                speed_left = -speed_left;
            }
            if (Ball_lbl.Right >= this.ClientSize.Width)
            {
                speed_left = -speed_left;
            }
            if (Ball_lbl.Top <= 0)
            {
                speed_top = -speed_top;
            }
            if (Ball_lbl.Bottom >= this.ClientSize.Height)
            {
                Gameover_lbl.Visible = true;
                timer1.Enabled = false;
            }
            if (Ball_lbl.Bottom >= Racket.Top &&
                    Ball_lbl.Bottom <= Racket.Bottom &&
                        Ball_lbl.Left >= Racket.Left &&
                            Ball_lbl.Right <= Racket.Right)
            {
                speed_top = -speed_top; 
                points += 1;
                Points_lbl.Text = points.ToString();
                Random randomize = new Random();
                this.BackColor = Color.FromArgb(randomize.Next(150, 255), randomize.Next(150, 255), randomize.Next(150, 255));
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1) 
            {
                Ball_lbl.Top = 200;
                Ball_lbl.Left = 200;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                Points_lbl.Text = "0";
                timer1.Enabled = true;
                Gameover_lbl.Visible = false;
                this.BackColor = Color.Wheat;
            }
        }
    }
}
