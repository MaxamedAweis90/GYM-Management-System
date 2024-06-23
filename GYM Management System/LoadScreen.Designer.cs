namespace GYM_Management_System
{
    partial class LoadScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadScreen));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            loadline = new Guna.UI2.WinForms.Guna2Panel();
            guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            PayBtn = new Guna.UI2.WinForms.Guna2TileButton();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            guna2Panel1.SuspendLayout();
            loadline.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.YellowGreen;
            label1.Location = new Point(182, 140);
            label1.Name = "label1";
            label1.Size = new Size(418, 93);
            label1.TabIndex = 3;
            label1.Text = "Loading...";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.Cursor = Cursors.Hand;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(1, -4);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(68, 66);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 2;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.Click += guna2CirclePictureBox1_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(loadline);
            guna2Panel1.Controls.Add(PayBtn);
            guna2Panel1.CustomizableEdges = customizableEdges8;
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(1, 370);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2Panel1.Size = new Size(772, 23);
            guna2Panel1.TabIndex = 9;
            // 
            // loadline
            // 
            loadline.Controls.Add(guna2TileButton1);
            loadline.CustomizableEdges = customizableEdges4;
            loadline.FillColor = Color.Gold;
            loadline.Location = new Point(-2, 0);
            loadline.Name = "loadline";
            loadline.ShadowDecoration.CustomizableEdges = customizableEdges5;
            loadline.Size = new Size(114, 23);
            loadline.TabIndex = 9;
            loadline.Paint += loadline_Paint;
            // 
            // guna2TileButton1
            // 
            guna2TileButton1.AutoRoundedCorners = true;
            guna2TileButton1.BackColor = Color.Transparent;
            guna2TileButton1.BackgroundImageLayout = ImageLayout.None;
            guna2TileButton1.BorderColor = Color.LightGray;
            guna2TileButton1.BorderRadius = 16;
            guna2TileButton1.BorderThickness = 2;
            guna2TileButton1.Cursor = Cursors.Hand;
            guna2TileButton1.CustomBorderColor = Color.Transparent;
            guna2TileButton1.CustomizableEdges = customizableEdges2;
            guna2TileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2TileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2TileButton1.FillColor = Color.White;
            guna2TileButton1.FocusedColor = Color.Gold;
            guna2TileButton1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2TileButton1.ForeColor = Color.Black;
            guna2TileButton1.HoverState.FillColor = Color.Gold;
            guna2TileButton1.ImeMode = ImeMode.NoControl;
            guna2TileButton1.Location = new Point(869, 12);
            guna2TileButton1.Name = "guna2TileButton1";
            guna2TileButton1.PressedColor = Color.DarkGoldenrod;
            guna2TileButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2TileButton1.Size = new Size(139, 35);
            guna2TileButton1.TabIndex = 1;
            guna2TileButton1.Text = "Payment";
            guna2TileButton1.UseTransparentBackground = true;
            // 
            // PayBtn
            // 
            PayBtn.AutoRoundedCorners = true;
            PayBtn.BackColor = Color.Transparent;
            PayBtn.BackgroundImageLayout = ImageLayout.None;
            PayBtn.BorderColor = Color.LightGray;
            PayBtn.BorderRadius = 16;
            PayBtn.BorderThickness = 2;
            PayBtn.Cursor = Cursors.Hand;
            PayBtn.CustomBorderColor = Color.Transparent;
            PayBtn.CustomizableEdges = customizableEdges6;
            PayBtn.DisabledState.BorderColor = Color.DarkGray;
            PayBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            PayBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            PayBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            PayBtn.FillColor = Color.White;
            PayBtn.FocusedColor = Color.Gold;
            PayBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PayBtn.ForeColor = Color.Black;
            PayBtn.HoverState.FillColor = Color.Gold;
            PayBtn.ImeMode = ImeMode.NoControl;
            PayBtn.Location = new Point(869, 12);
            PayBtn.Name = "PayBtn";
            PayBtn.PressedColor = Color.DarkGoldenrod;
            PayBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            PayBtn.Size = new Size(139, 35);
            PayBtn.TabIndex = 1;
            PayBtn.Text = "Payment";
            PayBtn.UseTransparentBackground = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.YellowGreen;
            label2.Location = new Point(12, 332);
            label2.Name = "label2";
            label2.Size = new Size(219, 21);
            label2.TabIndex = 10;
            label2.Text = "Opening The System......";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 7;
            timer1.Tick += timer1_Tick;
            // 
            // LoadScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(773, 392);
            Controls.Add(label2);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadScreen";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadScreen";
            Load += LoadScreen_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            guna2Panel1.ResumeLayout(false);
            loadline.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TileButton PayBtn;
        private Guna.UI2.WinForms.Guna2Panel loadline;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}