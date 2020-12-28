using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Poliformismo
{
    class Gallina:Animal
    {
        public Gallina(string sonido) : base(sonido) { }

        public override void comunicarse(){
            Console.WriteLine("Cuando la gallina pone huevos hace " + sonido);
        }
    }
}
