using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class numSecretWhile
    {
        static void Main(string[] args)
        {

            bool isPlaying = true;

            while (isPlaying)
            {
                //RANDOM NUMBER
                Random rd = new Random();
                int numSecret = rd.Next(1, 5);
                Console.WriteLine(numSecret);

                for (int i = 0; i < 3; i++)
                {
                    int num = 0;
                    Console.WriteLine("Intento " + (i + 1) + ":");
                    int.TryParse(Console.ReadLine(), out num);

                    if (num == numSecret)
                    {
                        Console.WriteLine("Acertaste!!!!");
                        break;
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("HAS PERDIDO");
                    }
                    else
                    {

                        Console.WriteLine("Prueba otra vez, fallaste");
                    }
                }

                Console.WriteLine("Quieres seguir jugando? (Si/No)");
                string ans = Console.ReadLine();

                if (ans == "No")
                {
                    isPlaying = false;
                }
            }
        }
    }
}
