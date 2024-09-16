using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTarea3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;
            Console.Write("Digite el numero del mes que deseas saber: ");
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
        }
    }
}
