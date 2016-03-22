using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    public class Instructor
    {
        private string Teacher, CourseName;

        public Instructor(string teacher, string course)
        {
        this.Teacher = teacher;
        this.CourseName = course;

            System.Console.WriteLine("Instructor: " + Teacher + " teaches " + CourseName);
        }
    // set  student grade
    public void  SetStudentGrade(Student Student, int grade)
    {
            Student.SetGrade(grade, CourseName);
    }
    }
}
