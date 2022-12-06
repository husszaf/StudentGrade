using System;
using static System.Console;
using System.Linq;
using System.Reflection.Metadata;
using System.Collections.Generic;

namespace tasktwo
{
    class Program
    {
        public static Student student1 = new(1, "Hussnain", "Computing");
        public static Student student2 = new(2, "Zaf", "Maths");
        public static void Main(string[] args)
        {
            
            

            Grades grade1 = new(1, "OOP", "Assignment 010", 40, 2022);
            Grades grade2 = new(1, "Networking", "Assignment 023", 50, 2022);

            Grades grade3 = new(2, "Matrices", "Assignment 010", 60, 2022);
            Grades grade4 = new(2, "Algebra", "Assignment 023", 70, 2022);

            student1.grades.Add(grade1);
            student1.grades.Add(grade2);

            student2.grades.Add(grade2);
            student2.grades.Add(grade3);
            // variable that calculate the grade average of a student
            GradeProfile.calcAvg();
            

        }
    }
}