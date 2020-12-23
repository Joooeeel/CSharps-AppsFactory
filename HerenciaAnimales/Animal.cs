using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.HerenciaAnimales
{
    class Animal
    {
        public static string sonidoMasLargo = "";
        string sound;

        public Animal(string sound)
        {
            this.sound = sound;
            compararSonido();
        }

        private void compararSonido()
        {
            if (sonidoMasLargo.Length < sound.Length) sonidoMasLargo = sound;
        }
    }
}
