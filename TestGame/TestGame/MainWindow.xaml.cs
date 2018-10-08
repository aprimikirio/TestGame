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
        Game InitGame;

        public MainWindow()
        {
            InitializeComponent();

            InitGame = new Game(MainCanvas, txtbx);

        }

        private void MainCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == "Left")
            {
                InitGame.Move(Drctn.Left);
            }
            else if (e.Key.ToString() == "Right")
            {
                InitGame.Move(Drctn.Right);                
            }
            else if (e.Key.ToString() == "Up")
            {
                InitGame.AddObject();
            }
        }
    }
}
