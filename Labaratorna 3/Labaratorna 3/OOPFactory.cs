using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_3
{
   public class OOPFactory : DisciplineFactory
{
    public override Discipline CreateDiscipline()
    {
        return new Discipline("ООП", 1, 2);
    }
}
}
