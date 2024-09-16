using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTarea3
{
    internal class Program
    {
        static double CalcularPrecio(int minutos)
        {
            if (minutos <= 60)
            {
                return 5.00;
            }
            else if (minutos <= 120)
            {
                return 15.00;
            }
            else
            {
                return 40.00;
            }
        }

        static void Main(string[] args)
        {

            int opcion = -1;
            int mes;

            while (opcion != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Saber mes por numero digitado");
                Console.WriteLine("2. Saber numero si es par o impar");
                Console.WriteLine("3. Saber cuanto debes pagar en el estacionamiento");
                Console.WriteLine("0. Salir");
                Console.Write("\nEscoja un opcion porfavor: ");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    /*
                     * Hacer un programa que le pida al usuario un número del 1 al 12 y escriba el nombre 
                     * del mes que corresponde ese número en el calendario. Agregar un case default.
                    */
                    case 1:

                        Console.Write("\nDigite el numero del mes que deseas saber: ");
                        mes = Convert.ToInt32(Console.ReadLine());

                        switch (mes)
                        {
                            case 1:
                                Console.WriteLine("{0} = Enero\n", mes);
                                break;
                            case 2:
                                Console.WriteLine("{0} = Febrero\n", mes);
                                break;
                            case 3:
                                Console.WriteLine("{0} = Marzo\n", mes);
                                break;
                            case 4:
                                Console.WriteLine("{0} = Abril\n", mes);
                                break;
                            case 5:
                                Console.WriteLine("{0} = Mayo\n", mes);
                                break;
                            case 6:
                                Console.WriteLine("{0} = Junio\n", mes);
                                break;
                            case 7:
                                Console.WriteLine("{0} = Julio\n", mes);
                                break;
                            case 8:
                                Console.WriteLine("{0} = Agosto\n", mes);
                                break;
                            case 9:
                                Console.WriteLine("{0} = Septiembre\n", mes);
                                break;
                            case 10:
                                Console.WriteLine("{0} = Octubre\n", mes);
                                break;
                            case 11:
                                Console.WriteLine("{0} = Noviembre\n", mes);
                                break;
                            case 12:
                                Console.WriteLine("{0} = Diciembre\n", mes);
                                break;
                            default:
                                Console.WriteLine("\nPor favor ingrese una opción valida\n");
                                break;
                        }
                        break;
                    /*
                     * Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.
                    */
                    case 2:
                        float num;
                        Console.Write("\nDigite un numero: ");
                        num = Convert.ToSingle(Console.ReadLine());

                        if (num % 2 == 0)
                        {
                            Console.WriteLine("{0} es par", num);
                        }
                        else
                        {
                            Console.WriteLine("{0} es impar", num);
                        }
                        break;

                    /*
                     *Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento 
                     *de un centro comercial con base en el tiempo que ha permanecido ahí, los primeros 60 minutos: $5.00, 
                     *las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00
                    */
                    case 3:
                        Console.Write("\nIngrese el tiempo de permanencia en minutos: ");
                        int minutos = int.Parse(Console.ReadLine());

                        // Calcular el precio a pagar
                        double precio = CalcularPrecio(minutos);

                        // Mostrar el resultado
                        Console.WriteLine($"El precio a pagar es: ${precio}\n");
                        break;
                    default:
                        Console.WriteLine("\nElige una opcion valida porfavor\n");
                        break;
                }
            }
        }
    }
}
