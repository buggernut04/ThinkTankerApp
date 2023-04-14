using BrainProbe;
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
using ThinkTankerGUI.TowerOfHanoi;

namespace ThinkTankerGUI.MainMenuForm
{

    public partial class MainMenu : Form
    {
        public static Form1 matchGame = new();
        public static dashboardForm dashBoardForm = new();
        public static TowerOfHanoiBT toh = new();
        public MainMenu()
        {
            InitializeComponent();
            buttonCus1.Visible = false;
            buttonCus2.Visible = false;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //this.Owner.Hide();
        }

        private void BrainTeasersB_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            buttonCus1.Visible = true;
            buttonCus2.Visible = true;
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

        private void buttonCus1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.toh.ShowDialog(this);
            this.Show();
            buttonCus1.Visible = false;
            buttonCus2.Visible = false;

        }

        private void buttonCus2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.matchGame.ShowDialog(this);
            this.Show();
            buttonCus1.Visible = false;
            buttonCus2.Visible = false;
        }
    }
}
