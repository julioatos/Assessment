using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    internal class Program
    {
        static string[] arreglo =

        {
                "Juan",
                "Pablo",
                "Pedro",
                "Pepe",
                "Ana",
                "Esteban",
                "Daniel",
                "Mariano",
                "Carolina",
                "Silvia",
                "Roberto",
                "Juanito",
                "Juana"

        };
        static void Main(string[] args)
        {
            bool mostrarMenu = true;
            while (mostrarMenu)
            {
                mostrarMenu = MenuPrincipal();
            }
        }

        private static bool MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Menu ");
            Console.WriteLine("1) Retornar arreglo en orden descendiente");
            Console.WriteLine("2) Buscar string en el arreglo");
            Console.WriteLine("3) Retornar arreglo con elementos que inician con 'Juan'");
            Console.WriteLine("4) Concatenar elementos del arreglo con 'hola'");
            Console.WriteLine("5) Salir");
            Console.Write("\r\nIngresa una opcion: ");
            switch (Console.ReadLine())
            {
                case "1": RetornarArrayOrdenDescendiente(); return true;
                case "2": BuscarStringEnArray(); return true;
                case "3": RetornarArrayCondicional(); return true;
                case "4": ConcatenarElementosArreglo(); return true;
                default: return false;
            }
        }

        private static void RetornarArrayOrdenDescendiente()
        {
            Console.WriteLine("Arreglo antes de ser ordenado:\n");
            foreach (string value in arreglo)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
            string[] arreglo2 = arreglo.OrderByDescending(c => c).ToArray();

            Console.WriteLine("Arreglo despues de ser ordenado (desc):\n");
            foreach (string value in arreglo2)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("");
            Console.Write("\r\nPresiona Enter para regresar al menu principal");
            Console.ReadLine();
        }

        private static string CapturarEntrada()
        {
            Console.Write("Teclea el texto que buscas en el arreglo: ");
            return Console.ReadLine();
        }
        private static void BuscarStringEnArray()
        {
            string elemento = CapturarEntrada();
            bool res = arreglo.AsQueryable().Contains(elemento);
            Console.WriteLine($"Existe el elemento '{elemento}?' en el arreglo " + res);
            Console.WriteLine("");
            Console.Write("\r\nPresiona Enter para regresar al menu principal");
            Console.ReadLine();

        }

        private static void RetornarArrayCondicional()
        {
            Console.WriteLine("Elementos del array que empiezan con 'Juan':\n");
            string[] arreglo2 = arreglo.Where(x => x.StartsWith("Juan")).ToArray();
            foreach (string value in arreglo2)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("");
            Console.Write("\r\nPresiona Enter para regresar al menu principal");
            Console.ReadLine();

        }

        private static void ConcatenarElementosArreglo()
        {
            Console.WriteLine("Elementos del array concatenados con la palabra 'Hola' al inicio:\n");
            string[] arreglo2 = arreglo.Select(x => string.Concat("Hola ", x)).ToArray();
            foreach (string value in arreglo2)
            {
                Console.Write(value + "\n");
            }

            Console.WriteLine("");
            Console.Write("\r\nPresiona Enter para regresar al menu principal");
            Console.ReadLine();

        }
    }
}
