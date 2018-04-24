using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    public class Circle : Shape
    {
        private int radius;

        // constructor
        public Circle(int newx, int newy, int newradius) : base(newx, newy)
        {
            setRadius(newradius);
        }

        // accessors for the radius
        public int getRadius() { return radius; }
        public void setRadius(int newradius) { radius = newradius; }

        // draw the circle
        public override void draw()
        {
            Console.WriteLine("Drawing a Circle at:({0},{1}), Radius {2}",
               getX(), getY(), getRadius());
        }
    }
}
