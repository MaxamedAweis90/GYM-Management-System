namespace GYM_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
                if (userTxtBox.Text == "" || passTxtBox.Text == "")
            {
                MissingInfo m = new MissingInfo();
                m.Show();
            }
            else

            if (MainClass.isValidUser(userTxtBox.Text, passTxtBox.Text) == false)
            {
                loginFail.Show("Waxaad Galisay Username amd password qaldan");
                
                userTxtBox.Clear();
                passTxtBox.Clear();
                userTxtBox.Focus();
                return;
            }
            else
            {
                this.Hide();
                LoadScreen loadScreen = new LoadScreen();
                loadScreen.Show();
            }


        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (passTxtBox.PasswordChar == '*')
            {
                guna2Button4.BringToFront();
                passTxtBox.PasswordChar = '\0';
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (passTxtBox.PasswordChar == '\0')
            {
                guna2Button3.BringToFront();
                passTxtBox.PasswordChar = '*';
            }
        }
    }
}
