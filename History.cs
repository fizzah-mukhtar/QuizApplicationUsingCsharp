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
    public partial class HISTORY : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
       
        int totalQuestions;

        public HISTORY()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1R8N5P1;Initial Catalog=vpProjectQuizApplication;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[HistoryQuiz] ([answer]) VALUES (<answer, varchar(50),>)");
           // conn.Open();
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

                    label1.Text = "In which year did india get independence from britain?";

                    button1.Text = "1944";
                    button2.Text = "1945";
                    button3.Text = "1946";
                    button4.Text = "1947";

                    correctAnswer = 4;

                    break;
                case 2:
                    label2.Text = "QUESTION - 02";
                    label1.Text = "The ancient egyptians used to sleep on pillows made of -- .";

                    button1.Text = "stones";
                    button2.Text = "gold";
                    button3.Text = "cotton";
                    button4.Text = "iron";

                    correctAnswer = 1;

                    break;
                case 3:

                    label2.Text = "QUESTION - 03";
                    label1.Text = "World war 1 began in which year?";

                    button1.Text = "1923";
                    button2.Text = "1938";
                    button3.Text = "1917";
                    button4.Text = "1914";

                    correctAnswer = 4;

                    break;
                case 4:

                    label2.Text = "QUESTION - 04";
                    label1.Text = "Adolf hitler was born in which country?";

                    button1.Text = "france";
                    button2.Text = "germany";
                    button3.Text = "austria";
                    button4.Text = "hungary";

                    correctAnswer = 3;

                    break;

                case 5:

                    label2.Text = "QUESTION - 05";
                    label1.Text = "American involvement in korean war took place in which decade?";

                    button1.Text = "1970";
                    button2.Text = "1950";
                    button3.Text = "1920";
                    button4.Text = "1960";

                    correctAnswer = 2;

                    break;

                case 6:

                    label2.Text = "QUESTION - 06";
                    label1.Text = "The battle of hastings was fought in which country?";

                    button1.Text = "france";
                    button2.Text = "russia";
                    button3.Text = "england";
                    button4.Text = "norway";

                    correctAnswer = 3;

                    break;

                case 7:

                    label2.Text = "QUESTION - 07";
                    label1.Text = "The hundred years war was fought between which two countries?";

                    button1.Text = "italy and carthage";
                    button2.Text = "england and germany";
                    button3.Text = "france and england";
                    button4.Text = "spain and france";

                    correctAnswer = 3;

                    break;

                case 8:

                    label2.Text = "QUESTION - 08";
                    label1.Text = "Name the man who wrote a document known as 95 thesis.";

                    button1.Text = "Martin luther";
                    button2.Text = "Saint augustus";
                    button3.Text = "Henry david";
                    button4.Text = "Voltaire";

                    correctAnswer = 1;

                    break;

                case 9:

                    label2.Text = "QUESTION - 09";
                    label1.Text = "John F. Kennedy was assassinated in ----.";

                    button1.Text = "New York";
                    button2.Text = "Austin";
                    button3.Text = "Dallas";
                    button4.Text = "Miami";

                    correctAnswer = 3;

                    break;

                case 10:

                    label2.Text = "QUESTION - 10";
                    label1.Text = "Who was the first western explorer to reach china? ";

                    button1.Text = "Magellan";
                    button2.Text = "Cook";
                    button3.Text = "Marco polo";
                    button4.Text = "Sir francis drake";

                    correctAnswer = 3;

                    break;
            }
        }

        private void HISTORY_Load(object sender, EventArgs e)
        {

        }
    }
}
