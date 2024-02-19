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
        private StudentService _st;
        private AccountManager _accountManager;
        private ControlsService _nav;
        public ControlPanel(ControlsService nav, StudentService st, AccountManager accountManager)
        {
            InitializeComponent();
            _st = st;
            _accountManager = accountManager;
            _nav = nav;
        }


        private void newStudButt_Click(object sender, EventArgs e)
        {
            newStud newStud = new newStud();
            newStud.ShowDialog();
        }

        private void newClassButt_Click(object sender, EventArgs e)
        {
            NewClass newClass = new NewClass();
            newClass.ShowDialog();
        }

        private void newProffButt_Click(object sender, EventArgs e)
        {
            newProf newProf = new newProf();
            newProf.ShowDialog();
        }
    }
}
