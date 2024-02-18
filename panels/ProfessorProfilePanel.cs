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
            if (selectedProfessor != null)
            {
                label1.Text = $" {selectedProfessor.firstName} {selectedProfessor.lastName}";
                label2.Text = $"{selectedProfessor.title}";
                label3.Text = $"{selectedProfessor.id}";
                label4.Text = $"{selectedProfessor.age}";
                label5.Text = $"{selectedProfessor.email}";
                label6.Text = $"{selectedProfessor.phone}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
