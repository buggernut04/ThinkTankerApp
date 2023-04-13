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
using ThinkTankerApp;
using ThinkTankerClasses;

namespace BrainProbe
{
    public partial class DifficultForm : UserControl
    {
        Difficult difficultQuiz = new Difficult();
        int num = 1;
        public int difficultScore { get; private set; }
        public bool difficult_isOpen { get; set; }
        public DifficultForm()
        {
            InitializeComponent();
            difficultQuiz.CreateQuestion();
            askQuestion(difficultQuiz.Items[num - 1].Question);
            this.difficultScore = 0;
            checkPBD.Visible = false;
        }

        private void prevBT_Click(object sender, EventArgs e)
        {
            if (num == 1)
                num = 10;
            else
                num--;

            askQuestion(difficultQuiz.Items[num - 1].Question);
            checkPBD.Visible = difficultQuiz.Items[num - 1].IsCorrectAnswer;
            if (difficultQuiz.Items[num - 1].IsCorrectAnswer)
            {
                easyAnswerTBD.Visible = false;
                checkPBD.Visible = true;
                submitBTD.Visible = false;
            }

            else
            {
                easyAnswerTBD.Visible = true;
                checkPBD.Visible = false;
                submitBTD.Visible = true;
            }
        }

        private void nextBTD_Click(object sender, EventArgs e)
        {
            if (num == 10)
                num = 1;
            else
                num++;
            askQuestion(difficultQuiz.Items[num - 1].Question);
            checkPBD.Visible = difficultQuiz.Items[num - 1].IsCorrectAnswer;
            if (difficultQuiz.Items[num - 1].IsCorrectAnswer)
            {
                easyAnswerTBD.Visible = false;
                checkPBD.Visible = true;
                submitBTD.Visible = false;
            }

            else
            {
                easyAnswerTBD.Visible = true;
                checkPBD.Visible = false;
                submitBTD.Visible = true;
            }
        }

        private void submitBTD_Click(object sender, EventArgs e)
        {
            string ans = easyAnswerTBD.Text.ToString();
            if (difficultQuiz.IsCheck(difficultQuiz.Items[num - 1], ans))
            {
                difficultQuiz.Items[num - 1].IsCorrectAnswer = true;
                if (num == 10)
                    num = 1;
                else
                    num++;
                if (difficultQuiz.Items[num - 1].IsCorrectAnswer)
                {
                    easyAnswerTBD.Visible = false;
                    checkPBD.Visible = true;
                    submitBTD.Visible = false;
                }

                else
                {
                    easyAnswerTBD.Visible = true;
                    checkPBD.Visible = false;
                    submitBTD.Visible = true;
                }
                difficultScore++;
                askQuestion(difficultQuiz.Items[num - 1].Question);
                checkPBD.Visible = difficultQuiz.Items[num - 1].IsCorrectAnswer;
                easyAnswerTBD.ResetText();

            }
            else if (difficultQuiz.IsCheck(difficultQuiz.Items[num - 1], ans) && difficultScore == 10)
            {

                checkPBD.Visible = difficultQuiz.Items[num - 1].IsCorrectAnswer;

            }
            else
                MessageBox.Show("Wrong!!");
        }
        private void askQuestion(string q)
        {
            label1D.Text = q;
        }

        public void resetScore()
        {
            this.difficultScore = 0;
            easyAnswerTBD.Visible = true;
            checkPBD.Visible = false;
            submitBTD.Visible = true;
            foreach (TestItem item in difficultQuiz.Items)
                item.IsCorrectAnswer = false;
        }
    }
}
