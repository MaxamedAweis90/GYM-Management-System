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
    public partial class TooYoung : Form
    {
        public TooYoung()
        {
            InitializeComponent();

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TooYoung_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddMembers addMembers = Application.OpenForms.OfType<AddMembers>().FirstOrDefault();

            if (addMembers != null)
            {
                // Call the method in Form1 to clear and focus AgeTb
                addMembers.ClearAndFocusAgeTb();
            }

            //AgeTb.Text = "";
            //AgeTb.Focus();
        }
    }
}
