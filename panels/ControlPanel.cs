using SchoolManagementSystem.Models;
using SchoolManagementSystem.panels;
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
    public partial class ControlPanel : UserControl
    {
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        public ControlPanel(
 StudentService st
, AccountManager accountManager
, ControlsService nav
, ClassService cl
, ProfessorService pf)
        {
            InitializeComponent();
            _st = st;
            _nav = nav;
            _ac = accountManager;
            _cl = cl;
            _pf = pf;
        }

        public void InitializeData()
        {
            exportButt.Enabled = false;
            importButt.Enabled = false;
            pickClass.Items.Clear();
            var classes = _cl.GetAll();
            classes.ForEach(x => pickClass.Items.Add(x.code));
        }
        private void newStudButt_Click(object sender, EventArgs e)
        {
            var Student = new newStud(_st, _ac, _nav, _cl, _pf);
            Student.ShowDialog();
        }

        private void newClassButt_Click(object sender, EventArgs e)
        {
            var Student = new NewClass(_st, _ac, _nav, _cl, _pf);
            Student.ShowDialog();
        }

        private void newProffButt_Click(object sender, EventArgs e)
        {
            var Student = new newProf(_st, _ac, _nav, _cl, _pf);
            Student.ShowDialog();
        }

        private void pickClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            exportButt.Enabled = true;
            importButt.Enabled = true;
        }
        private void exportButt_Click(object sender, EventArgs e)
        {
            exportButt.Enabled = false;
            importButt.Enabled = false;
            var di = new FolderBrowserDialog();
            di.ShowDialog();
            _cl.ExportToCSV((string)pickClass.SelectedItem, di.SelectedPath);
            exportButt.Enabled = true;
            importButt.Enabled = true;
        }

        private void importButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "csv File|*.csv";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string[] lines = System.IO.File.ReadAllLines(opf.FileName);
                string[][] data = new string[lines.Length][];
                int i = 0;
                foreach (string line in lines)
                {
                    data[i] = line.Split(',');
                    i++;
                }
                var dd = data.ToList().ToList();
            }
        }
        private List<Student> ImportCSV(List<List<string>> csv)
        {
            throw new NotImplementedException();
        }
    }
}
