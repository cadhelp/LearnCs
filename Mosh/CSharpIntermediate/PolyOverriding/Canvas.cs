using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {

                //// This is an example of bad code. To add Triangle or additional shapes
                //// you must add a new ShapeType enum, then add the switch and logic below
                //// this means every file we modify and every file that is referenced by a
                //// modified file needs to be recompiled. Very tightly coupled
                //switch (shape.Type)
                //{
                //    case ShapeType.Circle:
                //        Console.WriteLine("Draw a circle");
                //        break;
                //    case ShapeType.Rectangle:
                //        Console.WriteLine("Draw a rectangle");
                //        break;
                //    case ShapeType.Triangle:
                //        Console.WriteLine("Draw a triangle");
                //        break;
                //}

                // Instead we have added a Circle and Rectangle class
                // and encapsulated the properties and methods in each class
                // this allows us to simply call the draw method of each class
                // now we can simply add new classes like a Triangle or Pentagon
                // without modifying this code any more We can also erase the
                // ShapeType enum class since its no longer needed.
                shape.Draw(); 
            }
        }
    }
}
