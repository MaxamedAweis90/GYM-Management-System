using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Management_System
{
    public partial class ViewMembers : Form
    {


        public ViewMembers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=Asli-pc;Initial Catalog=GYM_Managing;User ID=sa;Password=l23;Integrated Security=SSPI;");

        private void filterByName()
        {
            Con.Open();
            string query = "select * from MemberTbl where MName = '" + SearchName.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];

            Con.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            filterByName();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            populate();
            SearchName.Text = "";
        }
    }
}
