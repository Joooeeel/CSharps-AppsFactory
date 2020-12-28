using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Poliformismo
{
    class Cerdo:Animal
    {
        public Cerdo(string sonido) : base(sonido) { }

        public override void comunicarse(){
            Console.WriteLine("Cuando el cerdo esta gordo hace " + sonido);
        }
    }
}
