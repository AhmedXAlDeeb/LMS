using SchoolManagementSystem.Models;
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

namespace Learning_Managment_System
{
    public partial class EditStud : Form
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        private Student toEdit;
        public EditStud(
         StudentService st
        , AccountManager accountManager
        , ControlsService nav
        , ClassService cl
        , ProfessorService pf,
Student toEdit)
        {
            _st = st;
            _nav = nav;
            _ac = accountManager;
            _cl = cl;
            _pf = pf;
            InitializeComponent();
            this.toEdit = toEdit;
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            firstName.Text = toEdit.firstName;
            lastName.Text = toEdit.lastName;
            email.Text = toEdit.email;
            phone.Text = toEdit.phone;
            gradeInput.Text = toEdit.grade.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButt_Click(object sender, EventArgs e)
        {
            if (firstName.Text.Length == 0)
            {
                MessageBox.Show("first name is required");
                return;
            }

            toEdit.firstName = firstNameInput.Text;
            toEdit.lastName = lastNameInput.Text;
            toEdit.age = int.Parse(ageInput.Text);
            toEdit.email = emailInput.Text;
            toEdit.phone = phoneInput.Text;
            toEdit.grade = int.Parse(gradeInput.Text);
            _st.Update(toEdit);
            Close();
        }

        private void ageInput_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsAsciiDigit(ageInput.Text.LastOrDefault()))
            {
                if (ageInput.Text.Length > 0)
                    ageInput.Text.Remove(Text.Length - 1);
            }
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!char.IsAsciiDigit(ageInput.Text.LastOrDefault()))
            {
                if (gradeInput.Text.Length > 0)
                    gradeInput.Text.Remove(Text.Length - 1);
            }
        }
    }
}
