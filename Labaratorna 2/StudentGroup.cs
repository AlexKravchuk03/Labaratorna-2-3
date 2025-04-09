using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_2
{
    public class StudentGroup
    {
        public int CurrentCourse { get; private set; }
        public List<Student> Students { get; private set; } = new List<Student>();

        public StudentGroup(int course)
        {
            CurrentCourse = course;
        }

        public void AddStudent(Student student)
        {
            if (Students.Count < 30)
                Students.Add(student);
            else
                throw new InvalidOperationException("Група вже повна");
        }

        public bool CanStudyDiscipline(Discipline discipline)
        {
            return Students.All(s => s.HasComputer) && discipline.CanBeStudied(this);
        }
    }

}
