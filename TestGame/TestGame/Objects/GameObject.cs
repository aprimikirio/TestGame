using TestGame.Structures;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace TestGame.Objects
{
    abstract class GameObject
    {
        public double height;
        public double width;
        public string name;
        public Canvas mCanvas;
        public RectangleCrds Crds;


        public GameObject(double _height, double _width, Coords _crd, string _name)
        {
            height = _height;
            width = _width;    
            name = _name;

            Crds.LB.x = _crd.x;
            Crds.LB.y = _crd.y;

            Crds.RB.x = Crds.LB.x + width;
            Crds.RB.y = Crds.LB.y;

            Crds.RT.x = Crds.LB.x + width;
            Crds.RT.y = Crds.LB.y + height;

            Crds.LT.x = Crds.LB.x;
            Crds.LT.y = Crds.LB.y + height;
        }
        public bool Intersect(RectangleCrds InputRCrds)
        {
            return (Crds.RT.x >= InputRCrds.LB.x && Crds.LB.x <= InputRCrds.RT.x)
                && (Crds.RT.y >= InputRCrds.LB.y && Crds.LB.y <= InputRCrds.RT.y);
        }
        public void Move(Drctn direction, double delta)
        {
            switch (direction)
            {
                case Drctn.Up:
                    ChngVrtCrd(delta);
                    break;
                case Drctn.Right:
                    ChngHrzCrd(delta);
                    break;
                case Drctn.Down:
                    ChngVrtCrd(-delta);
                    break;
                case Drctn.Left:
                    ChngHrzCrd(-delta);
                    break;
            }
            Refresh();
        }
        public RectangleCrds GetMoved(Drctn direction, double delta)
        {
            RectangleCrds movedCrds;

            movedCrds.LB = this.Crds.LB;
            movedCrds.LT = this.Crds.LT;
            movedCrds.RB = this.Crds.RB;
            movedCrds.RT = this.Crds.RT;

            switch (direction)
            {
                case Drctn.Up:
                    movedCrds.LB.y += delta;
                    movedCrds.LT.y += delta;
                    movedCrds.RT.y += delta;
                    movedCrds.RB.y += delta;
                    break;
                case Drctn.Right:
                    movedCrds.LB.x += delta;
                    movedCrds.LT.x += delta;
                    movedCrds.RT.x += delta;
                    movedCrds.RB.x += delta;
                    break;
                case Drctn.Down:
                    movedCrds.LB.y -= delta;
                    movedCrds.LT.y -= delta;
                    movedCrds.RT.y -= delta;
                    movedCrds.RB.y -= delta;
                    break;
                case Drctn.Left:
                    movedCrds.LB.x -= delta;
                    movedCrds.LT.x -= delta;
                    movedCrds.RT.x -= delta;
                    movedCrds.RB.x -= delta;
                    break;
            }

            return movedCrds;
        }

        public void ChngHrzCrd(double delta)
        {
            Crds.LB.x += delta;
            Crds.LT.x += delta;
            Crds.RT.x += delta;
            Crds.RB.x += delta;
        }
        public void ChngVrtCrd(double delta)
        {
            Crds.LB.y += delta;
            Crds.LT.y += delta;
            Crds.RT.y += delta;
            Crds.RB.y += delta;
        }
        virtual public void Refresh() { }

        virtual public void Move(string direction) {}

    }
}
