using System;
using System.Collections.Generic;
using System.Text;

namespace Praticando_Classe_Metodos
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
