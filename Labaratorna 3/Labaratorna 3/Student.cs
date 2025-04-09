using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_3
{
    public class Student : IObserver
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public bool HasComputer { get; set; }
        public bool LabWorksCompleted { get; set; }

        public Student(string name, int course, bool hasComputer)
        {
            Name = name;
            Course = course;
            HasComputer = hasComputer;
            LabWorksCompleted = false;
        }

        public void Update(string message)
        {
            Console.WriteLine($"[Студент {Name}] отримав повідомлення: {message}");
        }
    }
}
