using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class MetodoLetra
    {
        static void Main(string[] args){

            string frase = "Dábale arroz a la zorra el Abad";
            int aCount = 0;

            Console.WriteLine(frase);

            for (int i=0; i<frase.Length; i++)
            {
                if(frase.Substring(i, 1) == "a"){
                    aCount++;
                }
            }

            Console.WriteLine("Has escrito: " + aCount + " a");
        }
    }
}
