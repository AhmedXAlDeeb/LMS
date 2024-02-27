using Learning_Managment_System;
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
    public partial class ProfessorProfilePanel : UserControl
    {
        private ControlsService _nav;
        private ClassService _cl;
        private StudentService _st;
        private ProfessorService _pf;
        public static Professor? selectedProfessor;
        public ProfessorProfilePanel(ControlsService nav, ClassService cl, StudentService st, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _cl = cl;
            _st = st;
            _pf = pf;
        }

        private void ProfessorProfilePanel_Load(object sender, EventArgs e)
        {

        }
        public void InitalaizeTable()
        {
            if (selectedProfessor != null)
            {
                profName.Text = $" {selectedProfessor.firstName} {selectedProfessor.lastName}";
                profTitle.Text = $"{selectedProfessor.title}";
                profID.Text = $"{selectedProfessor.id}";
                profAge.Text = $"{selectedProfessor.age}";
                profEmail.Text = $"{selectedProfessor.email}";
                profPhone.Text = $"{selectedProfessor.phone}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void profTitle_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            new EditProf(_st, _nav, _cl, _pf, selectedProfessor).Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            _pf.Remove(selectedProfessor);
            _nav.Display(_nav.studentsPanel);
            MessageBox.Show($"professor {selectedProfessor.firstName + selectedProfessor.lastName} is deleted");
        }
    }
}
