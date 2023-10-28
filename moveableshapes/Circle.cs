using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveableshapes
{
    class Circle : Shape
    {
        private int radius = 100;

        public Circle()
        {
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public Circle(int radius,Color color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public int GetRadius()
        {
            return radius;
        }

        public void SetRadius(int value)
        {
            radius = value;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public double GetPerimetr()
        {
            return 2 * Math.PI * radius;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
        public void moveUp(int x)
        {
            if (x > 5)
            {
                x -= 5;
            }
            else
            {
                x = 0;
            }

        }

        public void moveDown(int x)
        {
            x += 5;
        }

        public void moveRight(int y)
        {
            y += 5;
        }

        public void moveLeft(int y)
        {
            if (y > 5)
            {
                y -= 5;
            }
            else
            {
                y = 0;
            }
        }
    }
}
