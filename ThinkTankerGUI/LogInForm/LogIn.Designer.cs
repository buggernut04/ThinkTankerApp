﻿namespace ThinkTankerGUI.LogInForm;

partial class LogIn
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
        Label SignUp;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
        Label = new Label();
        usernameTB = new Custom_Properties.TextBoxCus();
        passwordTB = new Custom_Properties.TextBoxCus();
        signInB = new Custom_Properties.ButtonCus();
        pictureBox1 = new PictureBox();
        SignUp = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // SignUp
        // 
        SignUp.AutoSize = true;
        SignUp.BackColor = Color.FromArgb(2, 48, 71);
        SignUp.Font = new Font("Gill Sans MT", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
        SignUp.ForeColor = Color.FromArgb(251, 133, 0);
        SignUp.Location = new Point(707, 674);
        SignUp.Name = "SignUp";
        SignUp.Size = new Size(89, 34);
        SignUp.TabIndex = 4;
        SignUp.Text = "SignUp!";
        SignUp.TextAlign = ContentAlignment.MiddleLeft;
        SignUp.Click += SignUp_Click;
        // 
        // Label
        // 
        Label.AutoSize = true;
        Label.Font = new Font("Gill Sans MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
        Label.ForeColor = Color.FromArgb(255, 247, 237);
        Label.Location = new Point(515, 674);
        Label.Name = "Label";
        Label.Size = new Size(256, 34);
        Label.TabIndex = 3;
        Label.Text = "Don't Have an Account?";
        // 
        // usernameTB
        // 
        usernameTB.BackColor = Color.Linen;
        usernameTB.BorderColor = Color.Linen;
        usernameTB.BorderFocusColor = Color.FromArgb(251, 133, 0);
        usernameTB.BorderRadius = 10;
        usernameTB.BorderSize = 2;
        usernameTB.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        usernameTB.ForeColor = Color.FromArgb(2, 48, 71);
        usernameTB.Location = new Point(501, 473);
        usernameTB.Multiline = true;
        usernameTB.Name = "usernameTB";
        usernameTB.Padding = new Padding(10, 7, 10, 7);
        usernameTB.PasswordChar = false;
        usernameTB.PlaceholderColor = Color.DimGray;
        usernameTB.PlaceholderText = "username";
        usernameTB.Size = new Size(291, 37);
        usernameTB.TabIndex = 1;
        usernameTB.UnderlinedStyle = false;
        // 
        // passwordTB
        // 
        passwordTB.BackColor = Color.Linen;
        passwordTB.BorderColor = Color.Linen;
        passwordTB.BorderFocusColor = Color.FromArgb(251, 133, 0);
        passwordTB.BorderRadius = 10;
        passwordTB.BorderSize = 2;
        passwordTB.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        passwordTB.ForeColor = Color.FromArgb(2, 48, 71);
        passwordTB.Location = new Point(501, 527);
        passwordTB.Multiline = false;
        passwordTB.Name = "passwordTB";
        passwordTB.Padding = new Padding(10, 7, 10, 7);
        passwordTB.PasswordChar = true;
        passwordTB.PlaceholderColor = Color.DimGray;
        passwordTB.PlaceholderText = "password";
        passwordTB.Size = new Size(291, 42);
        passwordTB.TabIndex = 2;
        passwordTB.UnderlinedStyle = false;
        // 
        // signInB
        // 
        signInB.BackColor = Color.FromArgb(251, 133, 0);
        signInB.BackgroundColor = Color.FromArgb(251, 133, 0);
        signInB.BorderColor = Color.Transparent;
        signInB.BorderRadius = 5;
        signInB.BorderSize = 0;
        signInB.FlatAppearance.BorderSize = 0;
        signInB.FlatStyle = FlatStyle.Flat;
        signInB.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
        signInB.ForeColor = Color.PapayaWhip;
        signInB.Location = new Point(501, 601);
        signInB.Name = "signInB";
        signInB.Size = new Size(291, 36);
        signInB.TabIndex = 3;
        signInB.Text = "SIGN IN";
        signInB.TextColor = Color.PapayaWhip;
        signInB.UseVisualStyleBackColor = false;
        signInB.Click += signInB_Click_1;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(364, 115);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(574, 249);
        pictureBox1.TabIndex = 5;
        pictureBox1.TabStop = false;
        // 
        // LogIn
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(2, 48, 71);
        ClientSize = new Size(1264, 749);
        Controls.Add(pictureBox1);
        Controls.Add(signInB);
        Controls.Add(passwordTB);
        Controls.Add(usernameTB);
        Controls.Add(SignUp);
        Controls.Add(Label);
        Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LogIn";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "LogIn";
        FormClosing += LogIn_FormClosing;
        Load += LogIn_Load;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label Label;
    private Label SignUp;
    private Custom_Properties.TextBoxCus usernameTB;
    private Custom_Properties.TextBoxCus passwordTB;
    private Custom_Properties.ButtonCus signInB;
    private PictureBox pictureBox1;
}