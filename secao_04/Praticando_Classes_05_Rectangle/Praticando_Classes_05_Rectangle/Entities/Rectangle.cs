using System;
using System.Collections.Generic;
using System.Text;

namespace Praticando_Classes_05_Rectangle.Entities
{
    class Rectangle
    {
        public double Width;
        public double Height;
        public double Area()
        {
            return Width * Height;
        }
        public double Perimetro()
        {
            return 2 * (Width + Height);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }
    }
}
