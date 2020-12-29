using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.List
{
    class Student
    {
        string _name;
        int _age;
        string _mail;

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

        public string mail
        {
            get
            {
                return _mail;
            }
            set
            {
                _mail = value;
            }
        }
    }
}
