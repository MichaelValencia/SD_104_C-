using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_example_OOP
{
    class shoes
        //variables
    { string color, brand, size;

        public shoes(string color, string brand, string size)
        {
            
            this.color = color;
            this.brand = brand;
            this.size = size;
        }

        public override string ToString()
        {
            return color + " " + size + " " + brand;
        }
    }
}
