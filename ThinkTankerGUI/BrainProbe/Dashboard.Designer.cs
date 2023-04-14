
using BrainProbe;

namespace ThinkTankerGUI.BrainProbe
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            difficultBT = new Button();
            moderateBT = new Button();
            easyBT = new Button();
            panel2 = new Panel();
            outBT = new Button();
            exitBT = new Button();
            timerLabel = new Label();
            pauseBT = new Button();
            easyForm1 = new EasyForm();
            moderateForm1 = new ModerateForm();
            difficultForm1 = new DifficultForm();
            quiztimer = new System.Windows.Forms.Timer(components);
            scoreForm1 = new ScoreForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 48, 71);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(difficultBT);
            panel1.Controls.Add(moderateBT);
            panel1.Controls.Add(easyBT);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 622);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 456);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // difficultBT
            // 
            difficultBT.FlatAppearance.BorderSize = 0;
            difficultBT.FlatStyle = FlatStyle.Flat;
            difficultBT.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            difficultBT.ForeColor = SystemColors.ButtonHighlight;
            difficultBT.Location = new Point(10, 346);
            difficultBT.Margin = new Padding(3, 2, 3, 2);
            difficultBT.Name = "difficultBT";
            difficultBT.Size = new Size(196, 44);
            difficultBT.TabIndex = 2;
            difficultBT.Text = "Difficult";
            difficultBT.UseVisualStyleBackColor = true;
            difficultBT.Click += difficultBT_Click;
            // 
            // moderateBT
            // 
            moderateBT.FlatAppearance.BorderSize = 0;
            moderateBT.FlatStyle = FlatStyle.Flat;
            moderateBT.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            moderateBT.ForeColor = SystemColors.ButtonHighlight;
            moderateBT.Location = new Point(10, 279);
            moderateBT.Margin = new Padding(3, 2, 3, 2);
            moderateBT.Name = "moderateBT";
            moderateBT.Size = new Size(196, 44);
            moderateBT.TabIndex = 2;
            moderateBT.Text = "Moderate";
            moderateBT.UseVisualStyleBackColor = true;
            moderateBT.Click += moderateBT_Click;
            // 
            // easyBT
            // 
            easyBT.FlatAppearance.BorderSize = 0;
            easyBT.FlatStyle = FlatStyle.Flat;
            easyBT.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            easyBT.ForeColor = SystemColors.ButtonHighlight;
            easyBT.Location = new Point(10, 209);
            easyBT.Margin = new Padding(3, 2, 3, 2);
            easyBT.Name = "easyBT";
            easyBT.Size = new Size(196, 44);
            easyBT.TabIndex = 2;
            easyBT.Text = "Easy";
            easyBT.UseVisualStyleBackColor = true;
            easyBT.Click += easyBT_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 48, 71);
            panel2.Controls.Add(outBT);
            panel2.Controls.Add(exitBT);
            panel2.Controls.Add(timerLabel);
            panel2.Controls.Add(pauseBT);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(219, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 49);
            panel2.TabIndex = 1;
            // 
            // outBT
            // 
            outBT.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            outBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 60, 71);
            outBT.FlatStyle = FlatStyle.Flat;
            outBT.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            outBT.ForeColor = SystemColors.ButtonHighlight;
            outBT.Location = new Point(868, 13);
            outBT.Margin = new Padding(3, 2, 3, 2);
            outBT.Name = "outBT";
            outBT.Size = new Size(30, 24);
            outBT.TabIndex = 2;
            outBT.Text = "X";
            outBT.UseVisualStyleBackColor = true;
            outBT.Click += outBT_Click;
            // 
            // exitBT
            // 
            exitBT.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            exitBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            exitBT.FlatStyle = FlatStyle.Flat;
            exitBT.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitBT.ForeColor = SystemColors.ButtonHighlight;
            exitBT.Location = new Point(13, 8);
            exitBT.Margin = new Padding(3, 2, 3, 2);
            exitBT.Name = "exitBT";
            exitBT.Size = new Size(84, 29);
            exitBT.TabIndex = 1;
            exitBT.Text = "Exit";
            exitBT.TextAlign = ContentAlignment.TopCenter;
            exitBT.UseVisualStyleBackColor = true;
            exitBT.Click += exitBT_Click;
            // 
            // timerLabel
            // 
            timerLabel.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            timerLabel.ForeColor = SystemColors.ButtonHighlight;
            timerLabel.Location = new Point(740, 13);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(67, 23);
            timerLabel.TabIndex = 1;
            timerLabel.Text = "00:00";
            // 
            // pauseBT
            // 
            pauseBT.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            pauseBT.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            pauseBT.FlatStyle = FlatStyle.Flat;
            pauseBT.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            pauseBT.ForeColor = SystemColors.ButtonHighlight;
            pauseBT.Location = new Point(816, 9);
            pauseBT.Margin = new Padding(3, 2, 3, 2);
            pauseBT.Name = "pauseBT";
            pauseBT.Size = new Size(82, 27);
            pauseBT.TabIndex = 0;
            pauseBT.Text = "Pause";
            pauseBT.UseVisualStyleBackColor = true;
            pauseBT.Click += pauseBT_Click;
            // 
            // easyForm1
            // 
            easyForm1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            easyForm1.easyForm_isOpen = false;
            easyForm1.Location = new Point(232, 127);
            easyForm1.Margin = new Padding(3, 2, 3, 2);
            easyForm1.Name = "easyForm1";
            easyForm1.Size = new Size(1092, 506);
            easyForm1.TabIndex = 2;
            // 
            // moderateForm1
            // 
            moderateForm1.Location = new Point(232, 127);
            moderateForm1.Margin = new Padding(3, 2, 3, 2);
            moderateForm1.moderateForm_isOpen = false;
            moderateForm1.Name = "moderateForm1";
            moderateForm1.Size = new Size(1092, 506);
            moderateForm1.TabIndex = 3;
            // 
            // difficultForm1
            // 
            difficultForm1.difficult_isOpen = false;
            difficultForm1.Location = new Point(232, 127);
            difficultForm1.Margin = new Padding(3, 2, 3, 2);
            difficultForm1.Name = "difficultForm1";
            difficultForm1.Size = new Size(1092, 506);
            difficultForm1.TabIndex = 4;
            // 
            // quiztimer
            // 
            quiztimer.Enabled = true;
            quiztimer.Interval = 1000;
            quiztimer.Tick += quiztimer_Tick;
            // 
            // scoreForm1
            // 
            scoreForm1.BackColor = Color.Transparent;
            scoreForm1.Location = new Point(276, 80);
            scoreForm1.Margin = new Padding(3, 2, 3, 2);
            scoreForm1.Name = "scoreForm1";
            scoreForm1.Size = new Size(1008, 503);
            scoreForm1.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 133, 0);
            ClientSize = new Size(1127, 622);
            Controls.Add(difficultForm1);
            Controls.Add(moderateForm1);
            Controls.Add(easyForm1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(scoreForm1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button difficultBT;
        private Button moderateBT;
        private Button easyBT;
        private Label timerLabel;
        private Button pauseBT;
        private EasyForm easyForm1;
        private ModerateForm moderateForm1;
        private DifficultForm difficultForm1;
        private System.Windows.Forms.Timer quiztimer;
        private ScoreForm scoreForm1;
        private Button exitBT;
        private Button outBT;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}