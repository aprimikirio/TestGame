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

            RedSquare.AddToCanv();
            GameObjects.Add(RedSquare);
        }
        
        public void AddObject()
        {
           bool kek = true;

           while(kek == true)
           {
                kek = this.AddObject(rand.Next(0, 400), rand.Next(0, 400), rand.Next(50, 85));
           }
        }

        public bool AddObject(double x, double y, double edg)
        {
            GOSquare Vasya1 = new GOSquare(edg,
                new Coords(x, y),
                "Vasya", mCanvas,
                new ClrRGB(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));

            bool isin = true;

            foreach (GOSquare gsq in GameObjects)
            {
                if (!Vasya1.IsIn(gsq) == false)                
                {
                    isin = false;
                }
            }

            if (isin)
            {
                GameObjects.Add(Vasya1);
                Vasya1.AddToCanv();
                mTextBox.Text = " OUT \n";
            }
            else
            {
                mTextBox.Text = " IN \n";
                isin = false;
            }

            return !isin;
        }

        public bool IsIn(GOSquare a, GOSquare b)
        {
            return (b.RT.x >= a.LB.x && b.LB.x <= a.RT.x) 
                && (b.RT.y >= a.LB.y && b.LB.y <= a.RT.y);
        }

        public void Move( string d)
        {
            //RedSquare.Move(d);

            bool isin = true;

            foreach (GOSquare gsq in GameObjects)
            {
                if (gsq != RedSquare)
                if (!RedSquare.Moved(d).IsIn(gsq) == false)
                {
                    isin = false;
                }
            }

            if (isin)
            {
                RedSquare.Move(d);
                mTextBox.Text = "Move \n";
            }
            else
            {
                mTextBox.Text = " Can`t \n";
                isin = false;
            }
        }
        
    }
}
