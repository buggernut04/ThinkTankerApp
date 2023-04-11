using Study_Application.Forms.SignUpForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Study_Application.Forms.MainMenuForm
{
    public partial class MainMenu : Form
    {
        public static minigame_towerofhanoi TOH = new();
        public static BrainProbe brainprobe = new();

        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void textBoxCus1_Load(object sender, EventArgs e)
        {

        }
        private void textBoxCus1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonCus2_Click(object sender, EventArgs e)
        {
            MainMenu.brainprobe.ShowDialog(this);
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientCus1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrainTeasers_MouseClick(object sender, MouseEventArgs e)
        {
            MainMenu.TOH.ShowDialog(this);
            this.Show();
        }
    }
}
