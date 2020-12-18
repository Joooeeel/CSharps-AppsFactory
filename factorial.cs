using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class factorial
    {
        static void Main(string[] args)
        {
            int num = 0;
            double result = 1;
            Console.WriteLine("Entra un numero");
            int.TryParse(Console.ReadLine(), out num);

            for(int i = num; i > 0; i--){
                result *= i;
            }

            Console.WriteLine("Factorial de: !" + num + "= " + result);
        }
    }
}
