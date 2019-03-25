using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_example_OOP
{
    class pants
    {
        //variables
        string lengthsize, widthsize, color, typeOfPants;

        public pants(string lengthsize, string widthsize, string color, string typeOfPants)
        {
            this.lengthsize = lengthsize;
            this.widthsize = widthsize;
            this.color = color;
            this.typeOfPants = typeOfPants;
        }
        public override string ToString()
        {
            return lengthsize + " " + widthsize +" " +color + typeOfPants;        
        }
    }

}
