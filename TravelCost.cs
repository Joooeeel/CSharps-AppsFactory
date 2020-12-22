using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp
{
    class TravelCost
    {
        int HotelPrice(int n)
        {
            int nightPrice = 140;

            return nightPrice * n;
        }
        int AirPlanePrice(string city){

            switch (city)
            {
                case "Oviedo":
                    return 15;
                case "Tokyo":
                    return 700;
                case "Madrid":
                    return 90;
                case "Barcelona":
                    return 90;
                default:
                    return 0;
            }    
        }

        int RentCatPrice(int n)
        {
           int dayPrice = 40;

           if(n >= 7)
           {
                return (n * dayPrice) - 50;
           }else if(n >= 3){
                return (n * dayPrice) - 20;
            }
            else{
                return n * dayPrice;
            }
        }
        
        static void Main(string[] args){
            TravelCost travelCost = new TravelCost();
            int nights = 0;
            Console.WriteLine("Introduzca el número de noches");
            int.TryParse(Console.ReadLine(), out nights);
            Console.WriteLine("Introduzca el nombre del destino (Oviedo, Tokyo, Madrid, Barcelona");
            string target = Console.ReadLine();

            int r1 = travelCost.HotelPrice(nights);
            Console.WriteLine("Coste hotel: " + r1);
            int r2 = travelCost.AirPlanePrice(target);
            Console.WriteLine("Coste avion: " + r2);
            int r3 = travelCost.RentCatPrice(nights);
            Console.WriteLine("Coste coche: " + r3);

            int totalPrice = r1 + r2 + r3;
            Console.WriteLine("Resultado: " + totalPrice);
        }
    }
}

