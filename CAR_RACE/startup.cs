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
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressbar.Value = startpoint;
            if (progressbar.Value == 100)
            {
                progressbar.Value = 0;
                timer1.Stop();
                MAIN form = new MAIN();
                form.Show();
                this.Hide();
            }
        }

        private void startup_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
