using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using ThinkTankerGUI.MatchingGame.Properties;

namespace ThinkTankerGUI.MatchingGame
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private TimeSpan pausedTime;
        private TimeSpan elapsed;

        private int flag = 0;
        private int flag1 = 0;
        private int pair = 0;
        private int win = 0;
        private int ctr = 25;

        private Timer timer = new Timer();

        List<Bitmap> pictures = new List<Bitmap>()
        {
            Properties.Resources.devil,Properties.Resources.devil,Properties.Resources.sailors,Properties.Resources.sailors,
            Properties.Resources.scary,Properties.Resources.scary,Properties.Resources.zombie,Properties.Resources.zombie,
            Properties.Resources.trick,Properties.Resources.trick,Properties.Resources.wizard,Properties.Resources.wizard,
            Properties.Resources.bat,Properties.Resources.bat,Properties.Resources.owl,Properties.Resources.owl
        };

        PictureBox first, second;

        bool done = false;

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(Timer_Tick);

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsed = DateTime.Now - startTime - pausedTime;
            string timeElapsedString = elapsed.ToString(@"mm\:ss");
            label1.Text = "Time elapsed: " + timeElapsedString;
            label2.Text = "Paired: " + pair.ToString();
            label5.Text = "Moves: " + ctr.ToString();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (win == 0)
            {
                if (timer.Enabled)
                {
                    pausedTime += DateTime.Now - startTime;
                    timer.Stop();
                    flag = 1;
                    flag1 = 1;
                }
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (win == 0)
            {
                if (!timer.Enabled)
                {
                    if (elapsed > TimeSpan.Zero)
                    {
                        startTime = DateTime.Now - elapsed - pausedTime;
                        flag = 0;
                        flag1 = 0;
                        timer.Start();
                    }
                }
            }
        }


        private void AssignImages()
        {
            Random r = new Random();

            for (int i = 0; i < 16; i++)
            {
                Tags(i);
            }

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    int j = r.Next(pictures.Count);
                    PictureBox p = (PictureBox)c;
                    p.InitialImage = pictures[j];
                    p.Tag = pictures[j].Tag;
                    pictures.RemoveAt(j);
                }
            }
        }
        private void Tags(int index)
        {
            switch (index)
            {
                case 0:
                case 1:
                    pictures[index].Tag = "devil";
                    break;
                case 2:
                case 3:
                    pictures[index].Tag = "sailors";
                    break;
                case 4:
                case 5:
                    pictures[index].Tag = "scary";
                    break;
                case 6:
                case 7:
                    pictures[index].Tag = "zombie";
                    break;
                case 8:
                case 9:
                    pictures[index].Tag = "trick";
                    break;
                case 10:
                case 11:
                    pictures[index].Tag = "wizard";
                    break;
                case 12:
                case 13:
                    pictures[index].Tag = "bat";
                    break;
                case 14:
                case 15:
                    pictures[index].Tag = "owl";
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AssignImages();
        }

        private void Timer(object sender, EventArgs e)
        {
            timer1.Stop();

            if (first.Tag.ToString() == second.Tag.ToString())
            {
                CheckForWinner();
                if (ctr < 25)
                {
                    ctr++;
                }

            }
            else if (first.Tag.ToString() != second.Tag.ToString())
            {
                first.BackgroundImage = null;
                second.BackgroundImage = null;
                ctr--;
            }
            first = null;
            second = null;
            done = false;
        }

        private void picture_Click(object sender, EventArgs e)
        {
            if (flag1 == 0)
            {
                PictureBox cast = (PictureBox)sender;

                if (flag == 0)
                {
                    startTime = DateTime.Now;
                    timer.Start();
                }

                if (elapsed > TimeSpan.Zero)
                {
                    startTime = DateTime.Now - elapsed - pausedTime;
                    timer.Start();
                }


                if (cast.BackgroundImage == null && done == false)
                {
                    if (first == null)
                    {
                        first = cast;
                        first.BackgroundImage = first.InitialImage;
                        flag = 1;
                        return;
                    }

                    second = cast;
                    second.BackgroundImage = second.InitialImage;
                    done = true;
                    timer1.Start();
                }
            }

            if (ctr == 0)
            {
                label5.Text = "Moves: " + ctr.ToString();
                timer.Stop();
                flag = 1;
                flag1 = 1;
                MessageBox.Show("You Loose RESET THE GAME!");
                win = 1;
            }
        }

        private void ResetG()
        {

            // Clear backgrounds
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.BackgroundImage = null;
                }
            }

            // Re-assign images randomly
            pictures = new List<Bitmap>()
            {
                Properties.Resources.devil,Properties.Resources.devil,Properties.Resources.sailors,Properties.Resources.sailors,
                Properties.Resources.scary,Properties.Resources.scary,Properties.Resources.zombie,Properties.Resources.zombie,
                Properties.Resources.trick,Properties.Resources.trick,Properties.Resources.wizard,Properties.Resources.wizard,
                Properties.Resources.bat,Properties.Resources.bat,Properties.Resources.owl,Properties.Resources.owl
            };
            AssignImages();
            label1.Text = "Time elapsed: 00:00";
            label2.Text = "Paired: " + pair.ToString();
            label5.Text = "Moves: " + ctr.ToString();

        }

        private void ResetGame_Click(object sender, EventArgs e)
        {
            timer.Stop();
            pausedTime = TimeSpan.Zero;
            elapsed = TimeSpan.Zero;
            pair = 0;
            flag = 0;
            flag1 = 0;
            win = 0;
            ctr = 25;
            progressBar1.Value = 0;
            ResetG();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CheckForWinner()
        {
            bool allMatched = true;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    if (pb.BackgroundImage == null)
                    {
                        allMatched = false;
                        break;
                    }
                }
            }
            pair++;
            progressBar1.Value = pair;

            if (allMatched)
            {
                label2.Text = "Paired: " + pair.ToString();
                timer.Stop();
                flag = 0;
                flag1 = 0;
                MessageBox.Show("Congratulations," + " You Won in just " + elapsed.ToString(@"mm\:ss") + " seconds!");
                win = 1;
            }

        }

        private void extbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
