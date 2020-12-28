using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Poliformismo
{
    class Vaca:Animal
    {
        public Vaca(string sonido) : base(sonido) { }

        public override void comunicarse(){
            Console.WriteLine("Cuando la vaca tiene leche hace " + sonido);
        }
    }
}
