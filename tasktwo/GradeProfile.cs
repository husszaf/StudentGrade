using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tasktwo
{
    class GradeProfile //Grade profile Class
    {
        public static void CalcAvg() //calcs average grade
        {

            double avg1 = Program.student1.grades.Average(item => item.Mark); //runs the aveage with Linq
            double avg2 = Program.student2.grades.Average(item => item.Mark);

            WriteLine($"Student ID: {Program.student1.StudentId}\n Name: {Program.student1.Name}\n Course: {Program.student1.Course}\n");//Displays the student1 info

            foreach (Grades g in Program.student1.grades) //Loops in grade list and displays it
            {
                Console.WriteLine($" Module: {g.Module}\n Assignment: {g.Assignment}\n Grade: {g.Mark}\n Year: {g.Year}\n");

            }

            WriteLine($" Average Grade: {avg1}\n");//displays the avg1 variable that calculated the average


            WriteLine($"Student ID: {Program.student2.StudentId}\n Name: {Program.student2.Name}\n Course: {Program.student2.Course}\n"); //Displays the student1 info

            foreach (Grades g in Program.student2.grades) //Loops in grade list and displays it
            {
                Console.WriteLine($" Module: {g.Module}\n Assignment: {g.Assignment}\n Grade: {g.Mark}\n Year: {g.Year}\n ");

            }
            WriteLine($" Average Grade: {avg2}");//displays the avg2 for student 2 variable that calculated the average
        }
    }
}
