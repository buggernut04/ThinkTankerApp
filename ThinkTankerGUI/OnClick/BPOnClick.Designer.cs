namespace ThinkTankerGUI.OnClick
{
    partial class BPOnClick
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
            EasyB = new Custom_Properties.ButtonCus();
            ModerateB = new Custom_Properties.ButtonCus();
            DifficultB = new Custom_Properties.ButtonCus();
            SuspendLayout();
            // 
            // EasyB
            // 
            EasyB.BackColor = Color.MediumSlateBlue;
            EasyB.BackgroundColor = Color.MediumSlateBlue;
            EasyB.BorderColor = Color.PaleVioletRed;
            EasyB.BorderRadius = 10;
            EasyB.BorderSize = 0;
            EasyB.FlatAppearance.BorderSize = 0;
            EasyB.FlatStyle = FlatStyle.Flat;
            EasyB.ForeColor = Color.White;
            EasyB.Location = new Point(76, 335);
            EasyB.Name = "EasyB";
            EasyB.Size = new Size(298, 106);
            EasyB.TabIndex = 0;
            EasyB.Text = "Easy";
            EasyB.TextColor = Color.White;
            EasyB.UseVisualStyleBackColor = false;
            // 
            // ModerateB
            // 
            ModerateB.BackColor = Color.MediumSlateBlue;
            ModerateB.BackgroundColor = Color.MediumSlateBlue;
            ModerateB.BorderColor = Color.PaleVioletRed;
            ModerateB.BorderRadius = 10;
            ModerateB.BorderSize = 0;
            ModerateB.FlatAppearance.BorderSize = 0;
            ModerateB.FlatStyle = FlatStyle.Flat;
            ModerateB.ForeColor = Color.White;
            ModerateB.Location = new Point(475, 335);
            ModerateB.Name = "ModerateB";
            ModerateB.Size = new Size(298, 106);
            ModerateB.TabIndex = 1;
            ModerateB.Text = "Moderate";
            ModerateB.TextColor = Color.White;
            ModerateB.UseVisualStyleBackColor = false;
            // 
            // DifficultB
            // 
            DifficultB.BackColor = Color.MediumSlateBlue;
            DifficultB.BackgroundColor = Color.MediumSlateBlue;
            DifficultB.BorderColor = Color.PaleVioletRed;
            DifficultB.BorderRadius = 10;
            DifficultB.BorderSize = 0;
            DifficultB.FlatAppearance.BorderSize = 0;
            DifficultB.FlatStyle = FlatStyle.Flat;
            DifficultB.ForeColor = Color.White;
            DifficultB.Location = new Point(868, 335);
            DifficultB.Name = "DifficultB";
            DifficultB.Size = new Size(298, 106);
            DifficultB.TabIndex = 2;
            DifficultB.Text = "Difficult";
            DifficultB.TextColor = Color.White;
            DifficultB.UseVisualStyleBackColor = false;
            // 
            // BPOnClick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 48, 71);
            ClientSize = new Size(1264, 749);
            Controls.Add(DifficultB);
            Controls.Add(ModerateB);
            Controls.Add(EasyB);
            Name = "BPOnClick";
            Text = "Form1";
            Load += BPOnClick_Load;
            ResumeLayout(false);
        }

        #endregion

        private Custom_Properties.ButtonCus EasyB;
        private Custom_Properties.ButtonCus ModerateB;
        private Custom_Properties.ButtonCus DifficultB;
    }
}