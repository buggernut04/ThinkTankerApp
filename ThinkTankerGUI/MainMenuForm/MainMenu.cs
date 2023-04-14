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
using ThinkTankerGUI.MatchingGame;
using ThinkTankerGUI.BrainProbe;
using ThinkTankerGUI.LogInForm;

namespace ThinkTankerGUI.MainMenuForm
{

    public partial class MainMenu : Form
    {
        public static LogIn logIn = new LogIn();
        public static Form1 matchGame = new();
        public static Dashboard dashBoardForm = new();
        public static BTOnClick BTC = new();
        //public static BPOnClick BPC = new();

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

        private void BrainTeasersB_MouseHover_1(object sender, EventArgs e)
        {
            //Hover Text
            hoverTxt.Text = "A series of minigames\n to practice your \n problem solving skills!";
            hoverTxt.TextAlign = ContentAlignment.MiddleCenter;
            hoverTxt.Font = new Font("Gill Sans MT", 40F, FontStyle.Regular, GraphicsUnit.Point);
            hoverTxt.ForeColor = Color.PeachPuff;
            hoverTxt.Location = new Point(601, 268);

        }

        private void BrainTeasersB_MouseLeave_1(object sender, EventArgs e)
        {
            hoverTxt.Text = "";
        }

        private void BrainProbeB_Click(object sender, EventArgs e)
        {
            MainMenu.dashBoardForm.ShowDialog(this);
            this.ShowDialog();
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

        private void ExitB_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu.logIn.ShowDialog(this);
            this.Show();
        }
    }
}
