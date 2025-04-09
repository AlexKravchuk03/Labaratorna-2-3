using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_3
{
    public class Teacher
    {
        public string Name { get; set; }
        public List<string> Disciplines { get; set; } = new();

        public Teacher(string name)
        {
            Name = name;
        }
    }
}
