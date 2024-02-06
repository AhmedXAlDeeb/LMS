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
    public partial class professorsControl : UserControl
    {
        private ControlsService _nav;
        private ProfessorService _pf;
        public professorsControl(ControlsService nav,ProfessorService pf)
        {
            InitializeComponent();
            _nav = nav;
            _pf = pf;
        }
    }
}
