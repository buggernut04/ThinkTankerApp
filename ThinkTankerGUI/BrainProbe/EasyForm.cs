using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThinkTankerApp;
using ThinkTankerClasses;

namespace ThinkTankerGUI.BrainProbe
{
    public partial class EasyForm : UserControl
    {
        Easy EasyQuiz = new Easy();
        int num = 1;
        public int easyScore { get; private set; }
        public bool easyForm_isOpen { get; set; }
        public EasyForm()
        {
            InitializeComponent();
            EasyQuiz.CreateQuestion();
            askQuestion(EasyQuiz.Items[num - 1].Question);
            this.easyScore = 0;
            //checkPB.Visible = false;
        }

        private void prevBT_Click(object sender, EventArgs e)
        {

            if (num == 1)
                num = 10;
            else
                num--;

            askQuestion(EasyQuiz.Items[num - 1].Question);
            checkPB.Visible = EasyQuiz.Items[num - 1].IsCorrectAnswer;
            if (EasyQuiz.Items[num - 1].IsCorrectAnswer)
            {
                easyAnswerTB.Visible = false;
                checkPB.Visible = true;
                submitBT.Visible = false;
            }

            else
            {
                easyAnswerTB.Visible = true;
                checkPB.Visible = false;
                submitBT.Visible = true;
            }
        }

        private void nextBT_Click(object sender, EventArgs e)
        {

            if (num == EasyQuiz.Items.Count)
                num = 1;
            else
                num++;
            askQuestion(EasyQuiz.Items[num - 1].Question);
            checkPB.Visible = EasyQuiz.Items[num - 1].IsCorrectAnswer;
            if (EasyQuiz.Items[num - 1].IsCorrectAnswer)
            {
                easyAnswerTB.Visible = false;
                checkPB.Visible = true;
                submitBT.Visible = false;
            }

            else
            {
                easyAnswerTB.Visible = true;
                checkPB.Visible = false;
                submitBT.Visible = true;
            }
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            string ans = easyAnswerTB.Text.ToString();
            if (EasyQuiz.IsCheck(EasyQuiz.Items[num - 1], ans))
            {
                EasyQuiz.Items[num - 1].IsCorrectAnswer = true;
                if (num == 10)
                    num = 1;
                else
                    num++;
                if (EasyQuiz.Items[num - 1].IsCorrectAnswer)
                {
                    easyAnswerTB.Visible = false;
                    checkPB.Visible = true;
                    submitBT.Visible = false;
                }

                else
                {
                    easyAnswerTB.Visible = true;
                    checkPB.Visible = false;
                    submitBT.Visible = true;
                }
                easyScore++;
                askQuestion(EasyQuiz.Items[num - 1].Question);
                checkPB.Visible = EasyQuiz.Items[num - 1].IsCorrectAnswer;
                easyAnswerTB.ResetText();

            }
            else if (EasyQuiz.IsCheck(EasyQuiz.Items[num - 1], ans) && easyScore == 10)
            {

                checkPB.Visible = EasyQuiz.Items[num - 1].IsCorrectAnswer;

            }
            else
                MessageBox.Show("Wrong!!");
        }

        private void askQuestion(string q)
        {
            label1.Text = q;
        }

        public void resetScore()
        {
            this.easyScore = 0;
            easyAnswerTB.Visible = true;
            checkPB.Visible = false;
            submitBT.Visible = true;
            foreach (TestItem item in EasyQuiz.Items)
                item.IsCorrectAnswer = false;
        }
    }
}
