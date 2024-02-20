﻿using Learning_Managment_System;
using Microsoft.EntityFrameworkCore.Update;
using SchoolManagementSystem.Services;
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
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;

        public SignUP(
         StudentService st
        , AccountManager ac
        , ControlsService nav
        , ClassService cl
        , ProfessorService pf)
        {
            InitializeComponent();
            _st = st;
            _ac = ac;
            _cl = cl;
            _nav = nav;
            _pf = pf;
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
                if (_ac.SignUp(userName, password))
                {
                    MessageBox.Show("Sign-up successful!");
                    // launching another window
                    new SignIn(_st, _ac, _nav, _cl, _pf).Show();
                }
                else
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
            }

        }
    }
}
