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

    public partial class Form1 : Form
    {
        private readonly AccountManager accountManager;

        public Form1()
        {
            InitializeComponent();
           accountManager = new AccountManager(new AppDbContext());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUP signUpForm = new SignUP();
            signUpForm.Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (accountManager.SignIn(userName, password))
            {
                //launching el homepage b2a .. el message box is temporary 
                MessageBox.Show("Login successful!");
                Close();
            }
          
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }

         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
