using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYM_Management_System.Messegs;

namespace GYM_Management_System
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=Asli-pc;Initial Catalog=GYM_Managing;User ID=sa;Password=l23;Integrated Security=SSPI;");

        private void FillName()
        {
            Con.Open();
            using (SqlCommand cmd = new SqlCommand("select MName from MemberTbl", Con))
            {
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    NameCb.ValueMember = "MName";
                    NameCb.DataSource = dt;
                }
            }
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName(); // Ensure that this method is called to populate the combo box when the form loads
            populate();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();


        }

        private void filterByName()
        {
            Con.Open();
            string query = "select * from PaymentTbl where PMember = '" + SearchName.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //NameTb.Text = "";
            AmountTb.Text = "";
        }



        private void AmountTb_TextChanged(object sender, EventArgs e)
        {

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


        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (NameCb.Text == "" || AmountTb.Text == "")
            {
                MissingInfo m = new MissingInfo();
                m.Show();
            }
            else
            {
                string payperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(" select count(*) from PaymentTbl where PMember ='" + NameCb.SelectedValue.ToString() + "' and PMonth = '" + payperiode + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    PayedAlready payed = new PayedAlready();
                    payed.Show();
                }
                else
                {
                    string query = "insert into PaymentTbl values('" + payperiode + "', '" + NameCb.SelectedValue.ToString() + "', '" + AmountTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PayedSuccess payeds = new PayedSuccess();
                    payeds.Show();

                }
                Con.Close();
                populate();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            filterByName();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            populate();
            SearchName.Text = "";
        }
    }
}
