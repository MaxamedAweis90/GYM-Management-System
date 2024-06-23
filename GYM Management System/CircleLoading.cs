using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Management_System
{
    public partial class CircleLoading : Form
    {

        private bool isGreen = true;
        public CircleLoading()
        {
            InitializeComponent();
        }



        int startp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 1;
            MyProcress.Value = startp;
            if (MyProcress.Value == 100)
            {
                MyProcress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();

            }

        }

        private void CircleLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

        }

        private void MyProcress_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (isGreen)
            {
                this.label1.ForeColor = Color.FromArgb(255, 0, 255, 0); // Green color
            }
            else
            {
                this.label1.ForeColor = Color.FromArgb(255, 128, 128, 128); // Gray color
            }

            isGreen = !isGreen;

        }
    }
}
