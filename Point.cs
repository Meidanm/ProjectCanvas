using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Point
    {
        private int x;
        private int y;


        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal int GetX()
        {
            return this.x;
        }

        internal int GetY()
        {
            return this.y;
        }

        internal void SetX(int x)
        {
            if (x > 0 && x < 800)
            {
                this.x = x;
            }
            else
            {
                Console.WriteLine($"x value {x} is invaild");
            }
        }

        internal void SetY(int y)
        {
            if (y > 0 && y < 600)
            {
                this.y = y;
            }
            else
            {
                Console.WriteLine($"y value {y} is inviald");
            }
        }

        public override string ToString()
        {
            return ($"X:{this.x}, Y:{this.y}");
        }
    }
}
