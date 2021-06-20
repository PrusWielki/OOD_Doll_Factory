using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class RaceDriver : IToy
    {
        public float Height()
        {
            return 80f;
        }
        public float Cost()
        {
            return 200f;
        }

        public string Summary()
        {
            return "I'm a race driver." + $"I am {this.Height()} cm high";
        }
    }
}
