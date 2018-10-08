using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Structures
{
    struct RectangleCrds
    {
        public Coords LB, RB, RT, LT;

        public RectangleCrds(Coords LeftBottomCoords, Coords LeftTopCoords, Coords RightTopCoords, Coords RightBottomCoords)
        {
            LB = LeftBottomCoords;
            RB = RightBottomCoords;
            RT = RightTopCoords;
            LT = LeftTopCoords;
        }
    }
}
