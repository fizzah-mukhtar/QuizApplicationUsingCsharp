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
    public partial class SIGNUP : Form
    {
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1R8N5P1;Initial Catalog=vpProjectQuizApplication;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[SIGNUP_PAGE]
           ([name]
           ,[usrename]
           ,[password]
           ,[email]
           ,[phoneno]
           ,[country]
           ,[dateofbirth]
           ,[gender]
           ,[address])
     VALUES
           (<name, nvarchar(50),>
           ,<usrename, nvarchar(50),>
           ,<password, nvarchar(50),>
           ,<email, nvarchar(50),>
           ,<phoneno, nvarchar(50),>
           ,<country, nvarchar(50),>
           ,<dateofbirth, nvarchar(50),>
           ,<gender, nvarchar(50),>
           ,<address, nvarchar(50),>)");
            conn.Open();
            conn.Close();
            string NAME = textBox1.Text.ToString();
            string USER_NAME = textBox2.Text.ToString();
            string PASSWORD = textBox3.Text.ToString();
            string EMAIL = textBox4.Text.ToString();
            string PHONE_NUMBER = maskedTextBox1.Text.ToString();
            string DOB = dateTimePicker1.Text.ToString();
            string COUNTRY = comboBox1.Text.ToString();
            string ADDRESS = textBox5.Text.ToString();
            if (radioButton1.Checked)
            {
                MessageBox.Show("YOUR NAME IS : " + NAME
                    + "\n" + "YOUR USER NAME IS : " + USER_NAME
                    + "\n" + "YOUR PASSWORD IS : " +PASSWORD
                    + "\n" + "YOUR EMAIL IS : " + EMAIL
                    + "\n" + "YOUR ADDRESS IS : " + ADDRESS
                    + " \n" + "YOUR PHONE NUMBER IS : " + PHONE_NUMBER
                    + "\n" + "YOUR COUNTRY IS : " + COUNTRY
                    + "\n" + "YOUR DATE OF BIRTH IS: " + DOB
                    );
                MessageBox.Show("YOUR ACCOUNT IS REGISTERED");
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("YOUR NAME IS : " + NAME
                    + "\n" + "YOUR USER NAME IS : " + USER_NAME
                    + "\n" + "YOUR PASSWORD IS : " + PASSWORD
                    + "\n" + "YOUR EMAIL IS : " + EMAIL
                    + "\n" + "YOUR ADDRESS IS : " + ADDRESS
                    + " \n" + "YOUR PHONE NUMBER IS : " + PHONE_NUMBER
                    + "\n" + "YOUR COUNTRY IS : " + COUNTRY
                    + "\n" + "YOUR DATE OF BIRTH IS: " + DOB);
                MessageBox.Show("YOUR ACCOUNT IS REGISTERED");
            }
        }

        private void SIGNUP_Load(object sender, EventArgs e)
        {

        }
    }
}
