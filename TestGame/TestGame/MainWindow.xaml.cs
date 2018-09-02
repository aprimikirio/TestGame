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

namespace TestGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int RectangleHeight = 25;

            Rectangle MainRect = new Rectangle();
            MainRect.Name = "MainRect";
            MainRect.Height = RectangleHeight;
            MainRect.Width = MainRect.Height;
            MainRect.Fill = new SolidColorBrush(Color.FromArgb(255, (byte)0, (byte)10, (byte)200));
            MainCanvas.Children.Add(MainRect);
            Canvas.SetLeft(MainRect, 10);
            Canvas.SetTop(MainRect, 10);
        }
    }
}
