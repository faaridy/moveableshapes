using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveableshapes
{
    class Square : Rectangle , IMoveable
    {
        private int side=100;
        
        public Square()
        {
        }

        public Square(int side)
        {
            this.side = side;
        }

        public Square(int width, int length, Color color, bool filled) : base(width, length, color, filled)
        {

        }

        public int GetSide()
        {
            return side;
        }

        public void SetSide(int value)
        {
            side = value;
        }

        public override void SetWidth(int value)
        {
            base.SetWidth(value);
        }

        public override void SetLength(int value)
        {
            base.SetLength(value);
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
