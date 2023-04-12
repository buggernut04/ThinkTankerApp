namespace ThinkTankerGUI.Minigame
{
    partial class minigame_towerofhanoi
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
            Pole1 = new PictureBox();
            Pole2 = new PictureBox();
            Pole3 = new PictureBox();
            Disk1 = new PictureBox();
            Disk2 = new PictureBox();
            Disk3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pole1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pole2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pole3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk3).BeginInit();
            SuspendLayout();
            // 
            // Pole1
            // 
            Pole1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Pole1.BackColor = Color.Chocolate;
            Pole1.Location = new Point(389, 359);
            Pole1.Margin = new Padding(3, 4, 3, 4);
            Pole1.Name = "Pole1";
            Pole1.Size = new Size(27, 387);
            Pole1.TabIndex = 0;
            Pole1.TabStop = false;
            // 
            // Pole2
            // 
            Pole2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Pole2.BackColor = Color.Chocolate;
            Pole2.Location = new Point(737, 359);
            Pole2.Margin = new Padding(3, 4, 3, 4);
            Pole2.Name = "Pole2";
            Pole2.Size = new Size(27, 387);
            Pole2.TabIndex = 1;
            Pole2.TabStop = false;
            // 
            // Pole3
            // 
            Pole3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Pole3.BackColor = Color.Chocolate;
            Pole3.Location = new Point(1069, 359);
            Pole3.Margin = new Padding(3, 4, 3, 4);
            Pole3.Name = "Pole3";
            Pole3.Size = new Size(27, 387);
            Pole3.TabIndex = 2;
            Pole3.TabStop = false;
            // 
            // Disk1
            // 
            Disk1.BackColor = Color.SpringGreen;
            Disk1.Location = new Point(248, 695);
            Disk1.Margin = new Padding(3, 4, 3, 4);
            Disk1.Name = "Disk1";
            Disk1.Size = new Size(297, 51);
            Disk1.TabIndex = 3;
            Disk1.TabStop = false;
            Disk1.MouseDown += Disk1_MouseDown;
            Disk1.MouseMove += Disk1_MouseMove;
            Disk1.MouseUp += Disk1_MouseUp;
            // 
            // Disk2
            // 
            Disk2.BackColor = Color.DodgerBlue;
            Disk2.Location = new Point(290, 639);
            Disk2.Margin = new Padding(3, 4, 3, 4);
            Disk2.Name = "Disk2";
            Disk2.Size = new Size(226, 51);
            Disk2.TabIndex = 4;
            Disk2.TabStop = false;
            Disk2.MouseDown += Disk2_MouseDown;
            Disk2.MouseMove += Disk2_MouseMove;
            Disk2.MouseUp += Disk2_MouseUp;
            // 
            // Disk3
            // 
            Disk3.BackColor = Color.Crimson;
            Disk3.Location = new Point(674, 695);
            Disk3.Margin = new Padding(3, 4, 3, 4);
            Disk3.Name = "Disk3";
            Disk3.Size = new Size(160, 51);
            Disk3.TabIndex = 5;
            Disk3.TabStop = false;
            Disk3.MouseDown += Disk3_MouseDown;
            Disk3.MouseMove += Disk3_MouseMove;
            Disk3.MouseUp += Disk3_MouseUp;
            // 
            // minigame_towerofhanoi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(1445, 908);
            Controls.Add(Disk3);
            Controls.Add(Disk2);
            Controls.Add(Disk1);
            Controls.Add(Pole3);
            Controls.Add(Pole2);
            Controls.Add(Pole1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "minigame_towerofhanoi";
            ((System.ComponentModel.ISupportInitialize)Pole1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pole2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pole3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Pole1;
        private PictureBox Pole2;
        private PictureBox Pole3;
        private PictureBox Disk1;
        private PictureBox Disk2;
        private PictureBox Disk3;
    }
}