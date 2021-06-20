using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Retake_1
{
    class Minotaur:ConsoleApplication1.IToy
    {
       
        string name;
        int age;
        float height;
        float mass;

        public Minotaur(string name, int age, float height, float mass)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.mass = mass;
        }
        public string Name()
        {
            return name;
        }
        public int Age()
        {
            return age;
        }
        public float Mass()
        {
            return mass;
        }
        public float Cost()
        {
            return 250f;
        }

        public float Height()
        {
            return height;
        }

        public string Summary()
        {         
            return "I'm a Minotaur." + $" I am {this.Name()}," + $"{this.Age()} years of age " + $"I am {this.Height()} cm high" + $"My mass: {this.Mass()}";
        }
    }
}
