using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktwo
{
    public class Grades
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public string Assignment { get; set; }
        public int Mark { get; set; }
        public int Year { get; set; }

        public Grades(int id, string module, string assignment, int mark, int year)
        {
            this.Id = id;
            this.Module = module;
            this.Assignment = assignment;
            this.Year = year;
            this.Mark = mark;

        }
        

    }
}
