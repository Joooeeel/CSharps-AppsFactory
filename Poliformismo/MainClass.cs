using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Poliformismo
{
    class MainClass
    {
        static void Main(string[] args)
        {
            
            /*Vaca v = new Vaca("muuumuuu");
            Gallina g = new Gallina("kikikiki");
            Cerdo c = new Cerdo("oinkoink");

            v.Comunicarse();
            g.Comunicarse();
            c.Comunicarse();*/

            IAnimal ivaca = new Vaca("muuuumuuuu");
            IAnimal igallina = new Gallina("kikikiki");
            IAnimal icerdo = new Cerdo("oinkoink");

            ivaca.Comunicarse();
            igallina.Comunicarse();
            icerdo.Comunicarse();
        }
    }
}
