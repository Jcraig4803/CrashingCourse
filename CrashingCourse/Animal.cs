using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashingCourse
{
    public abstract class Animal
    {        
        public int Age { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public bool Fixed { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public virtual string MakeNoise()
        {
            return "Random noise";

        }
    }
    
}
