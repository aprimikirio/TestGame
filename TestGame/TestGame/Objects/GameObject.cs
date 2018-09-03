using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Structures;

namespace TestGame.Objects
{
    abstract class GameObject
    {
        public int height;
        public int width;
        public string name;
        public Coords crd;
    }
}
