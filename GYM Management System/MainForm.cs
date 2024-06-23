using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms; // Add this to import Guna.UI2.WinForms


namespace GYM_Management_System
{
    public partial class MainForm : Form
    {
        private Stack<Form> formHistory;

        public MainForm()
        {
            InitializeComponent();
            formHistory = new Stack<Form>();
        }

        private void SetDefaultButtonStates()
        {
            Color defaultColor = Color.BlanchedAlmond; // Specific color

            AddBtn.BackColor = defaultColor; // Default color
            AddBtn.FillColor = defaultColor;
            AddBtn.CustomBorderColor = Color.Navy;
            AddBtn.BorderThickness = 0;
            // Default border

            ViewBtn.BackColor = defaultColor; // Default color
            ViewBtn.FillColor = defaultColor;
            ViewBtn.CustomBorderColor = Color.Navy;
            ViewBtn.BorderThickness = 0;    // Default border

            UpdateDeleteBtn.BackColor = defaultColor; // Default color
            UpdateDeleteBtn.FillColor = defaultColor;
            UpdateDeleteBtn.CustomBorderColor = Color.Navy;
            UpdateDeleteBtn.BorderThickness = 0;    // Default border

            PayBtn.BackColor = defaultColor; // Default color
            PayBtn.FillColor = defaultColor;
            PayBtn.CustomBorderColor = Color.Navy;
            PayBtn.BorderThickness = 0;    // Default border

            ReportsBtn.BackColor = defaultColor; // Default color
            ReportsBtn.FillColor = defaultColor;
            ReportsBtn.CustomBorderColor = Color.Navy;
            ReportsBtn.BorderThickness = 0;
        }

        private void SetCheckedButtonState(Guna2TileButton checkedButton)
        {
            SetDefaultButtonStates();
            checkedButton.BackColor = Color.LightBlue;  // Example checked color
            checkedButton.FillColor = Color.LightBlue;
            checkedButton.CustomBorderColor = Color.Gold;
            checkedButton.BorderThickness = 1; // Example border size for checked state
        }

        /* private void SetDefaultControlState()
         {
             minOp.BorderThickness = 0;
             maxOp.BorderThickness = 0;
             CloseOp.BorderThickness = 0;
         }*/

        /*private void SetCheckedControlState(Guna2ControlBox checkedControl)
        {
            SetDefaultControlState();
            checkedControl.BorderThickness = 2;
        }*/

        public void loadform(Form newForm)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                // Get the current form
                Form currentForm = this.mainpanel.Controls[0] as Form;
                if (currentForm != null)
                {
                    // Add the current form to the history stack
                    formHistory.Push(currentForm);
                }

                // Remove the current form from the panel
                this.mainpanel.Controls.RemoveAt(0);
            }

            if (newForm != null)
            {
                newForm.TopLevel = false;
                newForm.Dock = DockStyle.Fill;
                newForm.FormBorderStyle = FormBorderStyle.None; // Optional: removes the form border
                this.mainpanel.Controls.Add(newForm);
                this.mainpanel.Tag = newForm;
                newForm.Show();
            }
        }

        public void NavigateBack()
        {
            if (formHistory.Count > 0)
            {
                // Get the last form from the history stack
                Form previousForm = formHistory.Pop();

                // Load the previous form
                loadform(previousForm);
            }
        }



        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (formHistory.Count > 0)
            {
                // Get the last form from the history stack
                Form previousForm = formHistory.Pop();

                // Load the previous form
                loadform(previousForm);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            loadform(new AddMembers());
            SetCheckedButtonState(AddBtn);
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            loadform(new ViewMembers());
            SetCheckedButtonState(ViewBtn);
        }

        private void UpdateDeleteBtn_Click(object sender, EventArgs e)
        {
            loadform(new UpdateDelete());
            SetCheckedButtonState(UpdateDeleteBtn);
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            loadform(new Payment());
            SetCheckedButtonState(PayBtn);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CloseOp_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void minOp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void maxOp_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }


        }

        private void Guna2HtmlLabel1_Click(object sender, EventArgs e)
        {



            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://maxamedaweis90.github.io/AWEIS-GYM/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            loadform(new Reports());
            SetCheckedButtonState(ReportsBtn);
        }

        private void DashPic_Click(object sender, EventArgs e)
        {

        }
    }
}
