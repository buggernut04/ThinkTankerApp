namespace BrainProbe
{
    partial class ScoreForm
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
            scoreFormLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // scoreFormLabel
            // 
            scoreFormLabel.AutoSize = true;
            scoreFormLabel.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            scoreFormLabel.ForeColor = SystemColors.ButtonHighlight;
            scoreFormLabel.Location = new Point(305, 172);
            scoreFormLabel.Name = "scoreFormLabel";
            scoreFormLabel.Size = new Size(247, 38);
            scoreFormLabel.TabIndex = 0;
            scoreFormLabel.Text = "Your Score is \"\";";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(211, 295);
            label1.Name = "label1";
            label1.Size = new Size(499, 38);
            label1.TabIndex = 2;
            label1.Text = "Well done on completing the quiz!";
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(scoreFormLabel);
            Name = "ScoreForm";
            Size = new Size(922, 537);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreFormLabel;
        private Label label1;
    }
}
