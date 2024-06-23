using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.Native;

namespace GYM_Management_System
{
    public partial class MissingInfo : Form
    {
        public MissingInfo()
        {
            InitializeComponent();
        }

        private void MissingInfo_Load(object sender, EventArgs e)
        {
            this.Hide();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
