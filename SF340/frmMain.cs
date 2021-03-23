using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class frmMain : Form
    {
        private int PLUS_MINUS_TIME = 5;
        private int totalScore;
        private int totalTime;
        private int totalRound;
        private Question question;

        public frmMain()
        {
            InitializeComponent();
            startGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string selectedChoice = (sender as Button).Text;

            //Check answer
            if (selectedChoice == capitalize(this.question.getAnswer()))
                correctAnswer();
            else
                incorrectAnswer();

            setNewQuestion();
            this.totalRound++;
            lblRound.Text = "Round: " + this.totalRound;
        }

        private void correctAnswer()
        {
            this.totalTime += this.PLUS_MINUS_TIME;
            this.totalScore++;
            lblScore.Text = "Score: " + this.totalScore;
        }

        private void incorrectAnswer()
        {
            this.totalTime -= this.PLUS_MINUS_TIME;
        }

        private void setNewQuestion()
        {
            this.question = new Question();
            lblQuestion.Text = "What is synonym of  \" " + capitalize(this.question.getQuestion()) + " \"  ?";

            string[] choices = this.question.getChoices();
            btnChoice1.Text = capitalize(choices[0]);
            btnChoice2.Text = capitalize(choices[1]);
            btnChoice3.Text = capitalize(choices[2]);
            btnChoice4.Text = capitalize(choices[3]);
        }

        private string capitalize(string str)
        {
            if (str.Length == 0)
                return str;
            else if (str.Length == 1)
                return char.ToUpper(str[0]).ToString();
            else
                return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        private void timeOut_Tick(object sender, EventArgs e)
        {
            this.totalTime--;

            if (this.totalTime <= 0)
            {
                lblTime.Text = "Time: 0 s";
                timeOut.Stop();
                pnTimeOut.Visible = true;
                lblSummaryScore.Text = "Score: " + this.totalScore;
                lblSummaryRound.Text = "Round: " + this.totalRound;

                btnChoice1.Enabled = false;
                btnChoice2.Enabled = false;
                btnChoice3.Enabled = false;
                btnChoice4.Enabled = false;
            }
            else
                lblTime.Text = "Time: " + this.totalTime + " s";
        }

        private void startGame()
        {
            pnTimeOut.Visible = false;
            btnChoice1.Enabled = true;
            btnChoice2.Enabled = true;
            btnChoice3.Enabled = true;
            btnChoice4.Enabled = true;

            this.totalScore = 0;
            this.totalRound = 1;
            this.totalTime = 60;    //60 seconds

            setNewQuestion();
            lblScore.Text = "Score: " + this.totalScore;
            lblRound.Text = "Round: " + this.totalRound;
            lblTime.Text = "Time: " + this.totalTime + " s";

            timeOut.Start();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
