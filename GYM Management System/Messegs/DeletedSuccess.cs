using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Management_System.Messegs
{
    public partial class DeletedSuccess : Form
    {
        public DeletedSuccess()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeletedSuccess_Load(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
