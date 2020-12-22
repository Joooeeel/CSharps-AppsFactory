using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class Metodos
    {
        float PI = 3.14f;

        public int cube(int num)
        {
            return num * num * num;
        }

        public int m(int vel)
        {
            return vel * 1000;
        }

        public int perimetro(int ancho, int altura){
            return (2 * ancho) + (2 * altura);
        }

        public int area(int ancho, int altura){
            return ancho * altura;
        }

        float circumferenciaPerímetro(int radius)
        {
            return 2 * PI * radius;
        }

        float circumferenciaArea (int radius)
        {
            return PI * (radius*radius);
        }

        double suma(int x, int y){
            return x + y;
        }

        double resta(int x, int y)
        {
            return x - y;
        }
        double mult(int x, int y)
        {
            return x * y;
        }
        double div(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args){
            //Declaración del mètodo
            Metodos met = new Metodos();
            /*
            //Calcular el cubo
            Console.WriteLine("Entra un numero para calcular su cubo");
            int cub = 0;
            int.TryParse(Console.ReadLine(), out cub);

            int res;

            res = met.cube(cub);

            Console.WriteLine(res);

            //Km/h a m/s
            Console.WriteLine("Entra una velocidad en km/h para pasarlo a m/h");
            int velocity = 0;
            int.TryParse(Console.ReadLine(), out velocity);

            res = met.m(velocity);

            Console.WriteLine(res);

            //Perímetro y area del rectangulo
            int x, y;
            Console.WriteLine("Entra el ancho del rectangulo");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Entra el alto del rectangulo");
            int.TryParse(Console.ReadLine(), out y);

            res = met.perimetro(x, y);

            Console.WriteLine(res);

            res = met.area(x, y);

            Console.WriteLine(res);

            //Perimetre i àrea d'una circumferencia
            int radius;
            Console.WriteLine("Entra el radio de circumferencia");
            int.TryParse(Console.ReadLine(), out radius);

            float res2;

            res2 = met.circumferenciaPerímetro(radius);
            Console.WriteLine("Perímetro de la circumferència: " + res2);
            res2 = met.circumferenciaArea(radius);
            Console.WriteLine("Area de la circumferència: " + res2);
            */

            //6 - Calculadora
            int i, j;
            Console.WriteLine("Entra el primer numéro a operar");
            int.TryParse(Console.ReadLine(), out i);
            Console.WriteLine("Entra el segundo numero a operar");
            int.TryParse(Console.ReadLine(), out j);
            Console.WriteLine("Entra el operador (+, -, *, /)");
            string operando = Console.ReadLine();

            double resultado = 0;

            switch (operando){
                case "+":
                    resultado = met.suma(i, j);
                    break;
                case "-":
                    resultado = met.resta(i, j);
                    break;
                case "*":
                    resultado = met.mult(i, j);
                    break;
                case "/":
                    resultado = met.div(i, j);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Resultado: " + resultado);

        }
    }
}
