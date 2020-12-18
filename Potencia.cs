using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class Potencia
    {
        static void Main(string[] args){

            int b = 0;
            int n = 0;
            int result = 1;

            Console.WriteLine("Entra el número de base");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Entra la potencia");
            int.TryParse(Console.ReadLine(), out n);

            for(int i = 0; i < n; i++){
                result *= b;
            }

            Console.WriteLine("Resultado de la potencia " + b + "^" + n + " : " + result);
        }
    }
}
