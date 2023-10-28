using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tristan_Ejercicio_1_A
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola, bienvenido al estacionamiento Raúl Tristan\n");
            Console.Write("Ejemplo: lunes, martes, miércoles, jueves, viernes, sábado, domingo\n");
            Console.Write("Ingrese el día: ");
            String diaSemana = Console.ReadLine().ToLower();

            Console.Write("\nEjemplo formato 24h: 10-> 10:00, 14->14:00\n");
            Console.Write("Ingrese hora entrada: ");
            int horaEntrada = int.Parse(Console.ReadLine());

            Console.Write("\nEjemplo formato 24h: 10-> 10:00, 14->14:00\n");
            Console.Write("Ingrese hora salida: ");
            int horaSalida = int.Parse(Console.ReadLine());

            if (horaSalida < horaEntrada)
            {
                Console.WriteLine("La Hora de salida tiene que ser mayor a la hora de entrada.");
                Console.ReadKey();
            }
            else
            {
                int horaTotal = (horaSalida - horaEntrada);
                double totalPagar = 0;

                switch (diaSemana)
                {
                    case "lunes":
                    case "martes":
                    case "miércoles":
                    case "jueves":
                    case "viernes":

                        if (horaTotal <= 1)
                        {
                            totalPagar = 6.00;
                        }
                        else
                        {
                            totalPagar = (((horaTotal - 1) * 4.00) + 6.00);
                        }
                        break;

                    case "sábado":
                    case "domingo":

                        totalPagar = horaTotal * 7.00;
                        break;

                    default:
                        Console.WriteLine("Día no valido");
                        Console.ReadKey();
                        return;
                }

                Console.Write("\n\nTotal estacionado: "+ horaTotal + " horas.");
                Console.Write("\nTotal a pagar: S/ " + totalPagar + ".00");

                Console.ReadKey();
            }

        }
    }
}
