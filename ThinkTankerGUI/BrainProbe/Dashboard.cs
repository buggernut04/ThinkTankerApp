namespace ThinkTankerGUI.BrainProbe
{
    public partial class Dashboard : Form
    {
        int seconds;
        private bool isPaused;
        public Dashboard()
        {
            InitializeComponent();
            easyForm1.Visible = false;
            moderateForm1.Visible = false;
            difficultForm1.Visible = false;
            scoreForm1.Visible = false;
            timerLabel.Visible = false;
            pauseBT.Visible = false;
            exitBT.Visible = false;
            outBT.Visible = true;
        }

        private void quiztimer_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                // Decrement the remaining time and update the timer label
                scoreForm1.Visible = false;
                seconds--;
                timerLabel.Text = $"{seconds / 60:00}:{seconds % 60:00}";

                if (seconds == 0 || GetScore() == 10)
                {
                    // Stop the timer and end the quiz if time is up
                    scoreForm1.ScoreLabel(GetScore(), seconds);
                    quiztimer.Stop();
                    closeForm();
                    scoreForm1.Visible = true;
                    easyForm1.resetScore();
                    moderateForm1.resetScore();
                    difficultForm1.resetScore();
                }
            }
        }
        private int GetScore()
        {
            int finalScore = 0;
            if (easyForm1.Visible == true)
                finalScore = easyForm1.easyScore;
            if (moderateForm1.Visible == true)
                finalScore = moderateForm1.moderateScore;
            if (difficultForm1.Visible == true)
                finalScore = difficultForm1.difficultScore;
            return finalScore;

        }

        public void DisplayScore(int score, int time)
        {
            scoreForm1.ScoreLabel(score, time);
            scoreForm1.Visible = true;
            quiztimer.Stop();
            pauseBT.Visible = false;

        }

        private void easyBT_Click(object sender, EventArgs e)
        {
            startQuiz();
            restart_Time();
            pauseBT.Visible = true;
            timerLabel.Visible = true;
            seconds = 1800;
            quiztimer.Start();

            reset();
            restart_Time();
            easyForm1.easyForm_isOpen = true;
            easyForm1.resetScore();

            openForm();

            scoreForm1.Visible = true;
        }

        private void moderateBT_Click(object sender, EventArgs e)
        {
            startQuiz();
            restart_Time();
            pauseBT.Visible = true;
            timerLabel.Visible = true;
            seconds = 1500;
            quiztimer.Start();

            reset();
            moderateForm1.moderateForm_isOpen = true;
            openForm();

            moderateForm1.resetScore();
            scoreForm1.Visible = true;
        }

        private void difficultBT_Click(object sender, EventArgs e)
        {
            startQuiz();
            restart_Time();
            pauseBT.Visible = true;
            timerLabel.Visible = true;
            seconds = 1200;
            quiztimer.Start();

            reset();
            difficultForm1.difficult_isOpen = true;
            openForm();

            difficultForm1.resetScore();
            scoreForm1.Visible = true;
        }

        private void pauseBT_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                // Pause the timer and update the button text
                isPaused = true;
                pauseBT.Text = "Resume";
                closeForm();
                scoreForm1.paused();
                scoreForm1.Visible = true;
            }
            else
            {
                // Resume the timer and update the button text
                restart_Time();
                openForm();
                scoreForm1.Visible = false;

            }
        }

        private void openForm()
        {
            if (easyForm1.easyForm_isOpen)
            {
                easyForm1.Visible = true;
                moderateForm1.Visible = false;
                difficultForm1.Visible = false;

                moderateForm1.moderateForm_isOpen = false;
                difficultForm1.difficult_isOpen = false;
            }
            if (moderateForm1.moderateForm_isOpen)
            {
                moderateForm1.Visible = true;
                easyForm1.Visible = false;
                difficultForm1.Visible = false;

                easyForm1.easyForm_isOpen = false;
                difficultForm1.difficult_isOpen = false;
            }
            if (difficultForm1.difficult_isOpen)
            {
                difficultForm1.Visible = true;
                easyForm1.Visible = false;
                moderateForm1.Visible = false;

                easyForm1.easyForm_isOpen = false;
                moderateForm1.moderateForm_isOpen = false;

            }
        }

        private void closeForm()
        {
            if (easyForm1.easyForm_isOpen)
            {
                easyForm1.Visible = false;

                moderateForm1.moderateForm_isOpen = false;
                difficultForm1.difficult_isOpen = false;
            }
            if (moderateForm1.moderateForm_isOpen)
            {
                moderateForm1.Visible = false;

                easyForm1.easyForm_isOpen = false;
                difficultForm1.difficult_isOpen = false;
            }
            if (difficultForm1.difficult_isOpen)
            {
                difficultForm1.Visible = false;

                easyForm1.easyForm_isOpen = false;
                moderateForm1.moderateForm_isOpen = false;
            }
        }

        private void reset()
        {
            easyForm1.easyForm_isOpen = false;
            moderateForm1.moderateForm_isOpen = false;
            difficultForm1.difficult_isOpen = false;
        }

        private void restart_Time()
        {
            isPaused = false;
            pauseBT.Text = "Pause";
        }

        private void startQuiz()
        {
            outBT.Visible = false;
            exitBT.Visible = true;
            easyBT.Visible = false;
            moderateBT.Visible = false;
            difficultBT.Visible = false;

        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            outBT.Visible = true;
            exitBT.Visible = false;
            easyBT.Visible = true;
            moderateBT.Visible = true;
            difficultBT.Visible = true;

            reset();
            easyForm1.Visible = false;
            moderateForm1.Visible = false;
            difficultForm1.Visible = false;

            quiztimer.Stop();
            timerLabel.Visible = false;
            pauseBT.Visible = false;
            scoreForm1.Visible = false;

        }

        private void outBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }
    }
}