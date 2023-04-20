using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_ColorBall
{
    internal class Ball
    {
        private int size;
        private Color color;
        private int throwCount = 0;

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        public Ball(int size)
        {
            this.size = size;
            this.color = new Color(255, 255, 255, 255);
        }

        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if(size != 0)
            {
                throwCount += 1;
            }
        }

        public int getThrowCount()
        {
            return throwCount;
        }
    }
}
