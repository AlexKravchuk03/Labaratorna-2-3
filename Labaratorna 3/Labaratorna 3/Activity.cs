using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorna_3
{
    public class Activity
    {
        public ActivityType Type { get; set; }
        public Teacher Instructor { get; set; }

        public Activity(ActivityType type, Teacher instructor)
        {
            Type = type;
            Instructor = instructor;
        }
    }
}
