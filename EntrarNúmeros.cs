using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class EntrarNúmeros
    {
        

        static void Main(string[] args){

            bool isCounting = true;
            int n = 1;

            const int value = -1;

            while (isCounting){
                int temp = 0;
                

                Console.WriteLine("Entra un número: ");
                int.TryParse(Console.ReadLine(), out temp);

                if(temp == value){
                    isCounting = false;
                }

                n++;
            }

            Console.WriteLine("Has introducido: " + n + " valores");
        }
    }
}
