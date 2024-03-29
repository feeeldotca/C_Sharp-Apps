﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageModels
{
    [Serializable]

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseContent { get; set; }
        public int CourseHours { get; set; }
        public int Credit { get; set; }
        public int CategoryId { get; set; }
        public int TeacherId { get; set; }

        // extended property
        public string CategoryName { get; set; }
        public string TeacherName { get; set; }
    }
}
