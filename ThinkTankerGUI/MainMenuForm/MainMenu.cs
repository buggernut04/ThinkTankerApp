using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerGUI.OnClick;
using ThinkTankerGUI.TowerOfHanoi;
using ThinkTankerGUI.OnClick;

namespace ThinkTankerGUI.MainMenuForm
{

    public partial class MainMenu : Form
    {
        public static TowerOfHanoiBT TOH = new();
        public static BTOnClick BTC = new();
        public static BPOnClick BPC = new();

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
            MainMenu.BTC.ShowDialog(this);
            this.ShowDialog();
        }

        private void BrainTeasersB_MouseHover(object sender, EventArgs e)
        {
            //Hover Text
            hoverTxt.Text = "A series of minigames\n to practice your \n problem solving skills!";
            hoverTxt.TextAlign = ContentAlignment.MiddleCenter;
            hoverTxt.Font = new Font("Gill Sans MT", 40F, FontStyle.Regular, GraphicsUnit.Point);
            hoverTxt.ForeColor = Color.PeachPuff;
            hoverTxt.Location = new Point(601, 268);
        }


        private void BrainProbeB_MouseLeave(object sender, EventArgs e)
        {
            hoverTxt.Text = "";
        }

        private void BrainProbeB_Click(object sender, EventArgs e)
        {
            MainMenu.BPC.ShowDialog(this);
            this.ShowDialog();
        }
    }
}
