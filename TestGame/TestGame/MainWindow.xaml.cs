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
        GOSquare Square2;
        GOSquare Square3;
        GOSquare Square4;
        GOSquare Square5;

        public MainWindow()
        {
            InitializeComponent();

            Square1 = new GOSquare(45, new Coords(40, 80), "Vasya", MainCanvas, new ClrRGB(1488, 1488, 1488));
            Square2 = new GOSquare(60, new Coords(60, 100), "Fiesal", MainCanvas, new ClrRGB(255, 0, 0));
            Square3 = new GOSquare(75, new Coords(80, 120), "Andrei", MainCanvas, new ClrRGB(0, 255, 0));
            Square4 = new GOSquare(90, new Coords(100, 140), "Pidoras", MainCanvas, new ClrRGB(0, 0, 255));
            Square5 = new GOSquare(105, new Coords(120, 160), "Vam Povistka", MainCanvas, new ClrRGB(1337, 228, 1488));

        }

        private void MainCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Left")
            {
                Square1.Movement("Left");
                Square2.Movement("Left");
                Square3.Movement("Left");
                Square4.Movement("Left");
                Square5.Movement("Left");
            }
            else if (e.Key.ToString() == "Right")
            {
                Square1.Movement("Right");
                Square2.Movement("Right");
                Square3.Movement("Right");
                Square4.Movement("Right");
                Square5.Movement("Right");
            }
            Square1.Refresh();
            Square2.Refresh();
            Square3.Refresh();
            Square4.Refresh();
            Square5.Refresh();
        }
    }
}
