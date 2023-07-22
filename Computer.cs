using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ_APPLICATION_PROJECT
{
    public partial class COMPUTER : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;

        int totalQuestions;
        public COMPUTER()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1R8N5P1;Initial Catalog=vpProjectQuizApplication;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[ComputerQuiz]  ([answer]) VALUES (<answer, varchar(50),>)");
            //conn.Open();
            conn.Close();
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {

                MessageBox.Show(
                 "Quiz Ended!" + "\n" +
                 "You have answered " + score + " out of 10 questions correctly." + "\n" +
                 "Thankyou for solving our quiz"
                 );

                END obj = new END();
                obj.Show();
                this.Hide();

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    label2.Text = "QUESTION - 01";

                    label1.Text = "----- is the father of computer.";

                    button1.Text = "Herman hollerith";
                    button2.Text = "Ada byron";
                    button3.Text = "Blaise pascal";
                    button4.Text = "Charles babbage";

                    correctAnswer = 4;

                    break;
                case 2:
                    label2.Text = "QUESTION - 02";
                    label1.Text = "Tabulating machine was invented by ----- .";


                    button1.Text = "Herman hollerith";
                    button2.Text = "Ada byron";
                    button3.Text = "Blaise pascal";
                    button4.Text = "Charles babbage";

                    correctAnswer = 1;

                    break;
                case 3:

                    label2.Text = "QUESTION - 03";
                    label1.Text = "A desktop computer is also known as --- .";

                    button1.Text = "PC";
                    button2.Text = "Laptop";
                    button3.Text = "Mainframe";
                    button4.Text = "Palmtop";

                    correctAnswer = 1;

                    break;
                case 4:

                    label2.Text = "QUESTION - 04";
                    label1.Text = "CPU is the ---- of computer.";

                    button1.Text = "Brain";
                    button2.Text = "Ear";
                    button3.Text = "Eye";
                    button4.Text = "All of the above";

                    correctAnswer = 1;

                    break;

                case 5:

                    label2.Text = "QUESTION - 05";
                    label1.Text = "The main characteristic of fourth generation was ---- .";

                    button1.Text = "Transistor";
                    button2.Text = "Vaccum tubes";
                    button3.Text = "Integrated circuit ";
                    button4.Text = "VLSI";

                    correctAnswer = 4;

                    break;

                case 6:

                    label2.Text = "QUESTION - 06";
                    label1.Text = "---- is used in third generation computer.";

                    button1.Text = "Transistor";
                    button2.Text = "Vaccum tubes";
                    button3.Text = "Microprocessor";
                    button4.Text = "Integrated circuit";

                    correctAnswer = 4;

                    break;

                case 7:

                    label2.Text = "QUESTION - 07";
                    label1.Text = "Silicon is a -------- material.";

                    button1.Text = "conductor";
                    button2.Text = "semi conductor";
                    button3.Text = " non conductor";
                    button4.Text = "both a and b";

                    correctAnswer = 2;

                    break;

                case 8:

                    label2.Text = "QUESTION - 08";
                    label1.Text = "The first microprocessor was developed in ----. ";

                    button1.Text = "Intel";
                    button2.Text = "Apple";
                    button3.Text = "Nasa";
                    button4.Text = "None of the above";

                    correctAnswer = 1;

                    break;

                case 9:

                    label2.Text = "QUESTION - 09";
                    label1.Text = "---- is used in first generation computer. ";

                    button1.Text = "Transistor";
                    button2.Text = "Vaccum tubes";
                    button3.Text = "Microprocessor";
                    button4.Text = "Integrated circuit";

                    correctAnswer = 2;

                    break;

                case 10:

                    label2.Text = "QUESTION - 10";
                    label1.Text = "Pascaline was invented by ";

                    button1.Text = "Herman hollerith";
                    button2.Text = "Ada byron";
                    button3.Text = "Blaise pascal";
                    button4.Text = "Charles babbage";

                    correctAnswer = 3;

                    break;
            }
        }
    }
}
