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
using WinFormsApp1;

namespace SchoolManagementSystem.UserControls
{
    public partial class ClassProfilePanel : UserControl
    {
        private ControlsService _nav;
        private ClassService _cl;
        private StudentService _st;
        private ProfessorService _pf;
        public ClassProfilePanel(ControlsService nav, ClassService cl, StudentService st, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _cl = cl;
            _st = st;
            _pf = pf;
            List<Student> ClassStudents = new List<Student>();
            InitalaizeTable();
        }
        //sample data

        private void InitalaizeTable()
        {
            var classes = _cl.GetAll();
            var students = _st.AllClassStudents(classes[0].code);
            for (int i = 0; i < students.Count; i++)
            {
                StudentsTable.Rows.Add(new object[]
                {
                    $"{students[i].firstName} {students[i].lastName}" ,$"{students[i].id}",$"{students[i].grade}"
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _nav.Display(_nav.classesPanel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            StudentsTable.FirstDisplayedScrollingRowIndex = StudentsTable.Rows[e.OldValue].Index;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            StudentsTable.Rows.Clear();
            var classes = _cl.GetAll();
            var students = _st.AllClassStudents(classes[0].code);
            string fullName = textBox1.Text;
            Filter filter = new Filter();
            filter.SetName(fullName);
            filter.classCode = classes[0].code;
            List<Student> searchResut = _st.GetBy(filter);

            for (int i = 0; i < searchResut.Count; i++)
            {
                StudentsTable.Rows.Add(new object[]
                {
                    $"{searchResut[i].firstName} {searchResut[i].lastName}" ,$"{searchResut[i].id}",$"{searchResut[i].grade}"
                });
            }

        }
    }
}
