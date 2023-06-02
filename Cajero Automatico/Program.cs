using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    internal class Program
    {
        /*
         
        Escriba un programa para mostrar al usuario las funciones de un cajero automatico:

        S- Consultar Saldo Actual
        R- Retirar Dinero (validar saldo disponible)
        I- Ingresar Dinero 
        Q- Terminar

        Segun la opcion de menu seleccionada por el usuario debe implementar la funcionalidad correspondiente. 
        El saldo inicial se debe inicializar en 85.000$, controlar que las operacion no genere saldo "negativo" y solamente al presionar la letra "Q" se debe terminar el programa,
        caso contrario permitir realizar varias operaciones en cadena.
          
         */
        static void Main(string[] args)
        {
            double saldo = 85000.0;

            while (true)
            {
               
                Console.WriteLine("============ CAJERO AUTOMATICO ============\n");
                Console.WriteLine("S - Consultar Saldo Actual");
                Console.WriteLine("R - Retirar Saldo");
                Console.WriteLine("I - Ingresar Dinero");
                Console.WriteLine("Q - Terminar\n");
                Console.WriteLine("===========================================\n");
                Console.Write("Eliga una opcion: ");

                string opcion = Console.ReadLine().ToUpper();//El metodo To.Upper() se utiliza para convertir una cadena de textos a mayuscula. Es decir, no hay problema si la letra presiona esta en minuscula.

                Console.Clear();

                switch (opcion)
                {
                   
                    case "S":
                        Console.Clear();
                        Console.WriteLine("Su saldo actual es: $" + saldo);
                        break;

                    case "R":
                        Console.Write("Ingrese el monto a retirar: $");
                        double montoRetiro = double.Parse(Console.ReadLine());

                        if (montoRetiro > saldo)
                        {
                            Console.WriteLine("Saldo insuficiente para realizar el retiro");
                        }
                        else
                        {
                            saldo -= montoRetiro;
                            Console.WriteLine("Retiro exitoso");
                        }
                        break;

                    case "I":
                        Console.Write("Ingrese el monto a ingresar: $");
                        double montoIngreso = double.Parse(Console.ReadLine());

                        saldo += montoIngreso;
                        Console.WriteLine("Ingreso exitoso");
                        break;

                    case "Q":
                        Console.WriteLine("Gracias por utilizar nuestros servicios.");
                        return;

                    default:
                        Console.WriteLine("Opción inválida, por favor intente nuevamente");
                        break;
                }
            }
        }
    }
}
