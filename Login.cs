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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1R8N5P1;Initial Catalog=vpProjectQuizApplication;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[LOGIN_PAGE]
           ([username]
           ,[password])
     VALUES
           (<username, nvarchar(50),>
           ,<password, nvarchar(50),>)");
            //conn.Open();
            conn.Close();
            string USER_NAME = textBox1.Text.ToString();
            string PASSWORD = textBox2.Text.ToString();
            string NAME = "aaa";
            string PASS = "123.";
            if (USER_NAME == NAME && PASSWORD == PASS)
            {
                MessageBox.Show("SUCCESSFULL LOGIN");

                quiz obj = new quiz();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USER NAME OR PASSWORD IS INCORRECT");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
