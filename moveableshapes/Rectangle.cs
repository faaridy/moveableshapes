using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveableshapes
{
    class Rectangle : Shape 
    {
        private int width = 200;
        private int length = 100;

        public Rectangle()
        {
        }

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(int width, int length,Color color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public int GetLength()
        {
            return length;
        }

        public virtual void SetLength(int value)
        {
            length = value;
        }

        public int GetWidth()
        {
            return width;
        }

        public virtual void SetWidth(int value)
        {
            width = value;
        }

        public double GetArea()
        {
            return width*length;
        }
        public double GetPerimetr()
        {
            return 2 *width + 2*length;
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        
    }
}
