using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TestGame.Structures
{
    struct ClrRGB
    {
        public int alpha;
        public int red;
        public int green;
        public int blue;
        public SolidColorBrush color;

        public ClrRGB(int _red, int _green, int _blue)
        {
            alpha = 255;
            red = _red;
            green = _green;
            blue = _blue;
            color = new SolidColorBrush(Color.FromArgb((byte)alpha, (byte)red, (byte)green, (byte)blue));

        }
    }
}
