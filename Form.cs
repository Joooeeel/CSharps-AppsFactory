using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class Form
    {
        static void Main(string[] args)
        {
            bool isCorrect = true;

            while (isCorrect) { 
            Console.WriteLine("Introduzca su nombre");
            string name = Console.ReadLine();

                if(name == "")
                {
                    Console.WriteLine("Error, introduzca valor valido");
                }
                else{
                    Console.WriteLine("Los datos son correctos?    {"+name+"} (Si/No)");
                    string correct = Console.ReadLine();

                    if(correct == "Si")
                    {
                        isCorrect = false;
                    }
                }
            }
            Console.WriteLine("Continua con el examen");
        }
    }
}
