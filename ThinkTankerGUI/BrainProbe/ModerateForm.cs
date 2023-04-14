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
    public partial class ModerateForm : UserControl
    {
        Moderate ModerateQuiz = new Moderate();
        int num = 1;
        public int moderateScore { get; private set; }
        public bool moderateForm_isOpen { get; set; }
        public ModerateForm()
        {
            InitializeComponent();
            ModerateQuiz.CreateQuestion();
            askQuestion(ModerateQuiz.Items[num - 1].Question);
            this.moderateScore = 0;
            checkPBM.Visible = false;
        }

        private void prevBT_Click(object sender, EventArgs e)
        {
            if (num == 1)
                num = 10;
            else
                num--;

            askQuestion(ModerateQuiz.Items[num - 1].Question);
            checkPBM.Visible = ModerateQuiz.Items[num - 1].IsCorrectAnswer;
            if (ModerateQuiz.Items[num - 1].IsCorrectAnswer)
            {
                easyAnswerTBM.Visible = false;
                checkPBM.Visible = true;
                submitBTM.Visible = false;
            }

            else
            {
                easyAnswerTBM.Visible = true;
                checkPBM.Visible = false;
                submitBTM.Visible = true;
            }
        }

        private void nextBTM_Click(object sender, EventArgs e)
        {
            if (num == 10)
                num = 1;
            else
                num++;
            askQuestion(ModerateQuiz.Items[num - 1].Question);
            checkPBM.Visible = ModerateQuiz.Items[num - 1].IsCorrectAnswer;
            if (ModerateQuiz.Items[num - 1].IsCorrectAnswer)
            {
                easyAnswerTBM.Visible = false;
                checkPBM.Visible = true;
                submitBTM.Visible = false;
            }

            else
            {
                easyAnswerTBM.Visible = true;
                checkPBM.Visible = false;
                submitBTM.Visible = true;
            }
        }

        private void submitBTM_Click(object sender, EventArgs e)
        {
            string ans = easyAnswerTBM.Text.ToString();
            if (ModerateQuiz.IsCheck(ModerateQuiz.Items[num - 1], ans))
            {
                ModerateQuiz.Items[num - 1].IsCorrectAnswer = true;
                if (num == 10)
                    num = 1;
                else
                    num++;
                if (ModerateQuiz.Items[num - 1].IsCorrectAnswer)
                {
                    easyAnswerTBM.Visible = false;
                    checkPBM.Visible = true;
                    submitBTM.Visible = false;
                }

                else
                {
                    easyAnswerTBM.Visible = true;
                    checkPBM.Visible = false;
                    submitBTM.Visible = true;
                }
                moderateScore++;
                askQuestion(ModerateQuiz.Items[num - 1].Question);
                checkPBM.Visible = ModerateQuiz.Items[num - 1].IsCorrectAnswer;
                easyAnswerTBM.ResetText();

            }
            else if (ModerateQuiz.IsCheck(ModerateQuiz.Items[num - 1], ans) && moderateScore == 10)
            {

                checkPBM.Visible = ModerateQuiz.Items[num - 1].IsCorrectAnswer;

            }
            else
                MessageBox.Show("Wrong!!");
        }
        private void askQuestion(string q)
        {
            label1M.Text = q;
        }
        public void resetScore()
        {
            this.moderateScore = 0;
            easyAnswerTBM.Visible = true;
            checkPBM.Visible = false;
            submitBTM.Visible = true;
            foreach (TestItem item in ModerateQuiz.Items)
                item.IsCorrectAnswer = false;
        }
    }
}
