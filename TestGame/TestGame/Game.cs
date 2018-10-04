using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Structures;
using TestGame.Objects;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace TestGame
{
    class Game
    {
        private Canvas mCanvas;
        private List<GOSquare> GameObjects;
        private Random rand;
        private GOSquare RedSquare;
        private TextBlock mTextBox;
        private GOSquare Vasya;

        public Game(Canvas _mCanvas, TextBlock _mTextBox)
        {
            mCanvas = _mCanvas;
            GameObjects = new List<GOSquare>();
            rand = new Random();
            mTextBox = _mTextBox;
            RedSquare = new GOSquare( 100,
                new Coords(100, 100),
                "RedSquare", mCanvas,
                new ClrRGB(255, 0, 0));

            Vasya = new GOSquare(250,
                new Coords(50, 50),
                "Vasya", mCanvas,
                new ClrRGB(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));

            GameObjects.Add(Vasya);
            Vasya.AddToCanv();
        }
        
        public void AddObject()
        {
            this.AddObject(rand.Next(0, 400), rand.Next(0, 480), rand.Next(10, 100));
        }

        public void AddObject(double x, double y, double edg)
        {
            GOSquare Vasya1 = new GOSquare(edg,
                new Coords(x, y),
                "Vasya", mCanvas,
                new ClrRGB(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));

            if (IsIn(Vasya1, Vasya) == false)
            {
                mTextBox.Text = " OUT \n";                
            }
            else mTextBox.Text = " IN \n";

            GameObjects.Add(Vasya1);
            Vasya1.AddToCanv();
        }

        public bool IsIn(GOSquare a, GOSquare b)
        {
            //return (a.RB.x < b.LB.x || b.RB.x < a.LB.x || a.RB.y < b.LB.y || b.RB.y < a.LB.y);
            return (b.RT.x >= a.LB.x && b.LB.x <= a.RT.x) && (b.RT.y >= a.LB.y && b.LB.y <= a.RT.y);
        }

        public void Move( string d)
        {
            RedSquare.Movement(d);
        }
        
    }
}
