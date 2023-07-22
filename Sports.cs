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
    public partial class SPORTS : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        public SPORTS()
        {
            InitializeComponent();
            AskQuestion(questionNumber);
            totalQuestions = 10;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1R8N5P1;Initial Catalog=vpProjectQuizApplication;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[SportsQuiz]([answer])  VALUES  (<answer, varchar(50),>)");
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
                MessageBox.Show("Quiz Ended!" + "\n" +
                                "You have answered " + score + " questions correctly out of 10 questions." + "\n" +
                                "Thankyou for solving our quiz."
                                );

                END obj = new END();
                obj.Show();
                this.Hide();

                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);
            }

            questionNumber++;

            AskQuestion(questionNumber);
        }


        private void AskQuestion(int QuestionNumber)
        {
            switch (QuestionNumber)
            {
                case 1:
                    label2.Text = "QUESTION - 01";
                    label1.Text = "Holkar trophy is associated with which sport.";

                    button1.Text = "Bridge";
                    button2.Text = "Hockey";
                    button3.Text = "Football";
                    button4.Text = "Badminton";


                    correctAnswer = 1;



                    break;

                case 2:
                    label2.Text = "QUESTION - 02";
                    label1.Text = "Term Chinaman is related to which sports.";

                    button1.Text = "Cricket";
                    button2.Text = "Hockey";
                    button3.Text = "Football";
                    button4.Text = "Golf";


                    correctAnswer = 1;


                    break;

                case 3:
                    label2.Text = "QUESTION - 03";
                    label1.Text = "Who is the first Indian Woman to win an Asian Games gold in 400m run. ";

                    button1.Text = "M.L. Valsamma";
                    button2.Text = "P.T. Usha";
                    button3.Text = "Kamaljit Sandhu";
                    button4.Text = "K.Malleshwari";


                    correctAnswer = 2;


                    break;

                case 4:
                    label2.Text = "QUESTION - 04";
                    label1.Text = "With which game does davis cup is associated.";

                    button1.Text = "Table tennis";
                    button2.Text = "Hockey";
                    button3.Text = "Lawn Tennis";
                    button4.Text = "Polo";


                    correctAnswer = 3;



                    break;

                case 5:
                    label2.Text = "QUESTION - 05";
                    label1.Text = "The first indian to cross seven important seas by swimming.";

                    button1.Text = "Amrendra Singh";
                    button2.Text = "Bula Chaudhry";
                    button3.Text = "Junko Taibei";
                    button4.Text = "Yuri Gagarin";

                    correctAnswer = 2;


                    break;

                case 6:
                    label2.Text = "QUESTION - 06";
                    label1.Text = "Wellington Trophy is related to which game. ";

                    button1.Text = "Rowing";
                    button2.Text = "Hockey";
                    button3.Text = "Tennis";
                    button4.Text = "Badminton";

                    correctAnswer = 1;


                    break;

                case 7:
                    label2.Text = "QUESTION - 07";
                    label1.Text = "With which game does Santosh Trophy is associated. ";

                    button1.Text = "Tennis";
                    button2.Text = "Hockey";
                    button3.Text = "National Football";
                    button4.Text = "Badminton";


                    correctAnswer = 3;


                    break;

                case 8:
                    label2.Text = "QUESTION - 08";
                    label1.Text = "Name the person who controls the football match.";

                    button1.Text = "Refree";
                    button2.Text = "Spectator";
                    button3.Text = "Umpire";
                    button4.Text = "GoalKeeper";

                    correctAnswer = 1;


                    break;

                case 9:
                    label2.Text = "QUESTION - 09";
                    label1.Text = "The national game of japan is";

                    button1.Text = "Tennis";
                    button2.Text = "Karate";
                    button3.Text = "IceHockey";
                    button4.Text = "Sumo Wrestling";


                    correctAnswer = 4;

                    break;
                case 10:
                    label2.Text = "QUESTION - 10";
                    label1.Text = "The name Kunjarani Devi is associated with ";

                    button1.Text = "Weight Lifting";
                    button2.Text = "Target Shooting";
                    button3.Text = "Athletics";
                    button4.Text = "Swimming";


                    correctAnswer = 1;


                    break;
            }
        }

        private void SPORTS_Load(object sender, EventArgs e)
        {

        }
    }
}

