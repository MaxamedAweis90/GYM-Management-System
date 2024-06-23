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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Text.RegularExpressions;


namespace GYM_Management_System
{
    public partial class AddMembers : Form
    {
        public AddMembers()
        {
            InitializeComponent();


            // Attach TextChanged event handlers
            NameTb.TextChanged += new EventHandler(NameTb_TextChanged);
            PhoneTb.TextChanged += new EventHandler(PhoneTb_TextChanged);
            AmountTb.TextChanged += new EventHandler(AmountTb_TextChanged);
            AgeTb.TextChanged += new EventHandler(AgeTb_TextChanged);
        }
        public void ClearAndFocusAgeTb()
        {
            AgeTb.Text = "";
            AgeTb.Focus();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Asli-pc;Initial Catalog=GYM_Managing;User ID=sa;Password=123;Integrated Security=SSPI;");
        //  SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MI1ODN0;Initial Catalog=RegistrationForm1;Integrated Security=True;Trust Server Certificate=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void AddMembers_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(AgeTb.Text, out int age) && age < 12)
            {
                TooYoung too = new TooYoung();
                too.Show();
            }
            else if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "")
            {
                MissingInfo m = new MissingInfo();
                m.Show();
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into MemberTbl values('" + NameTb.Text + "','" + PhoneTb.Text + "','" + GenderCb.Text.ToString() + "','" + AgeTb.Text + "','" + AmountTb.Text + "','" + TimingCb.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    AddedSuccess add = new AddedSuccess();
                    add.Show();
                    Con.Close();
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    AgeTb.Text = "";
                    AmountTb.Text = "";
                    GenderCb.Text = "";
                    TimingCb.Text = "";

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }



                //edit
                /* con.Open();
                string query = "INSERT INTO student VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                student std = new student();
                std.show();
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";


                MessageBox.Show("waa ku guuleysatay !");*/
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {
        }
        private void label16_Click(object sender, EventArgs e)
        {
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            GenderCb.Text = "";
            TimingCb.Text = "";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
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

        private void TimingCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimingCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://maxamedaweis90.github.io/AWEIS-GYM/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void AgeTb_TextChanged(object sender, EventArgs e)
        {
            // Allow only digits
            string currentText = AgeTb.Text;
            int selectionStart = AgeTb.SelectionStart;
            AgeTb.Text = Regex.Replace(currentText, @"[^\d]", "");
            AgeTb.SelectionStart = Math.Min(selectionStart, AgeTb.Text.Length);
        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {
            // Allow only digits
            string currentText = PhoneTb.Text;
            int selectionStart = PhoneTb.SelectionStart;
            PhoneTb.Text = Regex.Replace(currentText, @"[^\d]", "");
            PhoneTb.SelectionStart = Math.Min(selectionStart, PhoneTb.Text.Length);
        }

        private void AmountTb_TextChanged(object sender, EventArgs e)
        {
            // Allow only digits
            string currentText = AmountTb.Text;
            int selectionStart = AmountTb.SelectionStart;
            AmountTb.Text = Regex.Replace(currentText, @"[^\d]", "");
            AmountTb.SelectionStart = Math.Min(selectionStart, AmountTb.Text.Length);
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            // Allow only letters and whitespace
            string currentText = NameTb.Text;
            int selectionStart = NameTb.SelectionStart;
            NameTb.Text = Regex.Replace(currentText, @"[^a-zA-Z\s]", "");
            NameTb.SelectionStart = Math.Min(selectionStart, NameTb.Text.Length);
        }

    }
}
