using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Herencia
{
    class MainClass
    {
        public static void Main(string[] args){
            new Cliente().PersonIncrease();
            new Cliente().PersonIncrease();
            new Empleado().PersonIncrease();
            new Empleado().PersonIncrease();

            
            Console.WriteLine(Empleado.numInstancias);
        }
    }
}
