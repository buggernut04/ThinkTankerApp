using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TowerOfHanoi.Pole Pole1 = new TowerOfHanoi.Pole(new Point(370, 276));
            TowerOfHanoi.Pole Pole2 = new TowerOfHanoi.Pole(new Point(520, 276));
            TowerOfHanoi.Pole Pole3 = new TowerOfHanoi.Pole(new Point(670, 276));

            TowerOfHanoi.Disk Disk1 = new TowerOfHanoi.Disk(1);
            TowerOfHanoi.Disk Disk2 = new TowerOfHanoi.Disk(2);
            TowerOfHanoi.Disk Disk3 = new TowerOfHanoi.Disk(3);

            Pole1.DiskStack.Push(Disk1);
            Pole1.DiskStack.Push(Disk2);
            Pole1.DiskStack.Push(Disk3);

            //Disk1.SetPictureBox(Disk1);
        }


        private void usernameLB_Click(object sender, EventArgs e)
        {

        }

        private void buttonCus1_Click(object sender, EventArgs e)
        {

        }

        private void BrainTeasersB_Click(object sender, EventArgs e)
        {
            //this.RestartGame();
            this.Close();
        }

        private void TowerOfHanoiBT_Load(object sender, EventArgs e)
        {

        }
    }
}
