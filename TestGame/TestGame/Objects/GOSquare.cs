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
        private Rectangle SquareRect = new Rectangle();
        private Canvas mCanvas;
        private int angle = 0;
        public Coords LB, RB, RT, LT;

        public GOSquare(double edge, Coords _crd, string _name, Canvas _mCanvas, ClrRGB _color) : base(edge, edge, _crd, _name)
        {
            height = edge;
            width = edge;
            crd = _crd;
            LB = _crd;
            name = _name;
            mCanvas = _mCanvas;

            RB.x = LB.x + width;
            RB.y = LB.y;

            RT.x = LB.x + width;
            RT.y = LB.y + height;

            LT.x = LB.x;
            LT.y = LB.y + height;


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
                rotateTransformSquare = new RotateTransform(angle-90);
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

        public bool IsIn(GOSquare InSquare)
        {
            if ((InSquare.LB.x >= LB.x) && (InSquare.RT.x <= RT.x)
                && (InSquare.LB.y >= LB.y) && (InSquare.RT.x <= RT.y))
                return true;
            else
                return false;
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
