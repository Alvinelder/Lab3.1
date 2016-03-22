using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    public class Student
    {
        private string Name, Course;
        private Instructor STeacher;
        private int Grade;

        public Student(string name, Instructor Teacher, int grade)
        {
            this.Name = name;
            this.STeacher = Teacher;
            this.Grade = grade;
            
        }
        public void SetGrade(int grade, string course)
        {
            this.Grade = grade;
            this.Course = course;

        Console.WriteLine("  ");
        Console.WriteLine("Student:  " + this.Name);
        Console.WriteLine("Instructor " + this.STeacher + " class " + this.Course+ " grade " + this.Grade);

        }
        }

    }

