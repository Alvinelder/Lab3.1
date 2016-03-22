using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("john Doe", "English");
            Instructor mike = new Instructor("Mike Jones", "Math");

            Student jane = new Student("Jane Pittman", john, 0);
            Student joe = new Student("Joe Dancer", john, 0);
            Student melissa = new Student("Melissa Ford", mike,0);
            Student matt = new Student("Matt Davis", mike, 0);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);


            System.Console.WriteLine("Press any key to continue..");
            Console.ReadKey();


        }
    }
}
