using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainProbe
{
    public partial class ScoreForm : UserControl
    {
        public ScoreForm()
        {
            InitializeComponent();
        }
        public void ScoreLabel(int score, int time)
        {
            scoreFormLabel.Text = $"You're score is {score.ToString()}/10 \n  Time Taken: {time / 60:00}:{time % 60:00}";
        }

        public void paused()
        {
            scoreFormLabel.Text = $"Game is Pause";
        }




    }
}
