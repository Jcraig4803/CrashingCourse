using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashingCourse
{
    class Car
    {
        public string color {get; set;}
        public Car() {
            this.color = "Prime Grey";
        }
        public Car(string color)
        {
            this.color = color;
        }
        public string Describe()
        {
            return "This car is " + this.color;
        }
    }
}
