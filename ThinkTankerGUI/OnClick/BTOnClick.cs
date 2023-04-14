using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerGUI.TowerOfHanoi;
using ThinkTankerGUI.MatchingGame;

namespace ThinkTankerGUI.OnClick
{
    public partial class BTOnClick : Form
    {
        public static Form1 matchingGame = new();
        public static TowerOfHanoiBT TOH = new();
        public BTOnClick()
        {
            InitializeComponent();
        }

        private void BTOnClick_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }

        private void TOHB_Click(object sender, EventArgs e)
        {
            this.Hide();
            BTOnClick.TOH.ShowDialog(this);
            this.Show();
        }

        private void MatchMB_Click(object sender, EventArgs e)
        {
            this.Hide();
            BTOnClick.matchingGame.ShowDialog(this);
            this.Show();
        }
    }
}
