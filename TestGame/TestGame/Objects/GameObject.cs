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
        public Coords crd;
        public string name;
        public Canvas mCanvas;
        public RectangleCrds Crds;

        public GameObject(double _height, double _width, Coords _crd, string _name)
        {
            height = _height;
            width = _width;            
            crd = _crd;
            name = _name;

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
                    ChngVrtCrd(delta, movedCrds);
                break;
                case Drctn.Right:
                    ChngHrzCrd(delta, movedCrds);
                break;
                case Drctn.Down:
                    ChngVrtCrd(-delta, movedCrds);
                break;
                case Drctn.Left:
                    ChngHrzCrd(-delta, movedCrds);
                break;
            }

            return movedCrds;
        }

        public void ChngHrzCrd(double delta)
        {
            crd.x += delta;
            Crds.LB.x += delta;
            Crds.LT.x += delta;
            Crds.RT.x += delta;
            Crds.RB.x += delta;
        }
        public void ChngHrzCrd(double delta, RectangleCrds InputRCrds)
        {
            //crd.x += delta;
            InputRCrds.LB.x += delta;
            InputRCrds.LT.x += delta;
            InputRCrds.RT.x += delta;
            InputRCrds.RB.x += delta;
        }
        public void ChngVrtCrd(double delta)
        {
            crd.y += delta;
            Crds.LB.y += delta;
            Crds.LT.y += delta;
            Crds.RT.y += delta;
            Crds.RB.y += delta;
        }
        public void ChngVrtCrd(double delta, RectangleCrds InputRCrds)
        {
            //crd.y += delta;
            InputRCrds.LB.y += delta;
            InputRCrds.LT.y += delta;
            InputRCrds.RT.y += delta;
            InputRCrds.RB.y += delta;
        }
        virtual public void Refresh() { }

        virtual public void Move(string direction) {}

    }
}
