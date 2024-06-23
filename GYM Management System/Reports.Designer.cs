namespace GYM_Management_System
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label11 = new Label();
            label12 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Century Gothic", 24F);
            label11.ForeColor = Color.DarkOliveGreen;
            label11.ImeMode = ImeMode.NoControl;
            label11.Location = new Point(405, 56);
            label11.Name = "label11";
            label11.Size = new Size(323, 49);
            label11.TabIndex = 45;
            label11.Text = "Reports Section";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AccessibleRole = AccessibleRole.TitleBar;
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            label12.ForeColor = Color.DarkGoldenrod;
            label12.ImageAlign = ContentAlignment.MiddleRight;
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(441, 9);
            label12.Name = "label12";
            label12.Size = new Size(251, 47);
            label12.TabIndex = 44;
            label12.Text = "AWEIS-GYM";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.PaleVioletRed;
            guna2Button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.BorderColor = Color.PaleVioletRed;
            guna2Button1.HoverState.FillColor = Color.Black;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageSize = new Size(50, 50);
            guna2Button1.Location = new Point(424, 332);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(284, 76);
            guna2Button1.TabIndex = 46;
            guna2Button1.Text = "Show The Reoprt";
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.None;
            guna2Button3.CustomizableEdges = customizableEdges3;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(507, 681);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button3.Size = new Size(119, 32);
            guna2Button3.TabIndex = 47;
            guna2Button3.Text = "Back";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1121, 725);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button1);
            Controls.Add(label11);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Text = "Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label12;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}