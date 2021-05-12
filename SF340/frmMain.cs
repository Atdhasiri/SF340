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
using System.Media;
using System.Threading;


namespace QuizApp
{
    public partial class frmMain : Form
    {
        private int PLUS_MINUS_TIME = 5;
        private int totalScore;
        private int totalTime;
        private int totalRound;
        private Question question;
        private SoundPlayer soundPlayer;
        
         

        public frmMain()
        {
            InitializeComponent();
            playSound();
            pnWelcome.Visible = true;
            pnTimeOut.Visible = false;

            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            btnChoice3.Enabled = false;
            btnChoice4.Enabled = false;
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
        }

        private void correctAnswer()
        {
            this.totalTime += this.PLUS_MINUS_TIME;
            this.totalScore++;
            lblScore.Text = "Score: " + this.totalScore;

            textBox1.AppendText("(✓) ");
            textBox1.AppendText(this.totalRound.ToString() + ".) ");
            textBox1.AppendText(this.question.getQuestion() + " -> ");
            textBox1.AppendText(this.question.getAnswer() + " meaning :: ");
            textBox1.AppendText(this.question.getMeaning() + "\r\n");
            textBox1.AppendText("---------------------------------------------------------------------------------------------------" + "\r\n");

        }

        private void incorrectAnswer()
        {
            this.totalTime -= this.PLUS_MINUS_TIME;

            textBox1.AppendText("(x) ");
            textBox1.AppendText(this.totalRound.ToString() + ".) ");
            textBox1.AppendText(this.question.getQuestion() + " -> ");
            textBox1.AppendText(this.question.getAnswer() + " meaning :: ");
            textBox1.AppendText(this.question.getMeaning() + "\r\n");
            textBox1.AppendText("---------------------------------------------------------------------------------------------------" + "\r\n");
        }

        private void showCorrectAnswer()
        {
            changeButtonCollor(btnChoice1);
            changeButtonCollor(btnChoice2);
            changeButtonCollor(btnChoice3);
            changeButtonCollor(btnChoice4);
        }

        private void changeButtonCollor(Button button)
        {
            if (button.Text == capitalize(this.question.getAnswer()))
            {
                button.BackColor = Color.Green;
            }
            else
            {
                button.BackColor = Color.Red;
            }
        }

        private void resetButtonColor()
        {
            btnChoice1.BackColor = Color.FromArgb(255, 225, 26, 59);
            btnChoice2.BackColor = Color.FromArgb(255, 18, 104, 205);
            btnChoice3.BackColor = Color.FromArgb(255, 216, 158, 0);
            btnChoice4.BackColor = Color.FromArgb(255, 38, 137, 12);
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
            pnWelcome.Visible = false;
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

            playSound();
        }

        private void playSound()
        {
            this.soundPlayer = new SoundPlayer(Properties.Resources.Among_us_theme);
            if (Properties.Settings.Default.sound == 1)
                this.soundPlayer.PlayLooping();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            startGame();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sound == 1)
            {
                btnSound.BackgroundImage = Properties.Resources.sound_mute_24;
                Properties.Settings.Default.sound = 0;
                Properties.Settings.Default.Save();
                this.soundPlayer.Stop();
            }
            else
            {
                btnSound.BackgroundImage = Properties.Resources.sound_volume_24;
                Properties.Settings.Default.sound = 1;
                Properties.Settings.Default.Save();
                this.soundPlayer.PlayLooping();
            }
        }

        private void btnPlayNow_Click(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
