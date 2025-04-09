using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_2
{
    public class Lecturer
    {
        public string Name { get; private set; }
        public List<Discipline> AssignedDisciplines { get; private set; } = new List<Discipline>();

        public Lecturer(string name)
        {
            Name = name;
        }

        public bool CanTeachDiscipline() => AssignedDisciplines.Count == 0;

        public void AssignDiscipline(Discipline discipline)
        {
            if (CanTeachDiscipline())
                AssignedDisciplines.Add(discipline);
            else
                throw new InvalidOperationException($"Викладач {Name} вже веде дисципліну");
        }
    }
}
