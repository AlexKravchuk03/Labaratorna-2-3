using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_2
{
    public class Student
    {
        public string Surname { get; private set; }
        public bool HasComputer { get; private set; }
        public bool CompletedAllWorks { get; set; } = false;

        public Student(string surname, bool hasComputer)
        {
            Surname = surname;
            HasComputer = hasComputer;
        }
    }
}
