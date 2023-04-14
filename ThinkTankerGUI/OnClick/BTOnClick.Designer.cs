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
            TOHB.BackColor = Color.FromArgb(251, 133, 0);
            TOHB.BackgroundColor = Color.FromArgb(251, 133, 0);
            TOHB.BorderColor = Color.PaleVioletRed;
            TOHB.BorderRadius = 15;
            TOHB.BorderSize = 0;
            TOHB.FlatAppearance.BorderSize = 0;
            TOHB.FlatStyle = FlatStyle.Flat;
            TOHB.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TOHB.ForeColor = Color.FromArgb(2, 48, 71);
            TOHB.Location = new Point(249, 316);
            TOHB.Name = "TOHB";
            TOHB.Size = new Size(277, 101);
            TOHB.TabIndex = 0;
            TOHB.Text = "TOWER OF HANOI";
            TOHB.TextColor = Color.FromArgb(2, 48, 71);
            TOHB.UseVisualStyleBackColor = false;
            TOHB.Click += TOHB_Click;
            // 
            // MatchMB
            // 
            MatchMB.BackColor = Color.FromArgb(251, 133, 0);
            MatchMB.BackgroundColor = Color.FromArgb(251, 133, 0);
            MatchMB.BorderColor = Color.PaleVioletRed;
            MatchMB.BorderRadius = 15;
            MatchMB.BorderSize = 0;
            MatchMB.FlatAppearance.BorderSize = 0;
            MatchMB.FlatStyle = FlatStyle.Flat;
            MatchMB.Font = new Font("Gill Sans MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            MatchMB.ForeColor = Color.FromArgb(2, 48, 71);
            MatchMB.Location = new Point(720, 316);
            MatchMB.Name = "MatchMB";
            MatchMB.Size = new Size(277, 101);
            MatchMB.TabIndex = 1;
            MatchMB.Text = "MATCHING GAME";
            MatchMB.TextColor = Color.FromArgb(2, 48, 71);
            MatchMB.UseVisualStyleBackColor = false;
            MatchMB.Click += MatchMB_Click;
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