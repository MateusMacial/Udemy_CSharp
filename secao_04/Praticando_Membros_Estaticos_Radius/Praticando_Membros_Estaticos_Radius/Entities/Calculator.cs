namespace Praticando_Membros_Estaticos_Radius.Entities
{
    class Calculator
    {
        public static double Pi = 3.14;
        public static double Circumference(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}

