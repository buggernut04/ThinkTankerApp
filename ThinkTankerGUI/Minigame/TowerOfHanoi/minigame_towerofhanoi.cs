using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Application.Forms
{
    public partial class minigame_towerofhanoi : Form
    {
        private bool oneismoving;
        private Point onestartLocation;
        private bool twoismoving;
        private Point twostartLocation;
        private bool threeismoving;
        private Point threestartLocation;

        public minigame_towerofhanoi()
        {
            InitializeComponent();
        }

        private void Disk1_MouseDown(object sender, MouseEventArgs e)
        {
            oneismoving = true;
            onestartLocation = e.Location;
        }

        private void Disk1_MouseMove(object sender, MouseEventArgs e)
        {
            if (oneismoving)
            {
                Disk1.Left += e.Location.X - onestartLocation.X;
                Disk1.Top += e.Location.Y - onestartLocation.Y;
            }
        }

        private void Disk1_MouseUp(object sender, MouseEventArgs e)
        {
            oneismoving = false;
        }

        private void Disk2_MouseDown(object sender, MouseEventArgs e)
        {
            twoismoving = true;
            twostartLocation = e.Location;
        }

        private void Disk2_MouseMove(object sender, MouseEventArgs e)
        {
            if (twoismoving)
            {
                Disk1.Left += e.Location.X - twostartLocation.X;
                Disk1.Top += e.Location.Y - twostartLocation.Y;
            }
        }

        private void Disk2_MouseUp(object sender, MouseEventArgs e)
        {
            twoismoving = false;
        }

        private void Disk3_MouseDown(object sender, MouseEventArgs e)
        {
            threeismoving = true;
            threestartLocation = e.Location;
        }

        private void Disk3_MouseMove(object sender, MouseEventArgs e)
        {
            if (threeismoving)
            {
                Disk1.Left += e.Location.X - threestartLocation.X;
                Disk1.Top += e.Location.Y - threestartLocation.Y;
            }
        }

        private void Disk3_MouseUp(object sender, MouseEventArgs e)
        {
            threeismoving = false;
        }


    }
}

