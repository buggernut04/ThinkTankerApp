using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerApp;
using ThinkTankerGUI.Minigame.TowerOfHanoi;

namespace ThinkTankerGUI.Minigame
{
    public partial class minigame_towerofhanoi : Form
    {
        public minigame_towerofhanoi()
        {
            InitializeComponent();
        }

        private void minigame_towerofhanoi_Load(object sender, EventArgs e)
        {
            Disk disk0 = new Disk(0);
            Disk disk1 = new Disk(1);
            Disk disk2 = new Disk(2);

            disk0.SetPictureBox(Disk0);
            disk1.SetPictureBox(Disk1);
            disk2.SetPictureBox(Disk2);

            Pole pole1 = new Pole(1);
            Pole pole2 = new Pole(2);
            Pole pole3 = new Pole(3);

            pole1.SetPictureBox(Pole1);
            pole2.SetPictureBox(Pole2);
            pole3.SetPictureBox(Pole3);
        }

    }
}

