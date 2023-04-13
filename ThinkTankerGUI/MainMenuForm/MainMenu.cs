﻿using BrainProbe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerGUI.MatchingGame;

namespace ThinkTankerGUI.MainMenuForm
{

    public partial class MainMenu : Form
    {
        public static Form1 matchGame = new();
        public static dashboardForm dashBoardForm = new();
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //this.Owner.Hide();
        }

        private void BrainTeasersB_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            MainMenu.matchGame.ShowDialog(this);
            this.Show();*/
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrainProbeB_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.dashBoardForm.ShowDialog(this);
            this.Show();
        }
    }
}
