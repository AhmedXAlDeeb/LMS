using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.UserControls;


namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private List<UserControl>? controls;
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        public void InitializeControls()
        {
            controls = new List<UserControl>
            {
                new ClassProfilePanel(_nav,_cl , _st ,_pf),
                new ProfessorsPanel(_nav,_pf),
                new StudentsPanel(_nav,_st),
                new ControlPanel(_nav,_st,_ac)
            };
            _nav.Initialize(controls, MainPanel);
            _nav.Display(_nav.classesPanel);
        }
        public MainForm(
         StudentService st
        , AccountManager accountManager
        , ControlsService nav
        , ClassService cl
        , ProfessorService pf)
        {
            _st = st;
            _nav = nav;
            _ac = accountManager;
            _cl = cl;
            _pf = pf;

            InitializeComponent();
            InitializeControls(); // Adding other panels to the main form
        }

    }
}
