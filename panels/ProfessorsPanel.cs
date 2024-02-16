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

namespace SchoolManagementSystem.UserControls
{
    public partial class ProfessorsPanel : UserControl
    {
        private ControlsService _nav;
        private ProfessorService _pf;
        public ProfessorsPanel(ControlsService nav, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _pf = pf;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            StudentsTable.FirstDisplayedScrollingRowIndex = StudentsTable.Rows[e.OldValue].Index;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ProfessorsPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
