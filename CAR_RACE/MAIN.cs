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
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
            easy.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            easy.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f_easy = new Form1();
            f_easy.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (yellowcar.Top >= 500)
            {
                x = r.Next(240, 400);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy(5);
        }

        private void replay_Click(object sender, EventArgs e)
        {

        }
        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (redcar.Left > 30)
                    redcar.Left += -30;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (redcar.Right < 420)
                    redcar.Left += 30;
            }
        }
    }
}
