namespace ThinkTankerGUI
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
            panel1 = new Panel();
            gradientCus1 = new Custom_Properties.GradientCus();
            pictureboxCus1 = new PictureboxCus();
            Exit = new Custom_Properties.ButtonCus();
            BrainProbe = new Custom_Properties.ButtonCus();
            BrainTeasers = new Custom_Properties.ButtonCus();
            usernameLB = new Label();
            panel1.SuspendLayout();
            gradientCus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxCus1).BeginInit();
            // 
            // panel1
            // 
           /* panel1.BackColor = Color.FromArgb(251, 133, 0);
            panel1.Controls.Add(gradientCus1);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(BrainProbe);
            panel1.Controls.Add(BrainTeasers);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 788);
            panel1.TabIndex = 0;
            //panel1.Paint += panel1_Paint;
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
            gradientCus1.Name = "gradientCus1";
            gradientCus1.Size = new Size(423, 260);
            gradientCus1.TabIndex = 0;
            gradientCus1.TopColor = Color.FromArgb(245, 47, 87);
            //gradientCus1.Paint += gradientCus1_Paint;
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
            pictureboxCus1.Location = new Point(46, 58);
            pictureboxCus1.Name = "pictureboxCus1";
            pictureboxCus1.Size = new Size(99, 99);
            pictureboxCus1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxCus1.TabIndex = 0;
            pictureboxCus1.TabStop = false;
            // 
            // Exit
            // 
            Exit.BackColor = Color.PeachPuff;
            Exit.BackgroundColor = Color.PeachPuff;
            Exit.BorderColor = Color.PaleVioletRed;
            Exit.BorderRadius = 35;
            Exit.BorderSize = 0;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.ForeColor = Color.White;
            Exit.Location = new Point(177, 566);
            Exit.Name = "Exit";
            Exit.Size = new Size(69, 69);
            Exit.TabIndex = 2;
            Exit.TextColor = Color.White;
            Exit.UseVisualStyleBackColor = false;
            // 
            // BrainProbe
            // 
            BrainProbe.BackColor = Color.PeachPuff;
            BrainProbe.BackgroundColor = Color.PeachPuff;
            BrainProbe.BorderColor = Color.PaleVioletRed;
            BrainProbe.BorderRadius = 29;
            BrainProbe.BorderSize = 0;
            BrainProbe.FlatAppearance.BorderSize = 0;
            BrainProbe.FlatStyle = FlatStyle.Flat;
            BrainProbe.Font = new Font("Impact", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            BrainProbe.ForeColor = Color.FromArgb(251, 133, 0);
            BrainProbe.Location = new Point(67, 431);
            BrainProbe.Name = "BrainProbe";
            BrainProbe.Size = new Size(289, 75);
            BrainProbe.TabIndex = 1;
            BrainProbe.Text = "Brain Probe";
            BrainProbe.TextColor = Color.FromArgb(251, 133, 0);
            BrainProbe.UseVisualStyleBackColor = false;
            // 
            // BrainTeasers
            // 
            BrainTeasers.BackColor = Color.PeachPuff;
            BrainTeasers.BackgroundColor = Color.PeachPuff;
            BrainTeasers.BorderColor = Color.PaleVioletRed;
            BrainTeasers.BorderRadius = 29;
            BrainTeasers.BorderSize = 0;
            BrainTeasers.FlatAppearance.BorderSize = 0;
            BrainTeasers.FlatStyle = FlatStyle.Flat;
            BrainTeasers.Font = new Font("Impact", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            BrainTeasers.ForeColor = Color.FromArgb(251, 133, 0);
            BrainTeasers.Location = new Point(67, 315);
            BrainTeasers.Name = "BrainTeasers";
            BrainTeasers.Size = new Size(289, 75);
            BrainTeasers.TabIndex = 0;
            BrainTeasers.Text = "Brain Teasers";
            BrainTeasers.TextColor = Color.FromArgb(251, 133, 0);
            BrainTeasers.UseVisualStyleBackColor = false;
            // 
            // usernameLB
            // 
            usernameLB.AutoSize = true;
            usernameLB.BackColor = Color.Transparent;
            usernameLB.Font = new Font("Cascadia Code SemiBold", 23F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLB.ForeColor = Color.FromArgb(255, 247, 237);
            usernameLB.Location = new Point(156, 74);
            usernameLB.Name = "usernameLB";
            usernameLB.Size = new Size(216, 41);
            usernameLB.TabIndex = 1;
            usernameLB.Text = "Loren Ipsum";*/
        }

        #endregion

        private Panel panel1;
        private Custom_Properties.ButtonCus BrainProbe;
        private Custom_Properties.ButtonCus BrainTeasers;
        private Custom_Properties.ButtonCus Exit;
        private Custom_Properties.GradientCus gradientCus1;
        private PictureboxCus pictureboxCus1;
        private Label usernameLB;
    }
}