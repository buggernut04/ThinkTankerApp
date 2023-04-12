namespace ThinkTankerGUI
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
            BrainTeasersB = new Custom_Properties.ButtonCus();
            usernameLB = new Label();
            pictureboxCus1 = new PictureboxCus();
            panel1 = new Panel();
            Pole1 = new PictureBox();
            Pole2 = new PictureBox();
            Pole3 = new PictureBox();
            Disk3 = new PictureBox();
            Disk2 = new PictureBox();
            Disk1 = new PictureBox();
            gradientCus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxCus1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pole1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pole2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pole3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk1).BeginInit();
            SuspendLayout();
            // 
            // gradientCus1
            // 
            gradientCus1.AllowDrop = true;
            gradientCus1.Angle = 90F;
            gradientCus1.BackgroundImageLayout = ImageLayout.None;
            gradientCus1.BottomColor = Color.FromArgb(251, 133, 0);
            gradientCus1.Controls.Add(BrainTeasersB);
            gradientCus1.Controls.Add(usernameLB);
            gradientCus1.Controls.Add(pictureboxCus1);
            gradientCus1.Dock = DockStyle.Top;
            gradientCus1.ForeColor = Color.FromArgb(251, 133, 0);
            gradientCus1.Location = new Point(0, 0);
            gradientCus1.Name = "gradientCus1";
            gradientCus1.Size = new Size(255, 452);
            gradientCus1.TabIndex = 1;
            gradientCus1.TopColor = Color.FromArgb(245, 47, 87);
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
            BrainTeasersB.Location = new Point(14, 144);
            BrainTeasersB.Name = "BrainTeasersB";
            BrainTeasersB.Size = new Size(226, 46);
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
            usernameLB.Location = new Point(68, 22);
            usernameLB.Name = "usernameLB";
            usernameLB.Size = new Size(216, 41);
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
            pictureboxCus1.Location = new Point(12, 13);
            pictureboxCus1.Name = "pictureboxCus1";
            pictureboxCus1.Size = new Size(50, 50);
            pictureboxCus1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxCus1.TabIndex = 0;
            pictureboxCus1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 133, 0);
            panel1.Controls.Add(gradientCus1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 452);
            panel1.TabIndex = 0;
            // 
            // Pole1
            // 
            Pole1.BackColor = Color.Chocolate;
            Pole1.Location = new Point(370, 276);
            Pole1.Name = "Pole1";
            Pole1.Size = new Size(10, 106);
            Pole1.TabIndex = 1;
            Pole1.TabStop = false;
            // 
            // Pole2
            // 
            Pole2.BackColor = Color.Chocolate;
            Pole2.Location = new Point(520, 276);
            Pole2.Name = "Pole2";
            Pole2.Size = new Size(10, 106);
            Pole2.TabIndex = 2;
            Pole2.TabStop = false;
            // 
            // Pole3
            // 
            Pole3.BackColor = Color.Chocolate;
            Pole3.Location = new Point(681, 276);
            Pole3.Name = "Pole3";
            Pole3.Size = new Size(10, 106);
            Pole3.TabIndex = 3;
            Pole3.TabStop = false;
            // 
            // Disk3
            // 
            Disk3.BackColor = Color.Red;
            Disk3.Location = new Point(341, 325);
            Disk3.Name = "Disk3";
            Disk3.Size = new Size(69, 20);
            Disk3.TabIndex = 4;
            Disk3.TabStop = false;
            Disk3.Tag = "Disk";
            // 
            // Disk2
            // 
            Disk2.BackColor = Color.Cyan;
            Disk2.Location = new Point(327, 343);
            Disk2.Name = "Disk2";
            Disk2.Size = new Size(95, 20);
            Disk2.TabIndex = 5;
            Disk2.TabStop = false;
            Disk2.Tag = "Disk";
            // 
            // Disk1
            // 
            Disk1.BackColor = Color.Yellow;
            Disk1.Location = new Point(315, 362);
            Disk1.Name = "Disk1";
            Disk1.Size = new Size(121, 20);
            Disk1.TabIndex = 6;
            Disk1.TabStop = false;
            Disk1.Tag = "Disk";
            // 
            // TowerOfHanoiBT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 71);
            ClientSize = new Size(800, 450);
            Controls.Add(Disk1);
            Controls.Add(Disk2);
            Controls.Add(Disk3);
            Controls.Add(Pole3);
            Controls.Add(Pole2);
            Controls.Add(Pole1);
            Controls.Add(panel1);
            Name = "TowerOfHanoiBT";
            Text = "TowerOfHanoi";
            Load += TowerOfHanoiBT_Load;
            gradientCus1.ResumeLayout(false);
            gradientCus1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxCus1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pole1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pole2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pole3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk1).EndInit();
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
        private PictureBox Disk3;
        private PictureBox Disk2;
        private PictureBox Disk1;
    }
}