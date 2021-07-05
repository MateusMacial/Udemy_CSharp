using System;
using System.Collections.Generic;
using System.Text;

namespace _04_HerancaMultipla.Devices
{
    class ComboDevice : Device, IScan, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Combo device print " + document); ;
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combo device processing " + document);
        }

        public string Scan()
        {
            return "Combo device scan result";
        }
    }
}
