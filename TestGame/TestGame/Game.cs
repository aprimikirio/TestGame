using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private List<GameObject> GameObjects;
        private Random rand;
        private GORectangle Road;
        private GOSquare RedSquare;
        private TextBlock mTextBox;

        public Game(Canvas mainCanvas, TextBlock debugInfoTextBox)
        {
            mCanvas = mainCanvas;
            GameObjects = new List<GameObject>();
            rand = new Random();
            mTextBox = debugInfoTextBox;

            Road = new GORectangle(50,mCanvas.Width,
                new Coords(0, 0),
                "DOROGA", mCanvas,
                new ClrRGB(10, 10, 10));

            Road.AddToCanv();
            GameObjects.Add(Road);

            RedSquare = new GOSquare( 100,
                new Coords(100, 100),
                "RedSquare", mCanvas,
                new ClrRGB(255, 0, 0));

            RedSquare.Speed = 1;

            RedSquare.AddToCanv();
            GameObjects.Add(RedSquare);
        }
        
        public void AddObject()
        {
           bool kek = true;
           int minEdge = 50;
           int maxEdge = 80;

            while (kek == true)
           {
                kek = this.AddObject(rand.Next(0, Convert.ToInt32(mCanvas.Width) - maxEdge), 
                    rand.Next(0, Convert.ToInt32(mCanvas.Height) - maxEdge), rand.Next(minEdge, maxEdge));
           }
        }

        public bool AddObject(double x, double y, double edg)
        {
            GOSquare Vasya1 = new GOSquare(edg,
                new Coords(x, y),
                "Vasya", mCanvas,
                new ClrRGB(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));

            bool isin = true;

            foreach (GameObject gsq in GameObjects)
            {
                if (!Vasya1.Intersect(gsq.Crds) == false)                
                {
                    isin = false;
                }
            }

            if (isin)
            {
                GameObjects.Add(Vasya1);
                Vasya1.AddToCanv();
            }
            else
            {
                isin = false;
            }

            return !isin;
        }

        public void Move(Drctn d)
        {
            bool isin = true;

            mTextBox.Text = RedSquare.Crds.LB.x.ToString() + " ";
            mTextBox.Text += RedSquare.Crds.LB.y.ToString();
            mTextBox.Text += "\n";

            mTextBox.Text += RedSquare.GetMoved(d, 1).LB.x.ToString() + " ";
            mTextBox.Text += RedSquare.GetMoved(d, 1).LB.y.ToString();
            mTextBox.Text += "\n";

            foreach (GameObject gsq in GameObjects)
            {
                if (gsq != RedSquare)
                { 
                    if (gsq.Intersect(RedSquare.GetMoved(d, 1)))
                    {
                        isin = false;
                    }
                }
            }

            if (isin)
            {
                RedSquare.Move(d, RedSquare.Speed);
                mTextBox.Text += "Move \n";
            }
            else
            {
                mTextBox.Text += " Can`t \n";
                isin = false;
            }


        }
        
    }
}
