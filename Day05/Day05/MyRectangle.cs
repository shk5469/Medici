using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class MyRectangle
    {
        public int width;
        public int height;

        public int GetSquare()
        {
            return width * height;
        }

        public int GetArea()
        {
            return (2 * width) + (2 * height);
        }
    }
}
