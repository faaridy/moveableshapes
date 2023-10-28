using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveableshapes
{
    internal class Shape
    {
        private Color color = Color.Red;
        private Boolean filled = false;

        public Shape()
        {
        }

        public Shape(Color color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public bool GetFilled()
        {
            return filled;
        }

        public void SetFilled(bool value)
        {
            filled = value;
        }

        public Color GetColor()
        {
            return color;
        }

        public void SetColor(Color value)
        {
            color = value;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
