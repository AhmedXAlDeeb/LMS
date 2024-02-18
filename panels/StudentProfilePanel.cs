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

namespace SchoolManagementSystem.panels
{
    public partial class StudentProfilePanel : UserControl
    {
        private ControlsService _nav;
        private ClassService _cl;
        private StudentService _st;
        private ProfessorService _pf;
        public static Student? selectedStudent;

        
        public StudentProfilePanel(ControlsService nav, ClassService cl, StudentService st, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _cl = cl;
            _st = st;
            _pf = pf;
            loadPage();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                if (selectedStudent != null)
                {
                    label1.Text = $" {selectedStudent.firstName} {selectedStudent.lastName}";
                    label2.Text = $"{selectedStudent.age}";
                    label3.Text = $"{selectedStudent.email}";
                    label4.Text = $"{selectedStudent.phone}";
                    label5.Text = $"{selectedStudent.grade}";
                    label6.Text = $"{selectedStudent.id}";
                }
            }
        }

        public void loadPage()
        {
            if (selectedStudent != null)
            {
                label1.Text = $" {selectedStudent.firstName} {selectedStudent.lastName}";
                label2.Text = $"{selectedStudent.age}";
                label3.Text = $"{selectedStudent.email}";
                label4.Text = $"{selectedStudent.phone}";
                label5.Text = $"{selectedStudent.grade}";
                label6.Text = $"{selectedStudent.id}";
            }
        }

        private void StudentProfilePanel_Load(object sender, EventArgs e)
        {
            if (selectedStudent != null)
            {
                label1.Text = $" {selectedStudent.firstName} {selectedStudent.lastName}";
                label2.Text = $"{selectedStudent.age}";
                label3.Text = $"{selectedStudent.email}";
                label4.Text = $"{selectedStudent.phone}";
                label5.Text = $"{selectedStudent.grade}";
                label6.Text = $"{selectedStudent.id}";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = StudentsTable.RowCount;
        }

        private void StudentsTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            vScrollBar1.Maximum = StudentsTable.RowCount;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            StudentsTable.FirstDisplayedScrollingRowIndex = StudentsTable.Rows[e.OldValue].Index;
        }

    }
}
