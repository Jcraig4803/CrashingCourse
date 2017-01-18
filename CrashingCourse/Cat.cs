using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashingCourse
{
   public class Cat : Animal
    {       
        public Cat(int age, string name, char gender, bool Fixed, double weight, double height)
        {
            

            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.Fixed = Fixed;
            this.Weight = weight;
            this.Height = height;
        }
        public Cat()
        {

        }




        public override string MakeNoise()
        {
            return "Meow";
        }
    }
}
