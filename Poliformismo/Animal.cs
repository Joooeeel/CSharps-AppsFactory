using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Poliformismo
{
    abstract class Animal
    {
        protected string sonido;

        public Animal(string sonido){
            this.sonido = sonido;
        }

        public abstract void comunicarse();

        
    }
}
