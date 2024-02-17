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
    public partial class StudentsPanel : UserControl
    {
        private ControlsService _nav;
        private StudentService _st;
        public StudentsPanel(ControlsService nav,StudentService st)
        {
            InitializeComponent();
            _nav = nav;
            _st = st;
        }
    }
}
