using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR_RACE
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        public Form1()
        {            
            InitializeComponent();
            over.Visible = false;
            replay.Visible = false;
            BACK.Visible = false;
            player.SoundLocation = "HAMMER.WAV";
            player1.SoundLocation = "EXPLODE.WAV";
        }
        

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            movecoins(10);
            enemy(1);
            gameover();
            coinscollection();

            //speed increment
            if(Convert.ToInt32(scores.Text) >= 5)
            {
                enemy(1);
            }

            if (Convert.ToInt32(scores.Text) >= 10)
            {
                enemy(3);
            }

            if (Convert.ToInt32(scores.Text) >= 15)
            {
                enemy(5);
            }
            if (Convert.ToInt32(scores.Text) >= 30)
            {
                enemy(7);
            }

            if (Convert.ToInt32(scores.Text) >= 50)
            {
                enemy(9);
            }
        }
        void movecoins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(60, 400);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(60, 400);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(60, 400);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(60, 400);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }

        }

        int collectedcoin = 0;
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (yellowcar.Top >= 500)
            {
                x=r.Next(240, 400);
                yellowcar.Location = new Point(x, 0);
            }
            else { yellowcar.Top += speed; }

            if (whitecar.Top >= 500)
            {
                x = r.Next(240, 400);
                whitecar.Location = new Point(x, 0);
            }
            else { whitecar.Top += speed; }

            if (greencar.Top >= 500)
            {
                x = r.Next(50, 200);
                greencar.Location = new Point(x, 0);
            }
            else { greencar.Top += speed; }

            if (whiteup.Top >= 500)
            {
                x = r.Next(50, 200);
                whiteup.Location = new Point(x, 0);
            }
            else { whiteup.Top += speed; }
        }

        void coinscollection()
        {
            if(redcar.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin+=1;
                scores.Text = collectedcoin.ToString();
                player.Play();
            }

            if (redcar.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin+=1;
                scores.Text = collectedcoin.ToString();
                player.Play();
            }

            if (redcar.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin+=1;
                scores.Text = collectedcoin.ToString();
                player.Play();
            }

            if (redcar.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin+=1;
                scores.Text = collectedcoin.ToString();
                player.Play();
            }

        }
        void gameover()
        {
            if (redcar.Bounds.IntersectsWith(greencar.Bounds))
            {
                player1.Play();
                timer1.Enabled = false;
                over.Visible = true;
                replay.Visible = true;
                BACK.Visible = true;
            }

            if (redcar.Bounds.IntersectsWith(yellowcar.Bounds))
            {
                player1.Play();
                timer1.Enabled = false;
                over.Visible = true;
                replay.Visible = true;
                BACK.Visible = true;
            }

            if (redcar.Bounds.IntersectsWith(whitecar.Bounds))
            {
                player1.Play();
                timer1.Enabled = false;
                over.Visible = true;
                replay.Visible = true;
                BACK.Visible = true;

            }

            if (redcar.Bounds.IntersectsWith(whiteup.Bounds))
            {
                player1.Play();
                timer1.Enabled = false;
                over.Visible = true;
                replay.Visible = true;
                BACK.Visible = true;
            }
        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void replay_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.Show();
            this.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(redcar.Left>30)
                redcar.Left += -30;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(redcar.Right<420)
                redcar.Left += 30;
            }
                        
        }
    }
}
