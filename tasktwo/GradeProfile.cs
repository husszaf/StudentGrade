using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tasktwo
{
    class GradeProfile
    {
        public static void calcAvg()
        {


            double av1 = Program.student1.grades.Average(item => item.Mark);
            double av2 = Program.student2.grades.Average(item => item.Mark);

            WriteLine($"Student ID: {Program.student1.StudentId}\n Name: {Program.student1.Name}\n Course: {Program.student1.Course}");
            foreach (Grades g in Program.student1.grades)
            {
                Console.WriteLine($"Module: {g.Module}\n Assignment: {g.Assignment}\n Grade: {g.Mark}\n Year: {g.Year}\n");

            }
            WriteLine($" Average Grade: {av1}\n");


            WriteLine($"Student ID: {Program.student2.StudentId}\n Name: {Program.student2.Name}\n Course: {Program.student2.Course}");
            foreach (Grades g in Program.student2.grades)
            {
                Console.WriteLine($"Module: {g.Module}\n Assignment: {g.Assignment}\n Grade: {g.Mark}\n Year: {g.Year}\n ");

            }
            WriteLine($" Average Grade: {av2}");



            /*
            int total = Student.grades.Sum(x => x);
            Console.WriteLine(total);
            int gradeone = Student.grades[0];
            int gradetwo = Student.grades[1];

            //double average = Student.grades.Average();
            //Console.WriteLine($"Average: {average}");


            
             foreach (var g in Grades.grades)
            {
                Console.WriteLine(total);
            }
          */
        }
    }
}
