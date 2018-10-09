using TestGame.Structures;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace TestGame.Objects
{
    class GORectangle : GameObject
    {
        public Rectangle mRectangle = new Rectangle();

        public GORectangle(double height, double width, Coords сoordinatеs, string name, Canvas mainCanvas, ClrRGB color) 
            : base(height, width, сoordinatеs, name)
        {
            this.height = height;
            this.width = width;
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
            mRectangle.Height = height;
            mRectangle.Width = width;
            mRectangle.Fill = color.color;
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
