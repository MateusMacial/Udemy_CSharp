using _04_HerancaMultipla.Devices;
using System;

namespace _04_HerancaMultipla
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice { SerialNumber = 2030 };
            c.Print("Teste");
            c.ProcessDoc("Teste");
            Console.WriteLine(c.Scan());
        }
    }
}
