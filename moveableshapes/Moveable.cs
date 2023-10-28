using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveableshapes
{
    interface IMoveable
    {
        public void moveUp(int x);

        public void moveDown(int x);

        public void moveRight(int y);

        public void moveLeft(int y);
        
    }
}
