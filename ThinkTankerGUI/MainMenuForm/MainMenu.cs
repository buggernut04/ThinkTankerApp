using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerGUI.Minigame;

namespace ThinkTankerGUI.MainMenuForm
{

    public partial class MainMenu : Form
    {
        public static minigame_towerofhanoi TOH = new();

        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void BrainTeasersB_Click(object sender, EventArgs e)
        {
            MainMenu.TOH.ShowDialog(this);
            this.Show();
        }
    }
}
