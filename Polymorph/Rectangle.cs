using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        // constructor
        public Rectangle(int newx, int newy, int newwidth, int newheight) : base(newx, newy)
        {
            setWidth(newwidth);
            setHeight(newheight);
        }

        // accessors for width & height
        public int getWidth() { return width; }
        public int getHeight() { return height; }
        public void setWidth(int newwidth) { width = newwidth; }
        public void setHeight(int newheight) { height = newheight; }

        // draw the rectangle
        public override void draw()
        {
            Console.WriteLine("Drawing a Rectangle at:({0},{1}), Width {2}, Height {3}",
               getX(), getY(), getWidth(), getHeight());
        }
    }
}
