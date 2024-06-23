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
    public partial class LoadScreen : Form
    {
        private bool isGreen = true;
        public LoadScreen()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadline.Width += 2;

            if (loadline.Width >= 774)
            {
                timer1.Stop();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }

            if (isGreen)
            {
                this.label2.ForeColor = Color.FromArgb(255, 0, 255, 0); // Green color
            }
            else
            {
                this.label2.ForeColor = Color.FromArgb(255, 128, 128, 128); // Gray color
            }

            isGreen = !isGreen; // Toggle the flag

        }

        private void loadline_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
