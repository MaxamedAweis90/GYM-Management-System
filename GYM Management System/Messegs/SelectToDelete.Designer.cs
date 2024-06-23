namespace GYM_Management_System
{
    partial class SelectToDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ClickOkey = new Guna.UI2.WinForms.Guna2Button();
            deleteMsg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            deleteMsg1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Gray;
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.Location = new Point(0, 123);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(320, 22);
            guna2GradientPanel1.TabIndex = 5;
            guna2GradientPanel1.Paint += guna2GradientPanel1_Paint;
            // 
            // ClickOkey
            // 
            ClickOkey.CustomizableEdges = customizableEdges3;
            ClickOkey.DisabledState.BorderColor = Color.DarkGray;
            ClickOkey.DisabledState.CustomBorderColor = Color.DarkGray;
            ClickOkey.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ClickOkey.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ClickOkey.FillColor = Color.Gray;
            ClickOkey.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClickOkey.ForeColor = Color.Gainsboro;
            ClickOkey.Location = new Point(125, 67);
            ClickOkey.Name = "ClickOkey";
            ClickOkey.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClickOkey.Size = new Size(77, 34);
            ClickOkey.TabIndex = 4;
            ClickOkey.Text = "Okey";
            ClickOkey.Click += guna2Button1_Click;
            // 
            // deleteMsg
            // 
            deleteMsg.BackColor = Color.Transparent;
            deleteMsg.Location = new Point(0, 0);
            deleteMsg.Name = "deleteMsg";
            deleteMsg.Size = new Size(3, 2);
            deleteMsg.TabIndex = 6;
            deleteMsg.Text = null;
            // 
            // deleteMsg1
            // 
            deleteMsg1.BackColor = Color.Transparent;
            deleteMsg1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteMsg1.Location = new Point(20, 35);
            deleteMsg1.Name = "deleteMsg1";
            deleteMsg1.Size = new Size(287, 26);
            deleteMsg1.TabIndex = 7;
            deleteMsg1.Text = "Select The Member To Be Deleted";
            deleteMsg1.Click += deleteMsg1_Click;
            // 
            // SelectToDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 145);
            Controls.Add(deleteMsg1);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(ClickOkey);
            Controls.Add(deleteMsg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectToDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectToDelete";
            Load += SelectToDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button ClickOkey;
        private Guna.UI2.WinForms.Guna2HtmlLabel deleteMsg;
        private Guna.UI2.WinForms.Guna2HtmlLabel deleteMsg1;
    }
}