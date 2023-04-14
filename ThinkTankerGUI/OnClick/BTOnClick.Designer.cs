namespace ThinkTankerGUI.OnClick
{
    partial class BTOnClick
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
            TOHB = new Custom_Properties.ButtonCus();
            MatchMB = new Custom_Properties.ButtonCus();
            SuspendLayout();
            // 
            // TOHB
            // 
            TOHB.BackColor = Color.MediumSlateBlue;
            TOHB.BackgroundColor = Color.MediumSlateBlue;
            TOHB.BorderColor = Color.PaleVioletRed;
            TOHB.BorderRadius = 15;
            TOHB.BorderSize = 0;
            TOHB.FlatAppearance.BorderSize = 0;
            TOHB.FlatStyle = FlatStyle.Flat;
            TOHB.ForeColor = Color.White;
            TOHB.Location = new Point(249, 316);
            TOHB.Name = "TOHB";
            TOHB.Size = new Size(277, 101);
            TOHB.TabIndex = 0;
            TOHB.Text = "Towe of Hanoi";
            TOHB.TextColor = Color.White;
            TOHB.UseVisualStyleBackColor = false;
            // 
            // MatchMB
            // 
            MatchMB.BackColor = Color.MediumSlateBlue;
            MatchMB.BackgroundColor = Color.MediumSlateBlue;
            MatchMB.BorderColor = Color.PaleVioletRed;
            MatchMB.BorderRadius = 15;
            MatchMB.BorderSize = 0;
            MatchMB.FlatAppearance.BorderSize = 0;
            MatchMB.FlatStyle = FlatStyle.Flat;
            MatchMB.ForeColor = Color.White;
            MatchMB.Location = new Point(720, 316);
            MatchMB.Name = "MatchMB";
            MatchMB.Size = new Size(277, 101);
            MatchMB.TabIndex = 1;
            MatchMB.Text = "Matching Game";
            MatchMB.TextColor = Color.White;
            MatchMB.UseVisualStyleBackColor = false;
            // 
            // BTOnClick
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(2, 48, 71);
            ClientSize = new Size(1264, 749);
            Controls.Add(MatchMB);
            Controls.Add(TOHB);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BTOnClick";
            Load += BTOnClick_Load;
            ResumeLayout(false);
        }

        #endregion

        private Custom_Properties.ButtonCus TOHB;
        private Custom_Properties.ButtonCus MatchMB;
    }
}