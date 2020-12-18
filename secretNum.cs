using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class secretNum
    {
        static void Main(string[] args){
            //RANDOM NUMBER
            Random rd = new Random();
            int numSecret = rd.Next(1, 5);
            Console.WriteLine(numSecret);

            for(int i = 0; i<3; i++)
            {
                int num = 0;
                Console.WriteLine("Intento " + (i + 1) + ":");
                int.TryParse(Console.ReadLine(), out num);

                if(num == numSecret){
                    Console.WriteLine("Acertaste!!!!");
                    break;
                }
                else if(i == 2){
                    Console.WriteLine("HAS PERDIDO");
                }
                else
                {

                    Console.WriteLine("Prueba otra vez, fallaste");
                }
            }
        }
    }
}
