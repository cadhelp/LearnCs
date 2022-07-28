using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyOverriding
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            
            // this line comes in by default and means
            // by default it just calls the Shape.Draw method
            // but since we need a special draw method for rectangle
            // we will have our own code here. for now, just a Consolewriteline
            // NOTE the base.Draw() only works if Shape is not abstract
            // now that the Shape class and Draw methods are abstract we must
            // create our own Draw class for every derived class
            //base.Draw(); 

            Console.WriteLine("Draw a rectangle");
        }
    }

}