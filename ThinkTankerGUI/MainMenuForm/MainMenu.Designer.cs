namespace ThinkTankerGUI.MainMenuForm
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            gradientCus1 = new Custom_Properties.GradientCus();
            usernameLB = new Label();
            pictureboxCus1 = new PictureboxCus();
            ExitB = new Custom_Properties.ButtonCus();
            BrainProbeB = new Custom_Properties.ButtonCus();
            BrainTeasersB = new Custom_Properties.ButtonCus();
            hoverTxt = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonCus1 = new Custom_Properties.ButtonCus();
            buttonCus2 = new Custom_Properties.ButtonCus();
            panel1.SuspendLayout();
            gradientCus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxCus1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 133, 0);
            panel1.Controls.Add(gradientCus1);
            panel1.Controls.Add(ExitB);
            panel1.Controls.Add(BrainProbeB);
            panel1.Controls.Add(BrainTeasersB);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 1051);
            panel1.TabIndex = 0;
            // 
            // gradientCus1
            // 
            gradientCus1.AllowDrop = true;
            gradientCus1.Angle = 90F;
            gradientCus1.BackgroundImageLayout = ImageLayout.None;
            gradientCus1.BottomColor = Color.FromArgb(251, 133, 0);
            gradientCus1.Controls.Add(usernameLB);
            gradientCus1.Controls.Add(pictureboxCus1);
            gradientCus1.Dock = DockStyle.Top;
            gradientCus1.ForeColor = Color.FromArgb(251, 133, 0);
            gradientCus1.Location = new Point(0, 0);
            gradientCus1.Margin = new Padding(3, 4, 3, 4);
            gradientCus1.Name = "gradientCus1";
            gradientCus1.Size = new Size(483, 347);
            gradientCus1.TabIndex = 0;
            gradientCus1.TopColor = Color.FromArgb(245, 47, 87);
            // 
            // usernameLB
            // 
            usernameLB.AutoSize = true;
            usernameLB.BackColor = Color.Transparent;
            usernameLB.Font = new Font("Cascadia Code SemiBold", 23F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLB.ForeColor = Color.FromArgb(255, 247, 237);
            usernameLB.Location = new Point(126, 104);
            usernameLB.Name = "usernameLB";
            usernameLB.Size = new Size(321, 51);
            usernameLB.TabIndex = 1;
            usernameLB.Text = "Welcome! User";
            // 
            // pictureboxCus1
            // 
            pictureboxCus1.BackColor = Color.FromArgb(255, 192, 192);
            pictureboxCus1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            pictureboxCus1.BorderColor = Color.RoyalBlue;
            pictureboxCus1.BorderColor2 = Color.HotPink;
            pictureboxCus1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureboxCus1.BorderSize = 0;
            pictureboxCus1.ErrorImage = null;
            pictureboxCus1.GradientAngle = 50F;
            pictureboxCus1.Image = (Image)resources.GetObject("pictureboxCus1.Image");
            pictureboxCus1.ImageLocation = "";
            pictureboxCus1.InitialImage = null;
            pictureboxCus1.Location = new Point(46, 58);
            pictureboxCus1.Name = "pictureboxCus1";
            pictureboxCus1.Size = new Size(99, 99);
            pictureboxCus1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureboxCus1.TabIndex = 0;
            pictureboxCus1.TabStop = false;
            // 
            // ExitB
            // 
            ExitB.BackColor = Color.PeachPuff;
            ExitB.BackgroundColor = Color.PeachPuff;
            ExitB.BorderColor = Color.PaleVioletRed;
            ExitB.BorderRadius = 35;
            ExitB.BorderSize = 0;
            ExitB.FlatAppearance.BorderSize = 0;
            ExitB.FlatStyle = FlatStyle.Flat;
            ExitB.ForeColor = Color.White;
            ExitB.Image = (Image)resources.GetObject("ExitB.Image");
            ExitB.Location = new Point(200, 622);
            ExitB.Name = "ExitB";
            ExitB.Size = new Size(79, 92);
            ExitB.TabIndex = 2;
            ExitB.TextColor = Color.White;
            ExitB.UseVisualStyleBackColor = false;
            ExitB.Click += ExitB_Click;
            // 
            // BrainProbeB
            // 
            BrainProbeB.BackColor = Color.PeachPuff;
            BrainProbeB.BackgroundColor = Color.PeachPuff;
            BrainProbeB.BorderColor = Color.PaleVioletRed;
            BrainProbeB.BorderRadius = 29;
            BrainProbeB.BorderSize = 0;
            BrainProbeB.FlatAppearance.BorderSize = 0;
            BrainProbeB.FlatStyle = FlatStyle.Flat;
            BrainProbeB.Font = new Font("Impact", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            BrainProbeB.ForeColor = Color.FromArgb(251, 133, 0);
            BrainProbeB.Location = new Point(77, 498);
            BrainProbeB.Margin = new Padding(3, 4, 3, 4);
            BrainProbeB.Name = "BrainProbeB";
            BrainProbeB.Size = new Size(330, 100);
            BrainProbeB.TabIndex = 1;
            BrainProbeB.Text = "Brain Probe";
            BrainProbeB.TextColor = Color.FromArgb(251, 133, 0);
            BrainProbeB.UseVisualStyleBackColor = false;
            BrainProbeB.Click += BrainProbeB_Click;
            BrainProbeB.MouseLeave += BrainProbeB_MouseLeave;
            BrainProbeB.MouseHover += BrainProbeB_MouseHover;
            // 
            // BrainTeasersB
            // 
            BrainTeasersB.BackColor = Color.PeachPuff;
            BrainTeasersB.BackgroundColor = Color.PeachPuff;
            BrainTeasersB.BorderColor = Color.PaleVioletRed;
            BrainTeasersB.BorderRadius = 29;
            BrainTeasersB.BorderSize = 0;
            BrainTeasersB.FlatAppearance.BorderSize = 0;
            BrainTeasersB.FlatStyle = FlatStyle.Flat;
            BrainTeasersB.Font = new Font("Impact", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            BrainTeasersB.ForeColor = Color.FromArgb(251, 133, 0);
            BrainTeasersB.Location = new Point(77, 355);
            BrainTeasersB.Margin = new Padding(3, 4, 3, 4);
            BrainTeasersB.Name = "BrainTeasersB";
            BrainTeasersB.Size = new Size(330, 100);
            BrainTeasersB.TabIndex = 0;
            BrainTeasersB.Text = "Brain Teasers";
            BrainTeasersB.TextColor = Color.FromArgb(251, 133, 0);
            BrainTeasersB.UseVisualStyleBackColor = false;
            BrainTeasersB.Click += BrainTeasersB_Click;
            BrainTeasersB.MouseLeave += BrainTeasersB_MouseLeave_1;
            BrainTeasersB.MouseHover += BrainTeasersB_MouseHover_1;
            // 
            // hoverTxt
            // 
            hoverTxt.AutoSize = true;
            hoverTxt.Location = new Point(606, 219);
            hoverTxt.Name = "hoverTxt";
            hoverTxt.Size = new Size(0, 20);
            hoverTxt.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(510, 396);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(853, 335);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(399, 397);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // buttonCus1
            // 
            buttonCus1.BackColor = Color.PeachPuff;
            buttonCus1.BackgroundColor = Color.PeachPuff;
            buttonCus1.BorderColor = Color.PaleVioletRed;
            buttonCus1.BorderRadius = 29;
            buttonCus1.BorderSize = 0;
            buttonCus1.FlatAppearance.BorderSize = 0;
            buttonCus1.FlatStyle = FlatStyle.Flat;
            buttonCus1.Font = new Font("Impact", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCus1.ForeColor = Color.FromArgb(251, 133, 0);
            buttonCus1.Location = new Point(546, 355);
            buttonCus1.Margin = new Padding(3, 4, 3, 4);
            buttonCus1.Name = "buttonCus1";
            buttonCus1.Size = new Size(330, 100);
            buttonCus1.TabIndex = 4;
            buttonCus1.Text = "Tower Of Hanoi";
            buttonCus1.TextColor = Color.FromArgb(251, 133, 0);
            buttonCus1.UseVisualStyleBackColor = false;
            buttonCus1.Click += buttonCus1_Click;
            // 
            // buttonCus2
            // 
            buttonCus2.BackColor = Color.PeachPuff;
            buttonCus2.BackgroundColor = Color.PeachPuff;
            buttonCus2.BorderColor = Color.PaleVioletRed;
            buttonCus2.BorderRadius = 29;
            buttonCus2.BorderSize = 0;
            buttonCus2.FlatAppearance.BorderSize = 0;
            buttonCus2.FlatStyle = FlatStyle.Flat;
            buttonCus2.Font = new Font("Impact", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCus2.ForeColor = Color.FromArgb(251, 133, 0);
            buttonCus2.Location = new Point(901, 355);
            buttonCus2.Margin = new Padding(3, 4, 3, 4);
            buttonCus2.Name = "buttonCus2";
            buttonCus2.Size = new Size(330, 100);
            buttonCus2.TabIndex = 5;
            buttonCus2.Text = "Matching Game";
            buttonCus2.TextColor = Color.FromArgb(251, 133, 0);
            buttonCus2.UseVisualStyleBackColor = false;
            buttonCus2.Click += buttonCus2_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 71);
            ClientSize = new Size(1264, 744);
            Controls.Add(buttonCus2);
            Controls.Add(buttonCus1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(hoverTxt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            gradientCus1.ResumeLayout(false);
            gradientCus1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxCus1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Custom_Properties.ButtonCus BrainProbeB;
        private Custom_Properties.ButtonCus BrainTeasersB;
        private Custom_Properties.ButtonCus ExitB;
        private Custom_Properties.GradientCus gradientCus1;
        private PictureboxCus pictureboxCus1;
        private Label usernameLB;
        private Label hoverTxt;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Custom_Properties.ButtonCus buttonCus1;
        private Custom_Properties.ButtonCus buttonCus2;
    }
}