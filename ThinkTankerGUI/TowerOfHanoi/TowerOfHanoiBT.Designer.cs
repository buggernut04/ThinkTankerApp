namespace ThinkTankerGUI.TowerOfHanoi
{
    partial class TowerOfHanoiBT
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
            gradientCus1 = new Custom_Properties.GradientCus();
            RestartBTN = new Custom_Properties.ButtonCus();
            BrainTeasersB = new Custom_Properties.ButtonCus();
            usernameLB = new Label();
            pictureboxCus1 = new PictureboxCus();
            panel1 = new Panel();
            Pole1 = new PictureBox();
            Pole2 = new PictureBox();
            Pole3 = new PictureBox();
            Disk1 = new PictureBox();
            Disk2 = new PictureBox();
            Disk3 = new PictureBox();
            gradientCus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxCus1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pole1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pole2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pole3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk3).BeginInit();
            SuspendLayout();
            // 
            // gradientCus1
            // 
            gradientCus1.AllowDrop = true;
            gradientCus1.Angle = 90F;
            gradientCus1.BackgroundImageLayout = ImageLayout.None;
            gradientCus1.BottomColor = Color.FromArgb(251, 133, 0);
            gradientCus1.Controls.Add(RestartBTN);
            gradientCus1.Controls.Add(BrainTeasersB);
            gradientCus1.Controls.Add(usernameLB);
            gradientCus1.Controls.Add(pictureboxCus1);
            gradientCus1.Dock = DockStyle.Top;
            gradientCus1.ForeColor = Color.FromArgb(251, 133, 0);
            gradientCus1.Location = new Point(0, 0);
            gradientCus1.Margin = new Padding(3, 4, 3, 4);
            gradientCus1.Name = "gradientCus1";
            gradientCus1.Size = new Size(291, 602);
            gradientCus1.TabIndex = 1;
            gradientCus1.TopColor = Color.FromArgb(245, 47, 87);
            // 
            // RestartBTN
            // 
            RestartBTN.BackColor = Color.PeachPuff;
            RestartBTN.BackgroundColor = Color.PeachPuff;
            RestartBTN.BorderColor = Color.PaleVioletRed;
            RestartBTN.BorderRadius = 29;
            RestartBTN.BorderSize = 0;
            RestartBTN.FlatAppearance.BorderSize = 0;
            RestartBTN.FlatStyle = FlatStyle.Flat;
            RestartBTN.Font = new Font("Impact", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            RestartBTN.ForeColor = Color.FromArgb(251, 133, 0);
            RestartBTN.Location = new Point(17, 182);
            RestartBTN.Margin = new Padding(3, 4, 3, 4);
            RestartBTN.Name = "RestartBTN";
            RestartBTN.Size = new Size(258, 62);
            RestartBTN.TabIndex = 2;
            RestartBTN.Text = "Restart";
            RestartBTN.TextColor = Color.FromArgb(251, 133, 0);
            RestartBTN.UseVisualStyleBackColor = false;
            RestartBTN.Click += RestartBTN_Click;
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
            BrainTeasersB.Location = new Point(17, 268);
            BrainTeasersB.Margin = new Padding(3, 4, 3, 4);
            BrainTeasersB.Name = "BrainTeasersB";
            BrainTeasersB.Size = new Size(258, 62);
            BrainTeasersB.TabIndex = 1;
            BrainTeasersB.Text = "Back";
            BrainTeasersB.TextColor = Color.FromArgb(251, 133, 0);
            BrainTeasersB.UseVisualStyleBackColor = false;
            BrainTeasersB.Click += BrainTeasersB_Click;
            // 
            // usernameLB
            // 
            usernameLB.AutoSize = true;
            usernameLB.BackColor = Color.Transparent;
            usernameLB.Font = new Font("Cascadia Code SemiBold", 23F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLB.ForeColor = Color.FromArgb(255, 247, 237);
            usernameLB.Location = new Point(78, 30);
            usernameLB.Name = "usernameLB";
            usernameLB.Size = new Size(275, 51);
            usernameLB.TabIndex = 1;
            usernameLB.Text = "Loren Ipsum";
            // 
            // pictureboxCus1
            // 
            pictureboxCus1.BackColor = Color.FromArgb(255, 192, 192);
            pictureboxCus1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            pictureboxCus1.BorderColor = Color.RoyalBlue;
            pictureboxCus1.BorderColor2 = Color.HotPink;
            pictureboxCus1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureboxCus1.BorderSize = 0;
            pictureboxCus1.GradientAngle = 50F;
            pictureboxCus1.Location = new Point(14, 18);
            pictureboxCus1.Margin = new Padding(3, 4, 3, 4);
            pictureboxCus1.Name = "pictureboxCus1";
            pictureboxCus1.Size = new Size(57, 57);
            pictureboxCus1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxCus1.TabIndex = 0;
            pictureboxCus1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 133, 0);
            panel1.Controls.Add(gradientCus1);
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 602);
            panel1.TabIndex = 0;
            // 
            // Pole1
            // 
            Pole1.BackColor = Color.Chocolate;
            Pole1.Location = new Point(453, 318);
            Pole1.Margin = new Padding(3, 4, 3, 4);
            Pole1.Name = "Pole1";
            Pole1.Size = new Size(18, 131);
            Pole1.TabIndex = 1;
            Pole1.TabStop = false;
            // 
            // Pole2
            // 
            Pole2.BackColor = Color.Chocolate;
            Pole2.Location = new Point(644, 318);
            Pole2.Margin = new Padding(3, 4, 3, 4);
            Pole2.Name = "Pole2";
            Pole2.Size = new Size(18, 131);
            Pole2.TabIndex = 2;
            Pole2.TabStop = false;
            Pole2.Click += Pole2_Click;
            // 
            // Pole3
            // 
            Pole3.BackColor = Color.Chocolate;
            Pole3.Location = new Point(848, 318);
            Pole3.Margin = new Padding(3, 4, 3, 4);
            Pole3.Name = "Pole3";
            Pole3.Size = new Size(18, 131);
            Pole3.TabIndex = 3;
            Pole3.TabStop = false;
            // 
            // Disk1
            // 
            Disk1.BackColor = Color.Red;
            Disk1.Location = new Point(394, 423);
            Disk1.Margin = new Padding(3, 4, 3, 4);
            Disk1.Name = "Disk1";
            Disk1.Size = new Size(138, 26);
            Disk1.TabIndex = 4;
            Disk1.TabStop = false;
            Disk1.Tag = "Disk";
            Disk1.Click += Disk1_Click;
            // 
            // Disk2
            // 
            Disk2.BackColor = Color.Cyan;
            Disk2.Location = new Point(406, 398);
            Disk2.Margin = new Padding(3, 4, 3, 4);
            Disk2.Name = "Disk2";
            Disk2.Size = new Size(109, 26);
            Disk2.TabIndex = 5;
            Disk2.TabStop = false;
            Disk2.Tag = "Disk";
            // 
            // Disk3
            // 
            Disk3.BackColor = Color.Yellow;
            Disk3.Location = new Point(422, 371);
            Disk3.Margin = new Padding(3, 4, 3, 4);
            Disk3.Name = "Disk3";
            Disk3.Size = new Size(79, 26);
            Disk3.TabIndex = 6;
            Disk3.TabStop = false;
            Disk3.Tag = "Disk";
            // 
            // TowerOfHanoiBT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 71);
            ClientSize = new Size(1010, 538);
            Controls.Add(Disk3);
            Controls.Add(Disk2);
            Controls.Add(Disk1);
            Controls.Add(Pole3);
            Controls.Add(Pole2);
            Controls.Add(Pole1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1028, 585);
            MinimumSize = new Size(1028, 585);
            Name = "TowerOfHanoiBT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TowerOfHanoi";
            Load += TowerOfHanoiBT_Load;
            gradientCus1.ResumeLayout(false);
            gradientCus1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxCus1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pole1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pole2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pole3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk3).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Custom_Properties.GradientCus gradientCus1;
        private Label usernameLB;
        private PictureboxCus pictureboxCus1;
        private Panel panel1;
        private Custom_Properties.ButtonCus BrainTeasersB;
        private PictureBox Pole1;
        private PictureBox Pole2;
        private PictureBox Pole3;
        private PictureBox Disk1;
        private PictureBox Disk2;
        private PictureBox Disk3;
        private Custom_Properties.ButtonCus RestartBTN;
    }
}