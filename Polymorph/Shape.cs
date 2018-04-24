using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    public abstract class Shape
    {
        private int x;
        private int y;
        


        // constructor
        public Shape(int newx, int newy)
        {
            setX(newx);
            setY(newy);
        }

        // accessors for x & y coordinates
        public int getX() { return x; }
        public int getY() { return y; }
        public void setX(int newx) { x = newx; }
        public void setY(int newx) { y = newx; }

        // move the x & y coordinates
        public void moveTo(int newx, int newy)
        {
            setX(newx);
            setY(newy);
        }
        public void rMoveTo(int deltax, int deltay)
        {
            moveTo(deltax + getX(), deltay + getY());
        }

        // virtual routine - draw the shape
        public abstract void draw();
    }
}
