using Exercise03_OopPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_OopPrinciples
{
    internal class Student : IStudentService
    {
        public List<Course> Courses;
        public List<string> Grades;

        public float calculateGPA()
        {
            float gpa = 0f;
            // calculate GPA
            return gpa;
        }
    }
}
