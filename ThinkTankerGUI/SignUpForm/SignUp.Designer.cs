namespace ThinkTankerGUI.SignUpForm
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
            userNameTB = new Custom_Properties.TextBoxCus();
            passwordTB = new Custom_Properties.TextBoxCus();
            conpasswordTB = new Custom_Properties.TextBoxCus();
            signUp_button = new Custom_Properties.ButtonCus();
            nameTB = new Custom_Properties.TextBoxCus();
            birthDatePicker = new DateTimePicker();
            sexBttn = new ListBox();
            label2 = new Label();
            label3 = new Label();
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
            // userNameTB
            // 
            userNameTB.BackColor = Color.FromArgb(2, 48, 71);
            userNameTB.BorderColor = Color.FromArgb(250, 240, 202);
            userNameTB.BorderFocusColor = Color.FromArgb(251, 133, 0);
            userNameTB.BorderRadius = 0;
            userNameTB.BorderSize = 4;
            userNameTB.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTB.ForeColor = Color.DimGray;
            userNameTB.Location = new Point(455, 261);
            userNameTB.Multiline = false;
            userNameTB.Name = "userNameTB";
            userNameTB.Padding = new Padding(10, 7, 10, 7);
            userNameTB.PasswordChar = false;
            userNameTB.PlaceholderColor = Color.DarkGray;
            userNameTB.PlaceholderText = "Username";
            userNameTB.Size = new Size(500, 36);
            userNameTB.TabIndex = 1;
            userNameTB.UnderlinedStyle = true;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.FromArgb(2, 48, 71);
            passwordTB.BorderColor = Color.FromArgb(250, 240, 202);
            passwordTB.BorderFocusColor = Color.FromArgb(251, 133, 0);
            passwordTB.BorderRadius = 0;
            passwordTB.BorderSize = 4;
            passwordTB.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTB.ForeColor = Color.DimGray;
            passwordTB.Location = new Point(455, 441);
            passwordTB.Multiline = false;
            passwordTB.Name = "passwordTB";
            passwordTB.Padding = new Padding(10, 7, 10, 7);
            passwordTB.PasswordChar = false;
            passwordTB.PlaceholderColor = Color.DarkGray;
            passwordTB.PlaceholderText = "Password";
            passwordTB.Size = new Size(500, 36);
            passwordTB.TabIndex = 2;
            passwordTB.UnderlinedStyle = true;
            // 
            // conpasswordTB
            // 
            conpasswordTB.BackColor = Color.FromArgb(2, 48, 71);
            conpasswordTB.BorderColor = Color.FromArgb(250, 240, 202);
            conpasswordTB.BorderFocusColor = Color.FromArgb(251, 133, 0);
            conpasswordTB.BorderRadius = 0;
            conpasswordTB.BorderSize = 4;
            conpasswordTB.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            conpasswordTB.ForeColor = Color.DimGray;
            conpasswordTB.Location = new Point(455, 524);
            conpasswordTB.Multiline = false;
            conpasswordTB.Name = "conpasswordTB";
            conpasswordTB.Padding = new Padding(10, 7, 10, 7);
            conpasswordTB.PasswordChar = false;
            conpasswordTB.PlaceholderColor = Color.DarkGray;
            conpasswordTB.PlaceholderText = "Confirm Password";
            conpasswordTB.Size = new Size(500, 36);
            conpasswordTB.TabIndex = 3;
            conpasswordTB.UnderlinedStyle = true;
            // 
            // signUp_button
            // 
            signUp_button.BackColor = Color.FromArgb(251, 133, 0);
            signUp_button.BackgroundColor = Color.FromArgb(251, 133, 0);
            signUp_button.BorderColor = Color.FromArgb(251, 133, 0);
            signUp_button.BorderRadius = 10;
            signUp_button.BorderSize = 0;
            signUp_button.FlatAppearance.BorderSize = 0;
            signUp_button.FlatStyle = FlatStyle.Flat;
            signUp_button.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            signUp_button.ForeColor = Color.White;
            signUp_button.Location = new Point(455, 623);
            signUp_button.Name = "signUp_button";
            signUp_button.Size = new Size(497, 37);
            signUp_button.TabIndex = 4;
            signUp_button.Text = "Sign Up!";
            signUp_button.TextColor = Color.White;
            signUp_button.UseVisualStyleBackColor = false;
            signUp_button.Click += signUp_button_Click;
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
            nameTB.Size = new Size(497, 36);
            nameTB.TabIndex = 5;
            nameTB.UnderlinedStyle = true;
            // 
            // birthDatePicker
            // 
            birthDatePicker.CalendarFont = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            birthDatePicker.CalendarForeColor = SystemColors.ControlDark;
            birthDatePicker.CalendarMonthBackground = SystemColors.MenuBar;
            birthDatePicker.CalendarTitleForeColor = SystemColors.WindowFrame;
            birthDatePicker.CustomFormat = "dd-MM-yyyy";
            birthDatePicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            birthDatePicker.Format = DateTimePickerFormat.Custom;
            birthDatePicker.Location = new Point(455, 374);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(227, 29);
            birthDatePicker.TabIndex = 6;
            // 
            // sexBttn
            // 
            sexBttn.BackColor = SystemColors.MenuBar;
            sexBttn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            sexBttn.ForeColor = SystemColors.WindowFrame;
            sexBttn.FormattingEnabled = true;
            sexBttn.IntegralHeight = false;
            sexBttn.ItemHeight = 21;
            sexBttn.Items.AddRange(new object[] { "Choose", "Male", "Female" });
            sexBttn.Location = new Point(742, 374);
            sexBttn.Name = "sexBttn";
            sexBttn.Size = new Size(213, 25);
            sexBttn.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(461, 349);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 10;
            label2.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(745, 348);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 11;
            label3.Text = "Sex";
            // 
            // SignUp
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(2, 48, 71);
            ClientSize = new Size(1264, 749);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sexBttn);
            Controls.Add(birthDatePicker);
            Controls.Add(nameTB);
            Controls.Add(signUp_button);
            Controls.Add(conpasswordTB);
            Controls.Add(passwordTB);
            Controls.Add(userNameTB);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SignUp";
            Text = "SignUp";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Custom_Properties.TextBoxCus userNameTB;
        private Custom_Properties.TextBoxCus passwordTB;
        private Custom_Properties.TextBoxCus conpasswordTB;
        private Custom_Properties.ButtonCus signUp_button;
        private Custom_Properties.GradientCus gradientCus1;
        private Custom_Properties.TextBoxCus nameTB;
        private DateTimePicker birthDatePicker;
        private ListBox sexBttn;
        private Label label2;
        private Label label3;
    }
}