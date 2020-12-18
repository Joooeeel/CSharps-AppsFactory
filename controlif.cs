using System;


namespace ConsoleApp1
{
    class controlif
    {
        public void withif(int i, int j, string c, int w){
            if (c == "+")
            {
                w = i + j;
            }
            else if (c == "-")
            {
                w = i - j;
            }
            else if (c == "*")
            {
                w = i * j;
            }
            else
            {
                w = i / j;
            }

            Console.WriteLine("Resultado con if: " + w);
        }

        public void withSwitch(int i, int j, string c, int w) {

            switch (c) {

                case "+":
                    w = i + j;
                    break;
                case "-":
                    w = i - j;
                    break;
                case "*":
                    w = i * j;
                    break;
                case "/":
                    w = i / j;
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }

            Console.WriteLine("Resultado con switch: " + w);
        }


        static void Main(string[] args)
        {
            controlif control;
            control = new controlif();

            Console.WriteLine("Entre el n1: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Entre el n2: ");
            string n2 = Console.ReadLine();
            Console.WriteLine("Entre el operador (+, -, *, /): ");
            string op = Console.ReadLine();

            int n1Converted = 0;
            int.TryParse(n1.Trim(), out n1Converted);
            int n2Converted = 0;
            int.TryParse(n2.Trim(), out n2Converted);

            int res = 0;

            control.withif(n1Converted, n2Converted, op, res);
            control.withSwitch(n1Converted, n2Converted, op, res);
        }
    }
}
