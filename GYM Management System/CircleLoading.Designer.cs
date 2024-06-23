namespace GYM_Management_System
{
    partial class CircleLoading
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleLoading));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            MyProcress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label2 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            MyProcress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 360);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 2;
            label1.Text = "Loading....";
            label1.Click += label1_Click;
            // 
            // MyProcress
            // 
            MyProcress.Controls.Add(label2);
            MyProcress.Controls.Add(guna2CirclePictureBox1);
            MyProcress.FillColor = Color.FromArgb(200, 213, 218, 223);
            MyProcress.FillThickness = 10;
            MyProcress.Font = new Font("Segoe UI", 12F);
            MyProcress.ForeColor = Color.White;
            MyProcress.Location = new Point(233, 37);
            MyProcress.Minimum = 0;
            MyProcress.Name = "MyProcress";
            MyProcress.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            MyProcress.ProgressColor = Color.Crimson;
            MyProcress.ProgressColor2 = Color.Crimson;
            MyProcress.ProgressThickness = 10;
            MyProcress.ShadowDecoration.CustomizableEdges = customizableEdges4;
            MyProcress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            MyProcress.Size = new Size(311, 311);
            MyProcress.TabIndex = 4;
            MyProcress.Text = "guna2CircleProgressBar1";
            MyProcress.ValueChanged += MyProcress_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(83, 225);
            label2.Name = "label2";
            label2.Size = new Size(144, 27);
            label2.TabIndex = 5;
            label2.Text = "AWEIS-GYM";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.Cursor = Cursors.Hand;
            guna2CirclePictureBox1.FillColor = Color.Transparent;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(45, 59);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(221, 196);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 1;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 12;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 7;
            timer2.Tick += timer2_Tick;
            // 
            // CircleLoading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 55, 89);
            ClientSize = new Size(773, 392);
            Controls.Add(MyProcress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CircleLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CircleLoading";
            Load += CircleLoading_Load;
            MyProcress.ResumeLayout(false);
            MyProcress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public Label label1;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2CircleProgressBar MyProcress;
        public Label label2;
        private System.Windows.Forms.Timer timer2;
    }
}