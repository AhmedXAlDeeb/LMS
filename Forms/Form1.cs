using DSproject;
using Microsoft.Extensions.DependencyInjection;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.panels;
using SchoolManagementSystem.Services;

namespace Learning_Managment_System
{
    public partial class Form1 : Form
    {
        private List<UserControl>? controls;
        private ControlsService _nav;
        private StudentService _st;
        private ProfessorService _pf;
        private AccountManager _ac;
        private ClassService _cl;
        public void InitializeControls()
        {
            userName.Text = _ac.admin.userName;
            controls = new List<UserControl>
            {
                new ClassesPanel(_nav, _cl, _st, _pf),
                new ProfessorsPanel(_nav, _pf),
                new StudentsPanel(_nav, _st),
                new ControlPanel(_st, _ac, _nav, _cl, _pf),
                new ClassProfilePanel(_nav, _cl, _st, _pf),
                new ProfessorProfilePanel(_nav, _cl, _st, _pf),
                new StudentProfilePanel(_nav, _cl, _st, _pf)
            };
            _nav.Initialize(controls, currentPanel);
            _nav.Display(_nav.controlPanel);
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            InitializeControls();
        }
        public Form1(
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
            //RemoveDummyData();
            //AddDummyData();
            InitializeComponent();
            InitializeControls(); // Adding other panels to the main form
        }
        private void AddDummyData()
        {
            var user = new Admin()
            {
                userName = "admin",
                password = "123"
            };
            _ac.SignUp(user.userName, user.password);
            _ac.SignIn(user.userName, user.password);
            var students = new List<Student>() {
                new Student() {firstName = "salah",lastName = "mohamed" ,grade = 99 , age = 20},
                new Student() {firstName = "omar",lastName = "mohamed" ,grade = 99 , age = 20},
                new Student() {firstName = "ahmed",lastName = "mohamed" ,grade = 99 , age = 20},
                new Student() {firstName = "mostafa",lastName = "ali" ,grade = 9 , age = 20},
                new Student() {firstName = "enjy",lastName = "ashraf" ,grade = 99 , age = 20},
                new Student() {firstName = "ali",lastName = "mohamed" ,grade = 99 , age = 20},
                new Student() {firstName = "youssef",lastName = "mohamed" ,grade = 50 , age = 20},
                new Student() {firstName = "khaled",lastName = "mohamed" ,grade = 99 , age = 20},
                new Student() {firstName = "hend",lastName = "mohamed" ,grade = 70 , age = 20},
                new Student() {firstName = "mohamed",lastName = "mohamed" ,grade = 99 , age = 20},
            };
            var profs = new List<Professor>() {
                new Professor() {firstName = "wael",lastName="gom3a",title ="elskhra"},
                new Professor() {firstName = "osama",lastName="ali",title ="test"}
            };

            var classes = new List<Class>()
            {
                new Class(){code = "sbe1" ,hall="9823" ,time=2,name="sub1"},
                new Class(){code = "sbe2" ,hall="3813" ,time=2,name="sub2"},
                new Class(){code = "sbe3" ,hall="7863" ,time=2,name="sub3"},
                new Class(){code = "sbe4" ,hall="6823" ,time=2,name="sub4"},
            };
            _st.Add(students);
            _pf.Add(profs);
            classes.ForEach(x => _cl.Add(x));
            for (int i = 0; i < 5; i++)
            {
                _st.AssignToClass(students[i], classes[0].code);
                _st.AssignToClass(students[i + 5], classes[1].code);
            }
            _pf.AssignToClass(profs[0], classes[0].code);
            _pf.AssignToClass(profs[1], classes[1].code);
        }
        private void RemoveDummyData()
        {
            _st.RemoveAll();
            _pf.RemoveAll();
            _cl.RemoveAll();
            _ac.RemoveAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void controlPanelButt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void classControlPart_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _nav.Display(_nav.studentsPanel);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }





        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void controlPicture1_Click(object sender, EventArgs e)
        {

        }

        private void controlPanelButt_Click_1(object sender, EventArgs e)
        {
            _nav.Display(_nav.controlPanel);
        }

        private void classPanelButt_Click(object sender, EventArgs e)
        {
            _nav.Display(_nav.classesPanel);
        }

        private void profPanelButt_Click(object sender, EventArgs e)
        {
            _nav.Display(_nav.professorsPanel);
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            Close();
            new SignIn(_st, _ac, _nav, _cl, _pf).Show();
        }
    }
}