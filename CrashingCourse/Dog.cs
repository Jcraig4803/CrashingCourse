using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashingCourse
{
   public class Dog : Animal
    {
        public Dog(int age, string name, char gender, bool Fixed, double weight, double height)
        {
            

            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.Fixed = Fixed;
            this.Weight = weight;
            this.Height = height;
        }
        public Dog()
        {

        }
        public override string MakeNoise()
        {
            return "Woof";
        }
    }
}
