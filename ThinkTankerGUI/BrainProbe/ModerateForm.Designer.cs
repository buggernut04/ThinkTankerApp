namespace ThinkTankerGUI.BrainProbe
{
    partial class ModerateForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModerateForm));
            prevBTM = new PictureBox();
            nextBTM = new PictureBox();
            easyAnswerTBM = new TextBox();
            submitBTM = new Button();
            label1M = new Label();
            checkPBM = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)prevBTM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextBTM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPBM).BeginInit();
            SuspendLayout();
            // 
            // prevBTM
            // 
            prevBTM.Image = (Image)resources.GetObject("prevBTM.Image");
            prevBTM.Location = new Point(91, 41);
            prevBTM.Name = "prevBTM";
            prevBTM.Size = new Size(82, 64);
            prevBTM.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBTM.TabIndex = 0;
            prevBTM.TabStop = false;
            prevBTM.Click += prevBT_Click;
            // 
            // nextBTM
            // 
            nextBTM.Image = (Image)resources.GetObject("nextBTM.Image");
            nextBTM.Location = new Point(813, 41);
            nextBTM.Name = "nextBTM";
            nextBTM.Size = new Size(82, 64);
            nextBTM.SizeMode = PictureBoxSizeMode.StretchImage;
            nextBTM.TabIndex = 1;
            nextBTM.TabStop = false;
            nextBTM.Click += nextBTM_Click;
            // 
            // easyAnswerTBM
            // 
            easyAnswerTBM.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            easyAnswerTBM.Location = new Point(345, 315);
            easyAnswerTBM.Name = "easyAnswerTBM";
            easyAnswerTBM.PlaceholderText = "Enter your answer here.";
            easyAnswerTBM.Size = new Size(298, 38);
            easyAnswerTBM.TabIndex = 2;
            // 
            // submitBTM
            // 
            submitBTM.FlatAppearance.BorderSize = 2;
            submitBTM.FlatStyle = FlatStyle.Flat;
            submitBTM.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            submitBTM.ForeColor = Color.Black;
            submitBTM.Location = new Point(426, 371);
            submitBTM.Name = "submitBTM";
            submitBTM.Size = new Size(140, 57);
            submitBTM.TabIndex = 3;
            submitBTM.Text = "Submit";
            submitBTM.UseVisualStyleBackColor = true;
            submitBTM.Click += submitBTM_Click;
            // 
            // label1M
            // 
            label1M.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1M.Location = new Point(205, 144);
            label1M.Name = "label1M";
            label1M.Size = new Size(582, 142);
            label1M.TabIndex = 4;
            label1M.Text = "gyfygywegfeygdygvweycbdygvbgdsvgsdvdsygvbgdhcb dghb ghjvb ghbhjbvgfhgbvhfvjsgburjfnvrgbusfgshfuhg";
            label1M.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkPBM
            // 
            checkPBM.Image = (Image)resources.GetObject("checkPBM.Image");
            checkPBM.Location = new Point(456, 289);
            checkPBM.Name = "checkPBM";
            checkPBM.Size = new Size(88, 76);
            checkPBM.SizeMode = PictureBoxSizeMode.StretchImage;
            checkPBM.TabIndex = 5;
            checkPBM.TabStop = false;
            // 
            // ModerateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkPBM);
            Controls.Add(label1M);
            Controls.Add(submitBTM);
            Controls.Add(easyAnswerTBM);
            Controls.Add(nextBTM);
            Controls.Add(prevBTM);
            Name = "ModerateForm";
            Size = new Size(998, 540);
            ((System.ComponentModel.ISupportInitialize)prevBTM).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextBTM).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPBM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prevBTM;
        private PictureBox nextBTM;
        private TextBox easyAnswerTBM;
        private Button submitBTM;
        private Label label1M;
        private PictureBox checkPBM;
    }
}
