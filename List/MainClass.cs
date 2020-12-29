using System;
using System.Collections.Generic;
using System.Text;

namespace FonamentsCSharp.List
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Student> alum = new List<Student>();

            bool isActive = true;
            
            while (isActive)
            {
                Console.WriteLine("Escoja la opcion de que quiere hacer: ");
                Console.WriteLine("1. Alta");
                Console.WriteLine("2. Baja");
                Console.WriteLine("3. Modificacion");
                Console.WriteLine("4. Consulta todos los alumnos");
                Console.WriteLine("5. Salir");

                int op;
                int.TryParse(Console.ReadLine(), out op);

                switch (op){
                    case 1:                   
                        alum.Add(Alta());

                        break;
                    case 2:
                        Remove(alum);

                        break;
                    case 3:
                        Mod(alum);

                        break;
                    case 4:
                        foreach (var x in alum){
                            Console.WriteLine("");
                            Console.WriteLine("Nombre: " + x.name);
                            Console.WriteLine("Edad: " + x.age);
                            Console.WriteLine("E-mail: " + x.mail);
                            Console.WriteLine("");
                        }

                        break;
                    case 5:
                        isActive = false;
                        break;
                    default:
                        Console.WriteLine("Introduzca un valor valido");
                        Console.WriteLine("");
                        break;
                }
            }
        }

        static Student Alta(){

            string nombre = getName();
            
            int edad = getAge();

            string mail = getMail();
           
            Student newStudent = new Student();
            newStudent.name = nombre;
            newStudent.age = edad;
            newStudent.mail = mail;

            return newStudent;
        }

        static void Remove(List<Student> student){

            string nameRemove = getName();

            for (int i = 0; i < student.Count; i++)
            {
                if (nameRemove == student[i].name)
                {
                    student.RemoveAt(i);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Eliminado con exito");
            Console.WriteLine("");
        }

        static void Mod(List<Student> student){
            
            string name = getName();
          
            string name2 = getName();
            
            int age = getAge();

            string mail = getMail();
            

            for (int i = 0; i < student.Count; i++)
            {
                if (name == student[i].name)
                {
                    student[i].name = name2;
                    student[i].age = age;
                    student[i].mail = mail;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Modificado con exito");
            Console.WriteLine("");
        }

        static string getName(){
            Console.WriteLine("Entra el nombre: ");
            string name = Console.ReadLine();
            
            return name;
        }
        static string getMail()
        {
            Console.WriteLine("Entra el mail: ");
            string mail = Console.ReadLine();

            return mail;
        }


        static int getAge()
        {
            Console.WriteLine("Entra la edad: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            return age;
        }

    }
}
