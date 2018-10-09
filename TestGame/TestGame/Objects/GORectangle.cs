using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Structures;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace TestGame.Objects
{
    class GORectangle : GameObject
    {
        public Rectangle mRectangle = new Rectangle();

        public GORectangle(double edgeH, double edgeW, Coords _crd, string _name, Canvas _mCanvas, ClrRGB _color) : base(edgeH, edgeW, _crd, _name)
        {
            height = edgeH;
            width = edgeW;
            name = _name;
            mCanvas = _mCanvas;

            Crds.LB.x = _crd.x;
            Crds.LB.y = _crd.y;

            Crds.RB.x = Crds.LB.x + width;
            Crds.RB.y = Crds.LB.y;

            Crds.RT.x = Crds.LB.x + width;
            Crds.RT.y = Crds.LB.y + height;

            Crds.LT.x = Crds.LB.x;
            Crds.LT.y = Crds.LB.y + height;

            mRectangle = new Rectangle();
            mRectangle.Name = _name.Replace(" ", string.Empty);
            mRectangle.Height = height;
            mRectangle.Width = width;
            mRectangle.Fill = _color.color;
        }

        public void AddToCanv()
        {
            mCanvas.Children.Add(mRectangle);
            Refresh();
        }
        public override void Refresh()
        {
            Canvas.SetLeft(this.mRectangle, this.Crds.LB.x);
            Canvas.SetBottom(this.mRectangle, this.Crds.LB.y);
        }

        public double Height
        {
            get { return height; }
            set { this.height = value; this.width = value; }
        }
        public double Width
        {
            get { return width; }
            set { this.height = value; this.width = value; }
        }
    }
}
