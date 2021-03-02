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

namespace SF340
{
    public partial class Form1 : Form
    {
        private int totalScore;
        private Question question;
        public Form1()
        {
            InitializeComponent();
            setNewQuestion();
            totalScore = 0;
            score.Text = "score: " + totalScore;

        }


        private void button_Click(object sender, EventArgs e)
        {
            string selectedChoice = (sender as Button).Text;
            if (selectedChoice == question.getAnswer())
            {
                correctAnswer();
                setNewQuestion();
            }
            else
            {
                incorrectAnswer();
                setNewQuestion();
            }

        }


        private void correctAnswer()
        {
            score.Text = "score: " + ++totalScore;
        }

        private void incorrectAnswer()
        {
            MessageBox.Show("ผิด! โง่ชิบหายเลย เอ้วววว!!", "ตอบผิดไอควาย");
        }

        private void setNewQuestion()
        {
            question = new Question();
            question_label.Text = question.getQuestion();
            string[] choice = question.getChoice();
            choice1_button.Text = choice[0];
            choice2_button.Text = choice[1];
            choice3_button.Text = choice[2];
            choice4_button.Text = choice[3];
        }



    }
}
