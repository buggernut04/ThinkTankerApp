﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerGUI.LogInForm;
using ThinkTankerGUI.MainMenuForm;

namespace ThinkTankerGUI.TowerOfHanoi
{
    public partial class TowerOfHanoiBT : Form
    {
        public TowerOfHanoiBT()
        {
            InitializeComponent();
            InitializeGame();

        }

        private void InitializeGame()
        {
            TowerOfHanoi.Pole Pole1 = new TowerOfHanoi.Pole(new Point(566, 398));
            TowerOfHanoi.Pole Pole2 = new TowerOfHanoi.Pole(new Point(807, 398));
            TowerOfHanoi.Pole Pole3 = new TowerOfHanoi.Pole(new Point(1060, 398));

            TowerOfHanoi.Disk Disk1 = new TowerOfHanoi.Disk(1);
            TowerOfHanoi.Disk Disk2 = new TowerOfHanoi.Disk(2);
            TowerOfHanoi.Disk Disk3 = new TowerOfHanoi.Disk(3);

            Pole1.DiskStack.Push(Disk1);
            Pole1.DiskStack.Push(Disk2);
            Pole1.DiskStack.Push(Disk3);
        }


        private void usernameLB_Click(object sender, EventArgs e)
        {

        }

        private void buttonCus1_Click(object sender, EventArgs e)
        {

        }

        private void BrainTeasersB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TowerOfHanoiBT_Load(object sender, EventArgs e)
        {

        }


        private void Pole2_Click(object sender, EventArgs e)
        {

        }

        private void Disk3_Click(object sender, EventArgs e)
        {

        }

        private void Disk1_Click(object sender, EventArgs e)
        {

        }

        private void RestartBTN_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}
