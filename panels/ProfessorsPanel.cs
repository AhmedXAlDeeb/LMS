﻿using SchoolManagementSystem.Models;
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
    public partial class ProfessorsPanel : UserControl
    {
        private ControlsService _nav;
        private ProfessorService _pf;
        public ProfessorsPanel(ControlsService nav, ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _pf = pf;
            List<Professor> professors = new List<Professor>();
            initializeTable();
        }

        public void initializeTable()
        {
            var professors = _pf.GetAll();
            //var students = _st.AllClassStudents(selectedClass.code);
            for (int i = 0; i < professors.Count; i++)
            {
                ProfesorsTable.Rows.Add(new object[]
                {
                    $"{professors[i].firstName} {professors[i].lastName}" ,$"{professors[i].id}" , $"{professors[i].email}"
                });
            }
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ProfesorsTable.FirstDisplayedScrollingRowIndex = ProfesorsTable.Rows[e.OldValue].Index;
        }

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            vScrollBar1.Maximum = ProfesorsTable.RowCount;
        }

        private void StudentsTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            vScrollBar1.Maximum = ProfesorsTable.RowCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfesorsTable.Rows.Clear();
            string fullName = textBox1.Text;
            Filter filter = new Filter();
            filter.SetName(fullName);
        }

        private void ProfessorsPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
