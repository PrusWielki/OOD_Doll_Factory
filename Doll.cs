using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Doll : IToy
    {
        public float Cost()
        {
            return 100f;
        }

        public float Height()
        {
            return 50f;
        }

        public string Summary()
        {
            return "I'm a doll." + $"I am {this.Height()} cm high";
        }
    }
}
