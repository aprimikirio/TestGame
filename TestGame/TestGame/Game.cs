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

        public Game(Canvas _mCanvas)
        {
            mCanvas = _mCanvas;
            GameObjects = new List<GOSquare>();
            rand = new Random();
            RedSquare = new GOSquare( 100,
                new Coords(100, 100),
                "RedSquare", mCanvas,
                new ClrRGB(255, 0, 0));
        }
        
        public void AddObject()
        {
        }

        public void AddObject(double x, double y, double edg)
        {
            GOSquare Vasya = new GOSquare(edg,
                new Coords(x, y),
                "Vasya", mCanvas,
                new ClrRGB(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));

            GameObjects.Add(Vasya);
            Vasya.AddToCanv();
        }

        public void Move( string d)
        {
            RedSquare.Movement(d);
        }
        
    }
}
