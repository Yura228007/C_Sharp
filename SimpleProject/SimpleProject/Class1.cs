using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    internal class Student
    {
        public int mark;
        public string Name { get; set; }
        public bool went { get; set; }
        public bool punished { get; set; }

        public Student(string name, int mark1)
        {
            Name = name;
            went = false;
            punished = false;
            mark = mark1;
        }
    }
}
