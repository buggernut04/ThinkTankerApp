namespace ThinkTankerGUI.LogInForm
{
    partial class Form1
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
            textBoxCus1 = new Custom_Properties.TextBoxCus();
            textBoxCus2 = new Custom_Properties.TextBoxCus();
            SuspendLayout();
            // 
            // textBoxCus1
            // 
            textBoxCus1.BackColor = SystemColors.Window;
            textBoxCus1.BorderColor = Color.MediumSlateBlue;
            textBoxCus1.BorderFocusColor = Color.HotPink;
            textBoxCus1.BorderRadius = 10;
            textBoxCus1.BorderSize = 2;
            textBoxCus1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCus1.ForeColor = Color.DimGray;
            textBoxCus1.Location = new Point(558, 78);
            textBoxCus1.Multiline = false;
            textBoxCus1.Name = "textBoxCus1";
            textBoxCus1.Padding = new Padding(10, 7, 10, 7);
            textBoxCus1.PasswordChar = false;
            textBoxCus1.PlaceholderColor = Color.DarkGray;
            textBoxCus1.PlaceholderText = "";
            textBoxCus1.Size = new Size(184, 32);
            textBoxCus1.TabIndex = 0;
            textBoxCus1.UnderlinedStyle = false;
            // 
            // textBoxCus2
            // 
            textBoxCus2.BackColor = SystemColors.Window;
            textBoxCus2.BorderColor = Color.MediumSlateBlue;
            textBoxCus2.BorderFocusColor = Color.HotPink;
            textBoxCus2.BorderRadius = 0;
            textBoxCus2.BorderSize = 2;
            textBoxCus2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCus2.ForeColor = Color.DimGray;
            textBoxCus2.Location = new Point(558, 116);
            textBoxCus2.Multiline = false;
            textBoxCus2.Name = "textBoxCus2";
            textBoxCus2.Padding = new Padding(10, 7, 10, 7);
            textBoxCus2.PasswordChar = true;
            textBoxCus2.PlaceholderColor = Color.DarkGray;
            textBoxCus2.PlaceholderText = "password";
            textBoxCus2.Size = new Size(184, 32);
            textBoxCus2.TabIndex = 1;
            textBoxCus2.UnderlinedStyle = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCus2);
            Controls.Add(textBoxCus1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Custom_Properties.TextBoxCus textBoxCus1;
        private Custom_Properties.TextBoxCus textBoxCus2;
    }
}