namespace ThinkTankerGUI
{
    partial class SignUp
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
            textBoxCus1 = new Custom_Properties.TextBoxCus();
            textBoxCus2 = new Custom_Properties.TextBoxCus();
            textBoxCus3 = new Custom_Properties.TextBoxCus();
            buttonCus1 = new Custom_Properties.ButtonCus();
            nameTB = new Custom_Properties.TextBoxCus();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 133, 0);
            panel1.Controls.Add(gradientCus1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 788);
            panel1.TabIndex = 0;
            // 
            // gradientCus1
            // 
            gradientCus1.Angle = 90F;
            gradientCus1.BottomColor = Color.FromArgb(251, 133, 0);
            gradientCus1.ForeColor = Color.FromArgb(251, 133, 0);
            gradientCus1.Location = new Point(-8, -2);
            gradientCus1.Name = "gradientCus1";
            gradientCus1.Size = new Size(435, 558);
            gradientCus1.TabIndex = 5;
            gradientCus1.TopColor = Color.FromArgb(134, 187, 216);
            gradientCus1.Paint += gradientCus1_Paint;
            // 
            // textBoxCus1
            // 
            textBoxCus1.BackColor = Color.FromArgb(2, 48, 71);
            textBoxCus1.BorderColor = Color.FromArgb(250, 240, 202);
            textBoxCus1.BorderFocusColor = Color.FromArgb(251, 133, 0);
            textBoxCus1.BorderRadius = 0;
            textBoxCus1.BorderSize = 4;
            textBoxCus1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCus1.ForeColor = Color.DimGray;
            textBoxCus1.Location = new Point(455, 261);
            textBoxCus1.Multiline = false;
            textBoxCus1.Name = "textBoxCus1";
            textBoxCus1.Padding = new Padding(10, 7, 10, 7);
            textBoxCus1.PasswordChar = false;
            textBoxCus1.PlaceholderColor = Color.DarkGray;
            textBoxCus1.PlaceholderText = "Username";
            textBoxCus1.Size = new Size(500, 32);
            textBoxCus1.TabIndex = 1;
            textBoxCus1.UnderlinedStyle = true;
            // 
            // textBoxCus2
            // 
            textBoxCus2.BackColor = Color.FromArgb(2, 48, 71);
            textBoxCus2.BorderColor = Color.FromArgb(250, 240, 202);
            textBoxCus2.BorderFocusColor = Color.FromArgb(251, 133, 0);
            textBoxCus2.BorderRadius = 0;
            textBoxCus2.BorderSize = 4;
            textBoxCus2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCus2.ForeColor = Color.DimGray;
            textBoxCus2.Location = new Point(455, 441);
            textBoxCus2.Multiline = false;
            textBoxCus2.Name = "textBoxCus2";
            textBoxCus2.Padding = new Padding(10, 7, 10, 7);
            textBoxCus2.PasswordChar = false;
            textBoxCus2.PlaceholderColor = Color.DarkGray;
            textBoxCus2.PlaceholderText = "Password";
            textBoxCus2.Size = new Size(500, 32);
            textBoxCus2.TabIndex = 2;
            textBoxCus2.UnderlinedStyle = true;
            // 
            // textBoxCus3
            // 
            textBoxCus3.BackColor = Color.FromArgb(2, 48, 71);
            textBoxCus3.BorderColor = Color.FromArgb(250, 240, 202);
            textBoxCus3.BorderFocusColor = Color.FromArgb(251, 133, 0);
            textBoxCus3.BorderRadius = 0;
            textBoxCus3.BorderSize = 4;
            textBoxCus3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCus3.ForeColor = Color.DimGray;
            textBoxCus3.Location = new Point(449, 519);
            textBoxCus3.Multiline = false;
            textBoxCus3.Name = "textBoxCus3";
            textBoxCus3.Padding = new Padding(10, 7, 10, 7);
            textBoxCus3.PasswordChar = false;
            textBoxCus3.PlaceholderColor = Color.DarkGray;
            textBoxCus3.PlaceholderText = "Confirm Password";
            textBoxCus3.Size = new Size(500, 32);
            textBoxCus3.TabIndex = 3;
            textBoxCus3.UnderlinedStyle = true;
            // 
            // buttonCus1
            // 
            buttonCus1.BackColor = Color.FromArgb(251, 133, 0);
            buttonCus1.BackgroundColor = Color.FromArgb(251, 133, 0);
            buttonCus1.BorderColor = Color.FromArgb(251, 133, 0);
            buttonCus1.BorderRadius = 10;
            buttonCus1.BorderSize = 0;
            buttonCus1.FlatAppearance.BorderSize = 0;
            buttonCus1.FlatStyle = FlatStyle.Flat;
            buttonCus1.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCus1.ForeColor = Color.White;
            buttonCus1.Location = new Point(452, 585);
            buttonCus1.Name = "buttonCus1";
            buttonCus1.Size = new Size(174, 37);
            buttonCus1.TabIndex = 4;
            buttonCus1.Text = "Sign Up!";
            buttonCus1.TextColor = Color.White;
            buttonCus1.UseVisualStyleBackColor = false;
            // 
            // nameTB
            // 
            nameTB.BackColor = Color.FromArgb(2, 48, 71);
            nameTB.BorderColor = Color.FromArgb(250, 240, 202);
            nameTB.BorderFocusColor = Color.FromArgb(251, 133, 0);
            nameTB.BorderRadius = 0;
            nameTB.BorderSize = 4;
            nameTB.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            nameTB.ForeColor = Color.DimGray;
            nameTB.Location = new Point(455, 169);
            nameTB.Multiline = false;
            nameTB.Name = "nameTB";
            nameTB.Padding = new Padding(10, 7, 10, 7);
            nameTB.PasswordChar = false;
            nameTB.PlaceholderColor = Color.DarkGray;
            nameTB.PlaceholderText = "Name";
            nameTB.Size = new Size(497, 32);
            nameTB.TabIndex = 5;
            nameTB.UnderlinedStyle = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(455, 370);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(736, 374);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 19);
            listBox1.TabIndex = 7;
            // 
            // SignUp
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(2, 48, 71);
            ClientSize = new Size(1264, 749);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(nameTB);
            Controls.Add(buttonCus1);
            Controls.Add(textBoxCus3);
            Controls.Add(textBoxCus2);
            Controls.Add(textBoxCus1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SignUp";
            Text = "SignUp";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Custom_Properties.TextBoxCus textBoxCus1;
        private Custom_Properties.TextBoxCus textBoxCus2;
        private Custom_Properties.TextBoxCus textBoxCus3;
        private Custom_Properties.ButtonCus buttonCus1;
        private Custom_Properties.GradientCus gradientCus1;
        private Custom_Properties.TextBoxCus nameTB;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
    }
}