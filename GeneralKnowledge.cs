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
    public partial class GENERAL_KNOWLEDGE : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;

        int totalQuestions;

        public GENERAL_KNOWLEDGE()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1R8N5P1;Initial Catalog=vpProjectQuizApplication;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@" INSERT INTO[dbo].[GeneralKnowledgeQuiz]([answer]) VALUES  (<answer, varchar(50),>)");
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

                    label1.Text = "	Grand Central Terminal, Park Avenue, New York is the world's";

                    button1.Text = "largest railway station";
                    button2.Text = "highest railway station";
                    button3.Text = "longest railway station";
                    button4.Text = "None of the above";

                    correctAnswer = 1;

                    break;
                case 2:
                    label2.Text = "QUESTION - 02";
                    label1.Text = "Entomology is the science that studies";


                    button1.Text = "Behavior of human beings";
                    button2.Text = "Insects";
                    button3.Text = "The origin and history of technical and scientific terms";
                    button4.Text = "The formation of rocks";

                    correctAnswer = 2;

                    break;
                case 3:

                    label2.Text = "QUESTION - 03";
                    label1.Text = "Eritrea, which became the 182nd member of the UN in 1993, is in the continent of";

                    button1.Text = "Asia";
                    button2.Text = "Africa";
                    button3.Text = "Europe";
                    button4.Text = "Australia";

                    correctAnswer = 2;

                    break;
                case 4:

                    label2.Text = "QUESTION - 04";
                    label1.Text = "For which of the following disciplines is Nobel Prize awarded?";

                    button1.Text = "Physics and Chemistry";
                    button2.Text = "Physiology or Medicine";
                    button3.Text = "Literature, Peace and economics";
                    button4.Text = "All of the above";

                    correctAnswer = 4;

                    break;

                case 5:

                    label2.Text = "QUESTION - 05";
                    label1.Text = "Hitler party which came into power in 1933 is known as";

                    button1.Text = "Labour party ";
                    button2.Text = "Nazi party";
                    button3.Text = "Ku-Klux-Klan";
                    button4.Text = "Democratic party";

                    correctAnswer = 2;

                    break;

                case 6:

                    label2.Text = "QUESTION - 06";
                    label1.Text = "	First Afghan War took place in";

                    button1.Text = "1839";
                    button2.Text = "1843";
                    button3.Text = "1833";
                    button4.Text = "1848";

                    correctAnswer = 1;

                    break;

                case 7:

                    label2.Text = "QUESTION - 07";
                    label1.Text = "	FFC stands for -----.";

                    button1.Text = "Foreign Finance Corporation";
                    button2.Text = "Film Finance Corporation";
                    button3.Text = "Federation of Football Council";
                    button4.Text = "None of the above";

                    correctAnswer = 2;

                    break;

                case 8:

                    label2.Text = "QUESTION - 08";
                    label1.Text = "Fastest shorthand writer was -----.";

                    button1.Text = "Dr G.D. Bist";
                    button2.Text = "J.R.D. Tata";
                    button3.Text = "J.M. Tagore";
                    button4.Text = "Khudada Khan";

                    correctAnswer = 1;

                    break;

                case 9:

                    label2.Text = "QUESTION - 09";
                    label1.Text = "Galileo was an Italian astronomer who -----. ";

                    button1.Text = "developed the telescope";
                    button2.Text = "discovered four satellites of Jupiter";
                    button3.Text = "discovered that the movement of pendulum produces a regular time measurement";
                    button4.Text = "All of the above";

                    correctAnswer = 4;

                    break;

                case 10:

                    label2.Text = "QUESTION - 10";
                    label1.Text = "Exposure to sunlight helps a person improve his health because";

                    button1.Text = "the infrared light kills bacteria in the body";
                    button2.Text = "resistance power increases";
                    button3.Text = "the pigment cells in the skin get stimulated and produce a healthy tan";
                    button4.Text = "the ultraviolet rays convert skin oil into Vitamin D";

                    correctAnswer = 4;

                    break;
            }
        }

        private void GENERAL_KNOWLEDGE_Load(object sender, EventArgs e)
        {

        }
    }
}
