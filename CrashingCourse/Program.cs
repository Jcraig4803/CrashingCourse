using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashingCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Name = "Spark";
            cat.Gender = 'M';
            var noise = cat.MakeNoise();
            Console.WriteLine(noise);

            var dog= new Dog();
            dog.Name = "Chopper";
            dog.Gender = 'M';
            noise = dog.MakeNoise();
            Console.WriteLine(noise);
            
            List <Animal>animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name + "-" +  animal.Gender);
            }

            Console.Read();
        }
        }
    }

