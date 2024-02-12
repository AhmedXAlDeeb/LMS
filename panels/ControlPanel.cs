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
    public partial class ControlPanel : UserControl
    {
        private StudentService _st;
        private AccountManager _accountManager;
        private ControlsService _nav;
        public ControlPanel(ControlsService nav,StudentService st,AccountManager accountManager)
        {
            InitializeComponent();
            _st = st;
            _accountManager = accountManager;
            _nav = nav;
        }

        private void test_Click(object sender, EventArgs e)
        {
            _nav.Display(_nav.classesPanel);
        }
        
    }
}
