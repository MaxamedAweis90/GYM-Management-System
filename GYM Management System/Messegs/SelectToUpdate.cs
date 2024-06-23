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
    public partial class SelectToUpdate : Form
    {
        public SelectToUpdate()
        {
            InitializeComponent();
        }

        private void SelectToUpdate_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
