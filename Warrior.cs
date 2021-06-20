using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Warrior : IToy
    {
        public float Cost()
        {
            return 150f;
        }
        public float Height()
        {
            return 100f;
        }
        public string Summary()
        {
            return "I'm a warrior!"+$"I am {this.Height()} cm high";
        }
    }
}
