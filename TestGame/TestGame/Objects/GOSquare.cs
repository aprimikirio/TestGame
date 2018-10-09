using TestGame.Structures;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace TestGame.Objects
{
    class GOSquare : GORectangle
    {
        private int angle = 0;
        public int Speed = 1;

        public GOSquare(double edge, Coords сoordinatеs, string name, Canvas mainCanvas, ClrRGB color) 
            : base(edge, edge, сoordinatеs, name, mainCanvas, color)
        {
            height = edge;
            width = edge;
            this.name = name;
            mCanvas = mainCanvas;

            Crds.LB.x = сoordinatеs.x;
            Crds.LB.y = сoordinatеs.y;

            Crds.RB.x = Crds.LB.x + width;
            Crds.RB.y = Crds.LB.y;

            Crds.RT.x = Crds.LB.x + width;
            Crds.RT.y = Crds.LB.y + height;

            Crds.LT.x = Crds.LB.x;
            Crds.LT.y = Crds.LB.y + height;

            mRectangle = new Rectangle();
            mRectangle.Name = this.name.Replace(" ", string.Empty);
            mRectangle.Height = edge;
            mRectangle.Width = edge;
            mRectangle.Fill = color.color;
        }

        public void Rotate()
        {
            RotateTransform rotateTransformSquare;

            if (angle > 90)
            {
                rotateTransformSquare = new RotateTransform(angle - 90);
                Crds.LB.x = Crds.LB.x + height; angle = 0; Refresh();
            }
            else
            {
                rotateTransformSquare = new RotateTransform(angle);
            }

            rotateTransformSquare.CenterX = height;
            rotateTransformSquare.CenterY = width;
            mRectangle.RenderTransform = rotateTransformSquare;

            angle += 5;
        }
    }
}
