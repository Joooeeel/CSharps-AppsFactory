using System;


namespace ConsoleApp1
{
    class Program
    {
        public int secondsDay(){
            int h = 24;
            int m = 60;
            int s = 60;

            int seconds = (m * s) * h;

            return seconds;
        }

        public int eurToDollar(){
            Console.WriteLine("Entra los euros que quieres cambiar");
            string euros = Console.ReadLine();
            int convertedEuros = 0;
            int.TryParse(euros.Trim(), out convertedEuros);
            //int dollar = convertedEuros * 2;

            return convertedEuros * 2;
        }

        public float IVACalcul() {

            Console.WriteLine("Entre el precio: ");
            string price = Console.ReadLine();
            float convertedPrice = 0;
            float.TryParse(price.Trim(), out convertedPrice);

            return convertedPrice * 1.21f;
        }

        public string dobTrip() {

            Console.WriteLine("Entra un numero;");
            string number = Console.ReadLine();
            int numConv = 0;
            int.TryParse(number.Trim(), out numConv);
            int d = numConv * 2;
            int t = numConv * 3;

            string total = "Doble: " + d + " ---- Triple: " + t;

            return total;
        }

        public float farConvert()
        {
            Console.WriteLine("Entra temperatura en grados centígrados");
            string temp = Console.ReadLine();
            float tempConv = 0;
            float.TryParse(temp.Trim(), out tempConv);

            return (tempConv * 9) / 5 + 32;
        }

        public int rectPer(int x, int y) {

            return (2 * x) + (2 * y);
        }

        public int rectBase(int x, int y)
        {

            return x*y;
        }

        public string cajaData() {

            Console.WriteLine("Entra el nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Entra el material: ");
            string material = Console.ReadLine();
            Console.WriteLine("Dimensiones de la caja (base*altura)");
            string dimensions = Console.ReadLine();
            Console.WriteLine("Entra un comentario si quieres...");
            string com = Console.ReadLine();

            return name + " ha pedido una caja de " + material + " con unas dimensiones " + dimensions + ". " + com;
        }

        static void Main(string[] args)
        {
            Program prog;
            prog = new Program();

            //Seconds per day
            int totalSeconds = prog.secondsDay();
            Console.WriteLine(totalSeconds);

            //Dollar To euros
            int dollar = prog.eurToDollar();
            Console.WriteLine("Total dollares: " + dollar);

            //Calcular precio con IVA
            float priceIVA = prog.IVACalcul();
            Console.WriteLine("Total dollares: " + priceIVA);

            //Doble i Triple
            string final = prog.dobTrip();
            Console.WriteLine(final);
            
            //Ancho y alto
            
            Console.WriteLine("Entra la base: ");
            string b = Console.ReadLine();
            Console.WriteLine("Entra el alto: ");
            string a = Console.ReadLine();

            int baseConverted = 0;
            int heightConverted = 0;

            int.TryParse(b.Trim(), out baseConverted);
            int.TryParse(a.Trim(), out heightConverted);

            int per = prog.rectPer(baseConverted, heightConverted);
            int area = prog.rectBase(baseConverted, heightConverted);

            Console.WriteLine("Perímetro: " + per);
            Console.WriteLine("Área: " + area);

            //Temperatura convert
            float far = prog.farConvert();
            Console.WriteLine("Temperatura en farenheit: " + far);
          
            //Cajas
            string cajaString = prog.cajaData();
            Console.WriteLine(cajaString);
        }  
    }
}
