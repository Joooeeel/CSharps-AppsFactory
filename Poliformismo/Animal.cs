using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.Poliformismo
{
    abstract class Animal:IAnimal
    {
        protected string sonido;

        public Animal(string sonido){
            this.sonido = sonido;
        }

        public abstract void Comunicarse();

        
    }
}
