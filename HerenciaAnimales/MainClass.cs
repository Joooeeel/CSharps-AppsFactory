using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.HerenciaAnimales
{
    class MainClass
    {
        static void Main(string[] args){
            new Vaca("muuuuuuu");
            new Perro("guuuauuguaaauu");
            new Gato("miaaaauu");

            Console.WriteLine(Animal.sonidoMasLargo);
        }
    }
}
