using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_example_OOP
{
    class Shirts
    {/// <summary>
    /// create a certain type of shirt based on color and sleeves
    /// </summary>
        //variables
        string color;
        string size;
        string sleeves;

        public Shirts(string color, string size, string sleeves)
        {
            this.color = color;
            this.size = size;
            this.sleeves = sleeves;
        }
        public override string ToString()
        {
            return color + " " + size + " " + sleeves;
        }
    }
   
    
}
