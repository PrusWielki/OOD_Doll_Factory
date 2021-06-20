using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Retake_1
{
    class Centaur : ConsoleApplication1.IToy
    {

        string name;
        int age;
        float height;
        bool beard;

        public Centaur(string name, int age, float height, bool beard)
        {
            this.beard = beard;
            this.name = name;
            this.age = age;
            this.height = height;
        }

        public bool Beard()
        {
            return beard;
        }
        public string Name()
        {
            return name;
        }
        public int Age()
        {
            return age;
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
            string toreturn = "";
            if (this.Beard())
                toreturn = "I have a beard";
            return "I'm a Centaur."+$"I am {this.Name()}"+ $"{this.Age()} years of age"+ $"I am {this.Height()} cm high"+toreturn;
        }
    }
}
