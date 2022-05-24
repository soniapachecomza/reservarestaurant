using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1. Validar si es usuario existente o si se debe registrar, y generar un sistema de registro o login
 * 2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto existe
 * 3. El prgrama debe repetirse hasta que se registren las 10 personas
 * */
namespace reservaenrestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] { "Pedro", "Susana", "Erica", "Juan", "Mariano", "Gastón", "Roberto", "Lucas", "Daniel", "" };
            int arrayCurrentIndex = 9;
            bool userType;

            Console.WriteLine("Bienvenidos al mejor restaurant del Mundo");
            while(arrayCurrentIndex < 10)
            {
                /*if(arrayCurrentIndex == 10)
                {
                    Console.WriteLine("El restaraunt esta lleno, vuelva el proximo mes ");
                    Environment.Exit(0);
                }*/
                Console.WriteLine("\n \n ¿Esta usted esta registrado? Estaba registrado verdadero o falso");
                userType = Convert.ToBoolean(Console.ReadLine());
                if(userType == true)
                {
                    Console.WriteLine("Hola, usted es un usuario registrado, por favor ingrese su nombre");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("El usuario buscado es {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("Usuario no encontrado, prueba de nuevo o registrelo");
                    }
                    else
                    {
                        Console.WriteLine("Bienvenido {0}, es un placer servirlos", userNames[index]);
                    }
                }
                else if(userType == false)
                {
                    Console.WriteLine("Por favor, escriba y guarde su nombre de usuario");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Su nombre de usuario a sido guardado\n" + "Su nombre de usuario es> {0}",
                        userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;

                }
            }
            Console.WriteLine("El restaraunt esta lleno, vuelva el proximo año \n Estos son los invitados a la cena");
            int auxIndex = 0;
            foreach (string element in userNames)
            {
                Console.WriteLine("Numero de usuario: {0} y nombre de usuario: {1}", auxIndex, userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}
