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
        GOSquare Square1;
        GOSquare Square5;

        int angle = 0;

        public MainWindow()
        {
            InitializeComponent();

            Square1 = new GOSquare(45, new Coords(40, 80), "Vasya", MainCanvas, new ClrRGB(1488, 1488, 1488));
            Square5 = new GOSquare(105, new Coords(120, 160), "Vam Povistka", MainCanvas, new ClrRGB(1337, 228, 1488));

        }

        private void MainCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Left")
            {
                //Square1.Movement("Left");
            }
            else if (e.Key.ToString() == "Right")
            {
                //Square1.Movement("Right");
                Square1.Rotate();
            }
        }
    }
}
