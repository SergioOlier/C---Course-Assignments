using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            int lados;
            double longitud, perimetro;
            double centigrados, fahrenheit;



            while (opcion != 0) 
            
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. ¿Desea calcular el perimetro de un poligono regular?");
                Console.WriteLine("2. ¿Desea transformar grados Centigrados a grados Fahrenheit?");
                Console.WriteLine("3. ¿Desea transformar grados Fahrenheit a grados Centigrados?");
                Console.WriteLine("0. Salir");
                Console.Write("Elija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("\nDigite la longitud de uno de los lados del poligono: ");
                        longitud = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite el numero de lados del poligono: ");
                        lados = Convert.ToInt32(Console.ReadLine());

                        perimetro = longitud * lados;

                        Console.WriteLine("El perimetro del poligono es de: {0}", perimetro);
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.Write("\nDigite los grados Centigrados a transformar: ");
                        centigrados = Convert.ToDouble(Console.ReadLine());

                        fahrenheit = (centigrados * 1.8) + 32;

                        Console.WriteLine("{0} grados Centigragos es igual a: {1} grados Fahrenheit", centigrados, fahrenheit);
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.Write("\nDigite los grados Fahrenheit a transformar: ");
                        fahrenheit = Convert.ToDouble(Console.ReadLine());

                        centigrados = (fahrenheit - 32) / 1.8;

                        Console.WriteLine("{1} grados Fahrenheit es igual a: {0} grados Centigrados", centigrados, fahrenheit);
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("\nPor favor ingrese una opción valida\n");
                        break;
                }
            }
        }
    }
}
