using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSproject
{
    public partial class SignUP : Form
    {
        //private readonly AccountManager accountManager;
        public SignUP()
        {
            InitializeComponent();
            //accountManager = new AccountManager(new AppDbContext());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox2.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("The passwords do not match");
            }
            else
            {
                //if (accountManager.SignUp(userName, password))
                //{
                //    MessageBox.Show("Sign-up successful!");
                //    // launching another window
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Username already exists. Please choose a different username.");
                //}

            }

        }
    }
}
