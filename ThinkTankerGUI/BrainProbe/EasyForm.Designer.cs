namespace BrainProbe
{
    partial class EasyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyForm));
            prevBT = new PictureBox();
            nextBT = new PictureBox();
            easyAnswerTB = new TextBox();
            submitBT = new Button();
            label1 = new Label();
            checkPB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)prevBT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextBT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPB).BeginInit();
            SuspendLayout();
            // 
            // prevBT
            // 
            prevBT.Image = (Image)resources.GetObject("prevBT.Image");
            prevBT.Location = new Point(91, 41);
            prevBT.Name = "prevBT";
            prevBT.Size = new Size(82, 64);
            prevBT.SizeMode = PictureBoxSizeMode.StretchImage;
            prevBT.TabIndex = 0;
            prevBT.TabStop = false;
            prevBT.Click += prevBT_Click;
            // 
            // nextBT
            // 
            nextBT.Image = (Image)resources.GetObject("nextBT.Image");
            nextBT.Location = new Point(813, 41);
            nextBT.Name = "nextBT";
            nextBT.Size = new Size(82, 64);
            nextBT.SizeMode = PictureBoxSizeMode.StretchImage;
            nextBT.TabIndex = 1;
            nextBT.TabStop = false;
            nextBT.Click += nextBT_Click;
            // 
            // easyAnswerTB
            // 
            easyAnswerTB.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            easyAnswerTB.Location = new Point(345, 315);
            easyAnswerTB.Name = "easyAnswerTB";
            easyAnswerTB.PlaceholderText = "Enter your answer here.";
            easyAnswerTB.Size = new Size(298, 38);
            easyAnswerTB.TabIndex = 2;
            // 
            // submitBT
            // 
            submitBT.FlatAppearance.BorderSize = 2;
            submitBT.FlatStyle = FlatStyle.Flat;
            submitBT.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            submitBT.Location = new Point(426, 371);
            submitBT.Name = "submitBT";
            submitBT.Size = new Size(140, 57);
            submitBT.TabIndex = 3;
            submitBT.Text = "Submit";
            submitBT.UseVisualStyleBackColor = true;
            submitBT.Click += submitBT_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 144);
            label1.Name = "label1";
            label1.Size = new Size(582, 142);
            label1.TabIndex = 4;
            label1.Text = "gyfygywegfeygdygvweycbdygvbgdsvgsdvdsygvbgdhcb dghb ghjvb ghbhjbvgfhgbvhfvjsgburjfnvrgbusfgshfuhg";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkPB
            // 
            checkPB.Image = (Image)resources.GetObject("checkPB.Image");
            checkPB.Location = new Point(448, 289);
            checkPB.Name = "checkPB";
            checkPB.Size = new Size(88, 76);
            checkPB.SizeMode = PictureBoxSizeMode.StretchImage;
            checkPB.TabIndex = 5;
            checkPB.TabStop = false;
            // 
            // EasyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            Controls.Add(checkPB);
            Controls.Add(label1);
            Controls.Add(submitBT);
            Controls.Add(easyAnswerTB);
            Controls.Add(nextBT);
            Controls.Add(prevBT);
            Name = "EasyForm";
            Size = new Size(998, 540);
            ((System.ComponentModel.ISupportInitialize)prevBT).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextBT).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prevBT;
        private PictureBox nextBT;
        private TextBox easyAnswerTB;
        private Button submitBT;
        private Label label1;
        private PictureBox checkPB;
    }
}
