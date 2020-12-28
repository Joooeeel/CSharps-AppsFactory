using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.List
{
    class Student
    {
        string _name;
        int _age;

        public string name{
            get{ return _name;
            }set{
                _name = value;
            }
        }

        public int age{
            get{ return _age;
            }set{
                _age = value;
            }
        }
    }
}
