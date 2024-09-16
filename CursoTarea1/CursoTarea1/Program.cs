using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            double num1, num2, resultado;

            while (opcion != 0)
            {
                Console.WriteLine("Calculadora de 2 digitos");
                Console.WriteLine("1. suma");
                Console.WriteLine("2. resta");
                Console.WriteLine("3. multiplicacion");
                Console.WriteLine("4. division");
                Console.WriteLine("0. salir");
                Console.Write("Elija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("\nDigite el primer numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nDigite el segundo numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        resultado = num1 + num2;

                        Console.WriteLine("{0} + {1} = {2}\n", num1, num2, resultado);
                        break;
                    case 2:
                        Console.Write("\nDigite el primer numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nDigite el segundo numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        resultado = num1 - num2;

                        Console.WriteLine("{0} - {1} = {2}\n", num1, num2, resultado);
                        break;
                    case 3:
                        Console.Write("\nDigite el primer numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nDigite el segundo numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        resultado = num1 * num2;

                        Console.WriteLine("{0} * {1} = {2}\n", num1, num2, resultado);
                        break;
                    case 4:
                        Console.Write("\nDigite el primer numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nDigite el segundo numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;

                            Console.WriteLine("{0} / {1} = {2}\n", num1, num2, resultado);
                        }
                        else
                        {
                            Console.WriteLine("¡Error! No se puede dividir entre 0\n");
                        }
                        resultado = num1 + num2;
                        break;
                    default:
                        Console.WriteLine("\nPor favor ingrese una opción valida\n");
                        break;
                }
            }
        }
    }
}
