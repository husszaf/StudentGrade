using System;
using static System.Console;
using System.Linq;
using System.Reflection.Metadata;
using System.Collections.Generic;

namespace tasktwo
{
    class Program
    {
        //Adding students to the Student class
        public static Student student1 = new(1, "Hussnain", "Computing");
        public static Student student2 = new(2, "Ben", "Maths");
        public static void Main(string[] args)
        {
            //Student 1 grades
            Grades grade1 = new(1, "OOP", "Assignment 010", 40, 2022);
            Grades grade2 = new(1, "Networking", "Assignment 023", 60, 2022);
            Grades grade3 = new(1, "Interactive Web", "Assignment 024", 50, 2022);

            //Student 2 grades
            Grades grade4 = new(2, "OOP", "Assignment 010", 60, 2022);
            Grades grade5 = new(2, "Networking", "Assignment 023", 70, 2022);
            Grades grade6 = new(2, "Maths", "Assignment 024", 50, 2022);

            student1.grades.Add(grade1);
            student1.grades.Add(grade2);
            student1.grades.Add(grade3);

            student2.grades.Add(grade4);
            student2.grades.Add(grade5);
            student2.grades.Add(grade6);
            // variable that calculate the grade average of a student
            GradeProfile.CalcAvg();
            

        }
    }
}