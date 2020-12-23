using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Herencia
{
    class Persona
    {
        public static int numInstancias = 0;

        public void PersonIncrease()
        {
            numInstancias++;
            
        }
    }
}
