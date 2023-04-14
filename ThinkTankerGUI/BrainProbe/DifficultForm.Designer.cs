namespace ThinkTankerGUI.BrainProbe
{
    partial class DifficultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifficultForm));
            prevBTD = new PictureBox();
            nextBTD = new PictureBox();
            easyAnswerTBD = new TextBox();
            submitBTD = new Button();
            label1D = new Label();
            checkPBD = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)prevBTD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextBTD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPBD).BeginInit();
            SuspendLayout();
            // 
            // prevBTD
            // 
            prevBTD.Image = (Image)resources.GetObject("prevBTD.Image");
            prevBTD.Location = new Point(91, 41);
            prevBTD.Name = "prevBTD";
            prevBTD.Size = new Size(82, 64);
            prevBTD.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBTD.TabIndex = 0;
            prevBTD.TabStop = false;
            prevBTD.Click += prevBT_Click;
            // 
            // nextBTD
            // 
            nextBTD.Image = (Image)resources.GetObject("nextBTD.Image");
            nextBTD.Location = new Point(813, 41);
            nextBTD.Name = "nextBTD";
            nextBTD.Size = new Size(82, 64);
            nextBTD.SizeMode = PictureBoxSizeMode.StretchImage;
            nextBTD.TabIndex = 1;
            nextBTD.TabStop = false;
            nextBTD.Click += nextBTD_Click;
            // 
            // easyAnswerTBD
            // 
            easyAnswerTBD.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            easyAnswerTBD.Location = new Point(345, 315);
            easyAnswerTBD.Name = "easyAnswerTBD";
            easyAnswerTBD.PlaceholderText = "Enter your answer here.";
            easyAnswerTBD.Size = new Size(298, 38);
            easyAnswerTBD.TabIndex = 2;
            // 
            // submitBTD
            // 
            submitBTD.FlatAppearance.BorderSize = 2;
            submitBTD.FlatStyle = FlatStyle.Flat;
            submitBTD.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            submitBTD.ForeColor = Color.Black;
            submitBTD.Location = new Point(426, 371);
            submitBTD.Name = "submitBTD";
            submitBTD.Size = new Size(140, 57);
            submitBTD.TabIndex = 3;
            submitBTD.Text = "Submit";
            submitBTD.UseVisualStyleBackColor = true;
            submitBTD.Click += submitBTD_Click;
            // 
            // label1D
            // 
            label1D.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1D.Location = new Point(205, 144);
            label1D.Name = "label1D";
            label1D.Size = new Size(582, 142);
            label1D.TabIndex = 4;
            label1D.Text = "gyfygywegfeygdygvweycbdygvbgdsvgsdvdsygvbgdhcb dghb ghjvb ghbhjbvgfhgbvhfvjsgburjfnvrgbusfgshfuhg";
            label1D.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkPBD
            // 
            checkPBD.Image = (Image)resources.GetObject("checkPBD.Image");
            checkPBD.Location = new Point(448, 289);
            checkPBD.Name = "checkPBD";
            checkPBD.Size = new Size(88, 76);
            checkPBD.SizeMode = PictureBoxSizeMode.StretchImage;
            checkPBD.TabIndex = 5;
            checkPBD.TabStop = false;
            // 
            // DifficultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkPBD);
            Controls.Add(easyAnswerTBD);
            Controls.Add(label1D);
            Controls.Add(submitBTD);
            Controls.Add(nextBTD);
            Controls.Add(prevBTD);
            Name = "DifficultForm";
            Size = new Size(998, 540);
            ((System.ComponentModel.ISupportInitialize)prevBTD).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextBTD).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPBD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prevBTD;
        private PictureBox nextBTD;
        private TextBox easyAnswerTBD;
        private Button submitBTD;
        private Label label1D;
        private PictureBox checkPBD;
    }
}
