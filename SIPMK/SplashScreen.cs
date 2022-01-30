using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPMK
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gunaCircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                Login L = new Login();
                L.Show();
                this.Hide();
            }
            else
            {
                gunaCircleProgressBar1.Value += 1;
                //gunaProgressBar1.Value += 1;
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
