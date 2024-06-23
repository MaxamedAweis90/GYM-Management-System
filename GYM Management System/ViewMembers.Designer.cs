using System.Windows.Forms;

namespace GYM_Management_System
{
    partial class ViewMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        // Form1.Designer.cs
        private System.Windows.Forms.DataGridView dataGridView1;

// In InitializeComponent method

        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
           
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            SearchName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            MemberSDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(488, 46);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 12;
            label2.Text = "Members List";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.TitleBar;
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(495, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 10;
            label1.Text = "AWEIS-GYM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // SearchName
            // 
            SearchName.Anchor = AnchorStyles.None;
            SearchName.BackColor = Color.Transparent;
            SearchName.BorderColor = Color.Transparent;
            SearchName.CustomizableEdges = customizableEdges1;
            SearchName.DefaultText = "";
            SearchName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchName.FillColor = SystemColors.ControlLight;
            SearchName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchName.Font = new Font("Century Gothic", 12F);
            SearchName.ForeColor = Color.MidnightBlue;
            SearchName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchName.Location = new Point(300, 101);
            SearchName.Margin = new Padding(4, 5, 4, 5);
            SearchName.Name = "SearchName";
            SearchName.PasswordChar = '\0';
            SearchName.PlaceholderForeColor = Color.DarkSeaGreen;
            SearchName.PlaceholderText = "Enter Name";
            SearchName.SelectedText = "";
            SearchName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchName.Size = new Size(281, 44);
            SearchName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            SearchName.TabIndex = 40;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.None;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(579, 101);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(119, 44);
            guna2Button1.TabIndex = 41;
            guna2Button1.Text = "Search";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.None;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(704, 101);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(119, 44);
            guna2Button2.TabIndex = 42;
            guna2Button2.Text = "Refresh";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button3
            // 
            guna2Button3.Anchor = AnchorStyles.None;
            guna2Button3.CustomizableEdges = customizableEdges7;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(510, 681);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button3.Size = new Size(119, 32);
            guna2Button3.TabIndex = 43;
            guna2Button3.Text = "Back";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // MemberSDGV
            // 
            MemberSDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            MemberSDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MemberSDGV.Anchor = AnchorStyles.None;
            MemberSDGV.BackgroundColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MemberSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MemberSDGV.ColumnHeadersHeight = 30;
            MemberSDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MemberSDGV.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MemberSDGV.DefaultCellStyle = dataGridViewCellStyle3;
            MemberSDGV.GridColor = Color.FromArgb(231, 229, 255);
            MemberSDGV.Location = new Point(44, 166);
            MemberSDGV.Name = "MemberSDGV";
            MemberSDGV.RowHeadersVisible = false;
            MemberSDGV.RowHeadersWidth = 51;
            MemberSDGV.RowTemplate.Height = 25;
            MemberSDGV.Size = new Size(1039, 495);
            MemberSDGV.TabIndex = 39;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            MemberSDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            MemberSDGV.ThemeStyle.BackColor = Color.FromArgb(231, 229, 255);
            MemberSDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            MemberSDGV.ThemeStyle.HeaderStyle.BackColor = Color.Crimson;
            MemberSDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            MemberSDGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberSDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            MemberSDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MemberSDGV.ThemeStyle.HeaderStyle.Height = 30;
            MemberSDGV.ThemeStyle.ReadOnly = false;
            MemberSDGV.ThemeStyle.RowsStyle.BackColor = Color.Crimson;
            MemberSDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MemberSDGV.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MemberSDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(128, 128, 255);
            MemberSDGV.ThemeStyle.RowsStyle.Height = 25;
            MemberSDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Crimson;
            MemberSDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(255, 255, 128);
            MemberSDGV.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // ViewMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1121, 725);
            Controls.Add(guna2Button3);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(SearchName);
            Controls.Add(MemberSDGV);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMembers";
            Load += ViewMembers_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox SearchName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2DataGridView MemberSDGV;
    }
}