using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyOverriding
{
    public abstract class Shape
    {
        public int Width { get; set; }  
        public int Height { get; set; }

        public ShapeType Type { get; set; }


        // Since drawing a Shape is too ambiguous, we should make it 
        // abstract instead of virtual. Abstract methods are virtual
        // by default so we can override them in the derived classes.
        // You want to make some methods abstract so the derived classes
        // are forced to implement their own version. Like Draw, it is
        // different for circle, rectangles, or stars.
        // below we commented out the virtual method and created an
        // abstract version of it. Once a method is made abstract,
        // the class must also be made abstract.
        // Abstract methods can not be implemented, which is why
        // the below method does not have a body, just semi-colon.
        public abstract void Draw();
        //public virtual void Draw()
        //{
        //    //Adding virtual to the method in a base class allows me to
        //    //override this method in the derived classes like Circle, Rectangle...
        //}

        public void Copy()
        {
            Console.WriteLine("Copy shape to clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }

    }
}
