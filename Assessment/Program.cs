using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Program : Calculadora
    {
        static string patron = @"
            \A                            # start of the string anchor
            0*                            # ignored leading zeros
            (?:
                [1-9][0-9]{0,10}          # integer numbers
              |
                (?![0-9.]{12})            # 11 characters max for decimal numbers
                (?:
                    0\.[0-9]*[1-9][0-9]*  # decimal numbers < 1
                  |
                    [1-9][0-9]*\.[0-9]+   # decimal numbers >= 1
                )
            )
            \z                            # end of the string anchor
        ";

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
            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Multiplicacion");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Salir");
            Console.Write("\r\nIngresa una opcion: ");
            switch(Console.ReadLine())
            {
                case "1": Sumar(); return true;
                case "2": Resta(); return true;
                case "3": Multiplicacion(); return true;
                case "4": Division(); return true;
                default: return false;
            }
        }

        private static double CapturarEntrada()
        {
            try
            {
                Console.Write("Ingresa un numero: ");
                string texto = Console.ReadLine();
                Regex r = new Regex(patron, RegexOptions.IgnorePatternWhitespace);
                Match m = r.Match(texto);
                if (m.Success)
                {
                    return Convert.ToDouble(texto);
                }
                else
                {
                    throw new FormatException();
                }

            }
            catch(FormatException)
            {
                throw;
            }
        }
        private static void Sumar()
        {
            while(true)
            { 
                try
                {
                    Console.Clear();
                    Console.WriteLine("Suma");

                    double numero1 = CapturarEntrada();
                    double numero2 = CapturarEntrada();

                    double resultado = Calculadora.Suma(numero1, numero2);

                    ImprimirResultado(resultado.ToString());
                    break;
                }
                catch(Exception)
                {
                    continue;
                }
            }
        }

        private static void Resta()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Resta");

                    double numero1 = CapturarEntrada();
                    double numero2 = CapturarEntrada();

                    double resultado = Calculadora.Resta(numero1, numero2);

                    ImprimirResultado(resultado.ToString());
                    break;
                }
                catch (Exception)
                {

                    continue;
                }
            }
        }

        public static void Multiplicacion()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Multiplicacion");

                    double numero1 = CapturarEntrada();
                    double numero2 = CapturarEntrada();

                    double resultado = Calculadora.Multiplicacion(numero1, numero2);

                    ImprimirResultado(resultado.ToString());
                    break;
                }
                catch(Exception)
                {
                    continue;
                }
            }
        }

        public static void Division()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Division");
                    double numero1 = CapturarEntrada();
                    double numero2 = CapturarEntrada();
                    if(numero2 == 0)
                    {
                        continue;
                    }
                    double resultado = Calculadora.Division(numero1, numero2);

                    ImprimirResultado(resultado.ToString());
                    break;
                }
                catch (Exception)
                {

                    continue;
                }
            }
        }

        private static void ImprimirResultado(string resultado)
        {
            Console.WriteLine($"\r\nEl resultado de la operacion es: {resultado}");
            Console.Write("\r\nPresiona Enter para regresar al menu principal");
            Console.ReadLine();
        }
    }
}
