using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_3
{
   public class AlgorithmsFactory : DisciplineFactory
 {
    public override Discipline CreateDiscipline()
    {
        return new Discipline("Алгоритми та структури даних", 2, 2);
    }
 }
}
