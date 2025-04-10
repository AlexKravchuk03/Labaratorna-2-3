using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_3
{
    public class ProgrammingBasicsFactory : DisciplineFactory
{
    public override Discipline CreateDiscipline()
    {
        return new Discipline("Основи програмування", 1, 1, true);
    }
}
}
