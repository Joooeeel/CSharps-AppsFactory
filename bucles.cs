using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bucles
    {
        static void Main(string[] args)
        {
            /*for(int i = 0; i<=100; i += 2)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i<=100; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            Console.WriteLine("Entra un num: ");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            
            if(num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }else if(num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }else if(num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("--------------------TABLAS DE MULTIPLICAR------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------");

            for(int i = 1; i<=10; i++){
                for(int j = 0; j<=10; j++){
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
            }
        }
    }
}
