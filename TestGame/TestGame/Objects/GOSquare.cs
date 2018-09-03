using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Structures;

namespace TestGame.Objects
{
    class GOSquare : GameObject
    {
        public int Height
        {
            get { return height; }
            set { this.height = value; this.width = value; }
        }
        public int Width
        {
            get { return height; }
            set { this.height = value; this.width = value; }
        }
    }
}
