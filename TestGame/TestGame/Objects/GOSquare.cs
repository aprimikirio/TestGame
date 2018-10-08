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
    class GOSquare : GameObject
    {
        public Rectangle SquareRect = new Rectangle();
        private int angle = 0;
        public int Speed = 1;

        public GOSquare(double edge, Coords _crd, string _name, Canvas _mCanvas, ClrRGB _color) : base(edge, edge, _crd, _name)
        {
            height = edge;
            width = edge;
            crd = _crd;
            name = _name;
            mCanvas = _mCanvas;

            Crds.LB.x = crd.x;
            Crds.LB.y = crd.y;

            Crds.RB.x = Crds.LB.x + width;
            Crds.RB.y = Crds.LB.y;

            Crds.RT.x = Crds.LB.x + width;
            Crds.RT.y = Crds.LB.y + height;

            Crds.LT.x = Crds.LB.x;
            Crds.LT.y = Crds.LB.y + height;

            SquareRect = new Rectangle();
            SquareRect.Name = _name.Replace(" ", string.Empty);
            SquareRect.Height = edge;
            SquareRect.Width = edge;
            SquareRect.Fill = _color.color;
        }

        public void AddToCanv()
        {
            mCanvas.Children.Add(SquareRect);
            Refresh();
        }

        public override void Refresh()
        {
            Canvas.SetLeft(this.SquareRect, this.crd.x);
            Canvas.SetBottom(this.SquareRect, this.crd.y);
        }

        public void Rotate()
        {
            RotateTransform rotateTransformSquare;

            if (angle > 90)
            {
                rotateTransformSquare = new RotateTransform(angle - 90);
                crd.x = crd.x + height; angle = 0; Refresh();
            }
            else
            {
                rotateTransformSquare = new RotateTransform(angle);
            }

            rotateTransformSquare.CenterX = height;
            rotateTransformSquare.CenterY = width;
            SquareRect.RenderTransform = rotateTransformSquare;

            angle += 5;
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
