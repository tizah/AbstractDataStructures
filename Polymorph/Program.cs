using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] scribble = new Shape[2];
            Rectangle rect;

            // create some shape instances
            scribble[0] = new Rectangle(10, 20, 5, 6);
            scribble[1] = new Circle(15, 25, 8);

            // iterate through the list and handle shapes polymorphically
            for (int i = 0; i < scribble.Length; i++)
            {
                scribble[i].draw();
                scribble[i].rMoveTo(100, 100);
                scribble[i].draw();
            }

            // call a rectangle specific function
            rect = new Rectangle(0, 0, 15, 15);
            rect.setWidth(30);
            rect.draw();
        
    }
    }
}
