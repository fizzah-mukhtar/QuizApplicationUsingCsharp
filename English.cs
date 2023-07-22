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
    public partial class ENGLISH : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        public ENGLISH()
        {
            InitializeComponent();
            AskQuestion(questionNumber);
            totalQuestions = 10;
        }


        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1R8N5P1;Initial Catalog=vpProjectQuizApplication;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO[dbo].[EnglishQuiz] ([answer]) VALUES (< answer, varchar(50),>)");
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
                    label1.Text = "My daughter said I should take my umbrella and ------- too. While I was out it started pouring with rain. ";

                    button1.Text = "just as well";
                    button2.Text = "just as good";
                    button3.Text = "just as lucky";


                    correctAnswer = 1;
                   
                    

                    break;

                case 2:
                    label2.Text = "QUESTION - 02";
                    label1.Text = "I cannot promise he will listen to me and change his mind, but i will --------";

                    button1.Text = "see what can I do";
                    button2.Text = "see that I may do";
                    button3.Text = "see what I will do";


                    correctAnswer = 1;
                    
                    
                    break;

                case 3:
                    label2.Text = "QUESTION - 03";
                    label1.Text = "I moved to new york in 2010 and my life has been great -------- ";

                    button1.Text = "ever after";
                    button2.Text = "ever since";
                    button3.Text = "ever more";


                    correctAnswer = 2;
                    
                   
                    break;

                case 4:
                    label2.Text = "QUESTION - 04";
                    label1.Text = "My friends donot believe in life after death. They say there's ------- as heaven and hell. ";

                    button1.Text = "no true thing";
                    button2.Text = "no real thing";
                    button3.Text = "no such thing";


                    correctAnswer = 3;
                   

                 
                    break;

                case 5:
                    label2.Text = "QUESTION - 05";
                    label1.Text = "I know you donot really like basketball, but we got the tickets for free so we ------- go. ";

                    button1.Text = "should as well";
                    button2.Text = "must as well";
                    button3.Text = "may as well";


                    correctAnswer = 3;
                  
                   
                    break;

                case 6:
                    label2.Text = "QUESTION - 06";
                    label1.Text = "Your Family will always be there to help you, -------. ";

                    button1.Text = "no matter what";
                    button2.Text = "no matter which";
                    button3.Text = "no matter that";


                    correctAnswer = 1;
                  
                   
                    break;

                case 7:
                    label2.Text = "QUESTION - 07";
                    label1.Text = "I am cutting down on alcohol, so ------- I am only drinking light beer. ";

                    button1.Text = "from now on";
                    button2.Text = "for now on";
                    button3.Text = "since now on";


                    correctAnswer = 1;
                    
                   
                    break;

                case 8:
                    label2.Text = "QUESTION - 08";
                    label1.Text = "It's often said that there's a -------- between genius and madness";

                    button1.Text = "a thick line";
                    button2.Text = "a fine line";
                    button3.Text = "a long line";


                    correctAnswer = 2;
                   
                  
                    break;

                case 9:
                    label2.Text = "QUESTION - 09";
                    label1.Text = "In the village where i grew up, everyone survived by helping ------ through the hard times.";

                    button1.Text = "one another";
                    button2.Text = "one other";
                    button3.Text = "one or another";


                    correctAnswer = 1;
                   
                    break;
                case 10:
                    label2.Text = "QUESTION - 10";
                    label1.Text = "There's only one diving board, but if we ------ diving everyone will have plenty of dives. ";

                    button1.Text = "take goes";
                    button2.Text = "take turns";
                    button3.Text = "take tries";


                    correctAnswer = 2;
                   
                   
                    break;
            }
        }

        private void ENGLISH_Load(object sender, EventArgs e)
        {

        }
    }
}
