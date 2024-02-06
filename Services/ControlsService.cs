using SchoolManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Services
{
    public class ControlsService
    {
        private List<UserControl> controls;
        private Panel panel;
        public readonly int classesControl = 0;
        public readonly int professorsControl = 1;
        public readonly int studentsControl = 2;
        public readonly int controlPanalControl = 3;
        public ControlsService()
        {
        }
        public void Initialize(List<UserControl> userControls, Panel panel)
        {
            controls = userControls;
            this.panel = panel;
            AddUserControls();
        }
        public void AddUserControls()
        {
            for (int i = 0; i < controls.Count(); i++)
            {
                controls[i].Dock = DockStyle.Fill;
                panel.Controls.Add(controls[i]);
            }
        }
        public void Display(int index)
        {
            if (index < controls.Count())
            {
                controls[index].BringToFront();
            }
        }

    }
}
