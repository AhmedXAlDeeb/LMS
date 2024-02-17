﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class ProfessorUser
    {
        [Key]
        public int Id { get; set; }
        public int profId { get; set; }
        public int userId { get; set; }
    }
}
