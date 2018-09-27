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

        public GOSquare(double edge, Coords _crd, string _name, Canvas _mCanvas, ClrRGB _color) : base(edge, edge, _crd, _name)
        {
            height = edge;
            width = edge;
            crd = _crd;
            name = _name;
            mCanvas = _mCanvas;

            SquareRect = new Rectangle();
            SquareRect.Name = _name.Replace(" ", string.Empty);
            SquareRect.Height = edge;
            SquareRect.Width = edge;
            SquareRect.Fill = _color.color;

            mCanvas.Children.Add(SquareRect);
            Refresh();
        }

        public void Refresh()
        {
            Canvas.SetLeft(this.SquareRect, this.crd.x);
            Canvas.SetBottom(this.SquareRect, this.crd.y);

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
