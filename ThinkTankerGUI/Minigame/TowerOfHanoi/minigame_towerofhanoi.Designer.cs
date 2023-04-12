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
            Disk2 = new PictureBox();
            Disk1 = new PictureBox();
            Disk0 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pole1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pole2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pole3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Disk0).BeginInit();
            SuspendLayout();
            // 
            // Pole1
            // 
            Pole1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Pole1.BackColor = Color.Chocolate;
            Pole1.Location = new Point(323, 337);
            Pole1.Name = "Pole1";
            Pole1.Size = new Size(34, 274);
            Pole1.TabIndex = 0;
            Pole1.TabStop = false;
            // 
            // Pole2
            // 
            Pole2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Pole2.BackColor = Color.Chocolate;
            Pole2.Location = new Point(623, 337);
            Pole2.Name = "Pole2";
            Pole2.Size = new Size(34, 274);
            Pole2.TabIndex = 1;
            Pole2.TabStop = false;
            // 
            // Pole3
            // 
            Pole3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Pole3.BackColor = Color.Chocolate;
            Pole3.Location = new Point(923, 337);
            Pole3.Name = "Pole3";
            Pole3.Size = new Size(34, 274);
            Pole3.TabIndex = 2;
            Pole3.TabStop = false;
            // 
            // Disk2
            // 
            Disk2.BackColor = Color.SpringGreen;
            Disk2.Location = new Point(222, 573);
            Disk2.Name = "Disk2";
            Disk2.Size = new Size(235, 38);
            Disk2.TabIndex = 3;
            Disk2.TabStop = false;
            // 
            // Disk1
            // 
            Disk1.BackColor = Color.DodgerBlue;
            Disk1.Location = new Point(243, 535);
            Disk1.Name = "Disk1";
            Disk1.Size = new Size(190, 38);
            Disk1.TabIndex = 4;
            Disk1.TabStop = false;
            // 
            // Disk0
            // 
            Disk0.BackColor = Color.Crimson;
            Disk0.Location = new Point(268, 497);
            Disk0.Name = "Disk0";
            Disk0.Size = new Size(145, 38);
            Disk0.TabIndex = 5;
            Disk0.TabStop = false;
            // 
            // minigame_towerofhanoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(1264, 681);
            Controls.Add(Disk0);
            Controls.Add(Disk1);
            Controls.Add(Disk2);
            Controls.Add(Pole3);
            Controls.Add(Pole2);
            Controls.Add(Pole1);
            Name = "minigame_towerofhanoi";
            Load += minigame_towerofhanoi_Load;
            ((System.ComponentModel.ISupportInitialize)Pole1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pole2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pole3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Disk0).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Pole1;
        private PictureBox Pole2;
        private PictureBox Pole3;
        private PictureBox Disk2;
        private PictureBox Disk1;
        private PictureBox Disk0;
    }
}