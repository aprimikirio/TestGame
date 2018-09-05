using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Structures;
using System.Windows.Shapes;
using System.Windows.Media;

namespace TestGame.Objects
{
    class GOSquare : GameObject
    {
        public Rectangle SquareRect = new Rectangle();

        public GOSquare(double edge, Coords _crd, string _name) : base(edge, edge, _crd, _name)
        {
            height = edge;
            width = edge;
            crd = _crd;
            name = _name;

            SquareRect = new Rectangle();
            SquareRect.Name = _name;
            SquareRect.Height = edge;
            SquareRect.Width = edge;
            SquareRect.Fill = new SolidColorBrush(Color.FromArgb(255, (byte)0, (byte)10, (byte)200));
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
