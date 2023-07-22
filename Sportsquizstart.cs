using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ_APPLICATION_PROJECT
{
    public partial class SPSTART : Form
    {
        public SPSTART()
        {
            InitializeComponent();
        }

        private void f1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THE QUIZ CONSISTS OF TOTAL 10 QUESTIONS. READ THE QUESTION CAREFULLY AND THEN SOLVE THE QUESTION. AT THE END OF THE QUIZ, YOU WILL BE NOTIFIED ABOUT YOUR RESULT.",
"Popup Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           SPORTS obj = new SPORTS();
            obj.Show();
            this.Hide();
        }
    }
}
