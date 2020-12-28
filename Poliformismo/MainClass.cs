using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Poliformismo
{
    class MainClass
    {
        static void Main(string[] args)
        {
            IAnimal ivaca = new Vaca("muuuumuuuu");
            IAnimal igallina = new Gallina("kikikiki");
            IAnimal icerdo = new Cerdo("oinkoink");
            /*Vaca v = new Vaca("muuumuuu");
            Gallina g = new Gallina("kikikiki");
            Cerdo c = new Cerdo("oinkoink");

            v.comunicarse();
            g.comunicarse();
            c.comunicarse();*/

            ivaca.Comunicarse();
            igallina.Comunicarse();
            icerdo.Comunicarse();
        }
    }
}
