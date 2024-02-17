﻿using SchoolManagementSystem.Models;
using SchoolManagementSystem.panels;
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
        public readonly int classesPanel = 0;
        public readonly int professorsPanel = 1;
        public readonly int studentsPanel = 2;
        public readonly int controlPanel = 3;
        public readonly int classProfilePanel = 4;
        public readonly int professorProfilePanel = 5;
        public readonly int studentProfilePanel = 6;
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
        public void Display(int index,Student student)
        {
            StudentProfilePanel.selectedStudent = student;
            if (index < controls.Count())
            {
                controls[index].BringToFront();
            }
        }
        public void Display(int index,Professor professor)
        {
            ProfessorProfilePanel.selectedProfessor = professor;
            if (index < controls.Count())
            {
                controls[index].BringToFront();
            }
        }
        public void Display(int index ,Class _class)
        {
            ClassProfilePanel.selectedClass = _class;
            if (index < controls.Count())
            {
                controls[index].BringToFront();
            }
        }
    }
}
