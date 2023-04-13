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
            panel1.SuspendLayout();
            gradientCus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxCus1).BeginInit();
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
            usernameLB.Location = new Point(178, 99);
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
            pictureboxCus1.Location = new Point(53, 77);
            pictureboxCus1.Margin = new Padding(3, 4, 3, 4);
            pictureboxCus1.Name = "pictureboxCus1";
            pictureboxCus1.Size = new Size(113, 113);
            pictureboxCus1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            ExitB.Location = new Point(177, 566);
            ExitB.Name = "ExitB";
            ExitB.Size = new Size(79, 92);
            ExitB.TabIndex = 2;
            ExitB.TextColor = Color.White;
            ExitB.UseVisualStyleBackColor = false;
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
            BrainProbeB.Location = new Point(77, 575);
            BrainProbeB.Margin = new Padding(3, 4, 3, 4);
            BrainProbeB.Name = "BrainProbeB";
            BrainProbeB.Size = new Size(330, 100);
            BrainProbeB.TabIndex = 1;
            BrainProbeB.Text = "Brain Probe";
            BrainProbeB.TextColor = Color.FromArgb(251, 133, 0);
            BrainProbeB.UseVisualStyleBackColor = false;
            
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
            BrainTeasersB.Location = new Point(77, 420);
            BrainTeasersB.Margin = new Padding(3, 4, 3, 4);
            BrainTeasersB.Name = "BrainTeasersB";
            BrainTeasersB.Size = new Size(330, 100);
            BrainTeasersB.TabIndex = 0;
            BrainTeasersB.Text = "Brain Teasers";
            BrainTeasersB.TextColor = Color.FromArgb(251, 133, 0);
            BrainTeasersB.UseVisualStyleBackColor = false;
            BrainTeasersB.Click += BrainTeasersB_Click;
            // 
            // hoverTxt
            // 
            hoverTxt.AutoSize = true;
            hoverTxt.Location = new Point(606, 219);
            hoverTxt.Name = "hoverTxt";
            hoverTxt.Size = new Size(0, 15);
            hoverTxt.TabIndex = 1;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 71);
            ClientSize = new Size(1264, 749);
            Controls.Add(hoverTxt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
    }
}