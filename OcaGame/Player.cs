using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.OcaGame
{
    class Player
    {
        string _nombre;
        int _casilla;
        int _turnosRestantes;
        bool _isActive;

        public string nombre{
            get{ return _nombre;
            }set{
                _nombre = value;
            }
        }
        public int casilla{
            get{
                return _casilla;
            } set{
                _casilla = value;
            }
        }

        public int turnosRestantes{
            get{
                return _turnosRestantes;
            }set{
                _turnosRestantes = value;
            }
        }

        public bool isActive{
            get{
                return _isActive;
            }set{
                _isActive = value;
            }
        }
    }
}
