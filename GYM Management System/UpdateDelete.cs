using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GYM_Management_System.Messegs;
using System.Diagnostics;

namespace GYM_Management_System
{
    public partial class UpdateDelete : Form
    {


        public UpdateDelete()
        {
            InitializeComponent();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=Asli-pc;Initial Catalog=GYM_Managing;User ID=sa;Password=l23;Integrated Security=SSPI;");

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

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            TimingCb.Text = "";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingCb.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();


        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenderCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                SelectToDelete D = new SelectToDelete();
                D.Show();
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from MemberTbl where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    DeletedSuccess DS = new DeletedSuccess();
                    DS.Show();
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" || AmountTb.Text == "" || GenderCb.Text == "" || TimingCb.Text == "")
            {
                SelectToUpdate Up = new SelectToUpdate();
                Up.Show();
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update MemberTbl set MName='" + NameTb.Text + "',MPhone='" + PhoneTb.Text + "',MGen='" + GenderCb.Text + "',MAge='" + AgeTb.Text + "',MAmount='" + AmountTb.Text + "',MTiming='" + TimingCb.Text + "' where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    UpdatedSuccess US = new UpdatedSuccess();
                    US.Show();
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://maxamedaweis90.github.io/AWEIS-GYM/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
