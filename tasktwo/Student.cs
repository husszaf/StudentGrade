using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktwo
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public List<Grades> grades = new List<Grades>();

        public Student(int id, string name, string course)
        {
            this.StudentId = id;
            this.Name = name;
            this.Course = course;
        }

        

    }
}
