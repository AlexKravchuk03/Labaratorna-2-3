using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_2
{
    public abstract class Discipline
    {
        public string Name { get; protected set; }
        public int Course { get; protected set; }
        public int AuditoryHours { get; protected set; }
        public List<Lecturer> Lecturers { get; protected set; } = new List<Lecturer>();

        protected Discipline(string name, int course, int hours)
        {
            Name = name;
            Course = course;
            AuditoryHours = hours;
        }

        public virtual bool CanBeStudied(StudentGroup group)
        {
            return group.CurrentCourse >= 1 && group.CurrentCourse <= 2;
        }

        public void AddLecturer(Lecturer lecturer)
        {
            if (Lecturers.Count < 1)
                Lecturers.Add(lecturer);
            else
                throw new InvalidOperationException("Забагато викладачів для дисципліни");
        }
    }

}
