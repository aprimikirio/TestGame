using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestGame.Structures;
using TestGame.Objects;

namespace TestGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //GOSquare Square1;
        //GOSquare Square5;
        Game InitGame;
        int incr;
        

        public MainWindow()
        {
            InitializeComponent();

            InitGame = new Game(MainCanvas, txtbx);
            incr = 0;

        }

        private void MainCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Left")
            {
                InitGame.Move("Left");
            }
            else if (e.Key.ToString() == "Right")
            {
                InitGame.Move("Right");                
            }
            else if (e.Key.ToString() == "Up")
            {
                switch (incr)
                {
                    case 0:
                        InitGame.AddObject(150, 150, 10);
                        incr++; break;
                    case 1:
                        InitGame.AddObject(25, 25, 50);
                        incr++; break;
                    case 2:
                        InitGame.AddObject(110, 0, 40);
                        incr++; break;
                    default:
                        InitGame.AddObject();
                        incr++; break;
                }
                
                //InitGame.AddObject();
            }
        }
    }
}
