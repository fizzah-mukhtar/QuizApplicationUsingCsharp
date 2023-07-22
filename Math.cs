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
    public partial class MATH : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        public MATH()
        {
            InitializeComponent();
            AskQuestion(questionNumber);
            totalQuestions = 10;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1R8N5P1;Initial Catalog=vpProjectQuizApplication;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[mathquiz] ([answer] VALUES(<answer, varchar(50),>)");
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
                    label1.Text = "The average of first fifty natural numbers is ";

                    button1.Text = "25.30";
                    button2.Text = "25.5";
                    button3.Text = "25";
                    button4.Text = "12.25";

                    correctAnswer = 2;
                    
                    break;

                case 2:
                    label2.Text = "QUESTION - 02";
                    label1.Text = "The number of 3 digit numbers divisible by 6 is ";

                    button1.Text = "149";
                    button2.Text = "166";
                    button3.Text = "150";
                    button4.Text = "151";

                    correctAnswer = 3;
                    
                    break;

                case 3:
                    label2.Text = "QUESTION - 03";
                    label1.Text = "What is 1004 divided by 2? ";

                    button1.Text = "52";
                    button2.Text = "502";
                    button3.Text = "520";
                    button4.Text = "5002";

                    correctAnswer = 2;
                    
                    break;

                case 4:
                    label2.Text = "QUESTION - 04";
                    label1.Text = "Evaluate: 106*106-94*94 ";

                    button1.Text = "2004";
                    button2.Text = "2400";
                    button3.Text = "1904";
                    button4.Text = "1906";

                    correctAnswer = 2;
                   
                    break;

                case 5:
                    label2.Text = "QUESTION - 05";
                    label1.Text = "A number is divisible by 5 if its unit digit is ";

                    button1.Text = "2 or 0";
                    button2.Text = "10 or 0";
                    button3.Text = "0 or 5";
                    button4.Text = "none of the above";

                    correctAnswer = 3;
                    
                    break;

                case 6:
                    label2.Text = "QUESTION - 06";
                    label1.Text = "Natural log of 1 is ";

                    button1.Text = "1";
                    button2.Text = "0";
                    button3.Text = "2";
                    button4.Text = "4";

                    correctAnswer = 2;
                    
                    break;

                case 7:
                    label2.Text = "QUESTION - 07";
                    label1.Text = "Orthogonal is another word for ";

                    button1.Text = "parallel";
                    button2.Text = "perpendicular";
                    button3.Text = "series";
                    button4.Text = "exponential";

                    correctAnswer = 2;
                   
                    break;

                case 8:
                    label2.Text = "QUESTION - 08";
                    label1.Text = "Angle present between the tangents of curve at the intersection of point is called ";

                    button1.Text = "angle of reflection";
                    button2.Text = "angle of refraction";
                    button3.Text = "angle of incident";
                    button4.Text = "angle of intersection";

                    correctAnswer = 4;
                   
                    break;

                case 9:
                    label2.Text = "QUESTION - 09";
                    label1.Text = "Method which gives solution in the form of power series is called ";

                    button1.Text = "logarithmic method";
                    button2.Text = "laplace method";
                    button3.Text = "power series method";
                    button4.Text = "linear method";

                    correctAnswer = 3;
                   
                    break;
                case 10:
                    label2.Text = "QUESTION - 10";
                    label1.Text = "A technique by which problems in analysis, in particular differential equations are transformed into algebraic problems is called ";

                    button1.Text = "static calculus";
                    button2.Text = "dynamic calculus";
                    button3.Text = "operational calculus";
                    button4.Text = "integral";

                    correctAnswer = 3;
                   
                    break;
            }
        }

        private void MATH_Load(object sender, EventArgs e)
        {

        }
    }
}
