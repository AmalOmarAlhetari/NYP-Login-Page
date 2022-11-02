using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            string user1name = "amal";
            string user1password = "123";

            if(user1name == txtUsername.Text && user1password == txtPassword.Text)
            {
                main.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Something went wrong!");

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
