using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_ColorBall
{
    internal class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int redValue, int greenValue, int blueValue, int alphaValue)
        {
            red = redValue;
            green = greenValue;
            blue = blueValue;
            alpha = alphaValue;
        }

        public Color(int redValue, int greenValue, int blueValue)
        {
            red = redValue;
            green = greenValue;
            blue = blueValue;
            alpha = 255;
        }

        public int Red { get { return red; } set { red = value; } }
        public int Green { get { return green; } set { green = value; } }
        public int Blue { get { return blue; } set { blue = value; } }  
        public int Alpha { get { return alpha; }
            set
            {
                alpha = value;
            } }

        public float Grayscale { get { return (Red + Green + Blue) / 3; } }
    }
}
