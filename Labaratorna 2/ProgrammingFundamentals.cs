using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_2
{
    public class ProgrammingFundamentals : Discipline
    {
        public ProgrammingFundamentals() : base("Основи Програмування", 1, 64) { }

        public override bool CanBeStudied(StudentGroup group) => group.CurrentCourse == 1;
    }

    public class ObjectOrientedProgramming : Discipline
    {
        public ObjectOrientedProgramming() : base("ООП", 2, 64) { }

        public override bool CanBeStudied(StudentGroup group) => group.CurrentCourse == 1 || group.CurrentCourse == 2;
    }
}
  
