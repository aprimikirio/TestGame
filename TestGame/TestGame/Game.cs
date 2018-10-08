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
                if (!Vasya1.Intersect(gsq.Crds) == false)                
                {
                    isin = false;
                }
            }

            if (isin)
            {
                GameObjects.Add(Vasya1);
                Vasya1.AddToCanv();
                mTextBox.Text += " OUT \n";
            }
            else
            {
                mTextBox.Text += " IN \n";
                isin = false;
            }

            return !isin;
        }

        public void Move(Drctn d)
        {
            bool isin = true;

            mTextBox.Text = RedSquare.crd.x.ToString();
            mTextBox.Text += RedSquare.crd.y.ToString();
            mTextBox.Text += "\n";

            mTextBox.Text += RedSquare.Crds.LB.x.ToString();
            mTextBox.Text += RedSquare.Crds.LB.y.ToString();
            mTextBox.Text += "\n";

            if (isin)
                mTextBox.Text += "+\n";
            else
                mTextBox.Text += "-\n";

            foreach (GOSquare gsq in GameObjects)
            {
                if (gsq != RedSquare)
                { 
                if (gsq.Intersect(RedSquare.GetMoved(d, 10)))
                {
                        isin = false;
                }
                }
            }

            if (isin)
                mTextBox.Text += "+\n";
            else
                mTextBox.Text += "-\n";

            if (isin)
            {
                RedSquare.Move(d, 1);
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
