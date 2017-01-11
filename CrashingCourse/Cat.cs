using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashingCourse
{
    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public bool Fixed { get; set; }
        public double Weight { get; set; }

        public Cat(int age, string name, char gender, bool Fixed, double weight)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.Fixed = Fixed;
            this.Weight = weight;


        }

    }
}
