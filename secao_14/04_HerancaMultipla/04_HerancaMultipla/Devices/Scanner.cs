using System;
using System.Collections.Generic;
using System.Text;

namespace _04_HerancaMultipla.Devices
{
    class Scanner : Device, IScan
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
