using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_2
{
    public class UniversityActivity
    {
        public ActivityType Type { get; private set; }
        public Lecturer Lecturer { get; private set; }

        public UniversityActivity(ActivityType type, Lecturer lecturer)
        {
            Type = type;
            Lecturer = lecturer;
        }
    }
}
