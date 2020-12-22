using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{

    class ArraysTest
    {
        public static string[] nombres = { "Pere", "Marc", "Augustu", "Prudencio", "Amancio" };
        static int[] myList = { 1, 9, 3, 8, 5, 7 };
        static string[] months = {"Gener", "Febrer", "Març", "Abril", "Maig", "Juny", "Juliol", "Agost", "Septembre",
        "Octubre", "Novembre", "Desembre"};
        public static void Main(string[] args){

            for(int i = 0; i < nombres.Length; i++){
                Console.WriteLine("Conozco a alguien llamado " + nombres[i]);
            }

            for(int i = 0; i<myList.Length; i++){
                Console.WriteLine(myList[i] * 2);
            }

            Console.WriteLine("Entra un numero de mes");
            int mon;
            int.TryParse(Console.ReadLine(), out mon);

            Console.WriteLine(months[mon - 1]);

        }
    }
}
