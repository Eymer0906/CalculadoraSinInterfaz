using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSinInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string suma = "suma";
            string resta= "resta";
            string multiplicacion = "multiplicacion";
            string division = "division";
            Console.WriteLine("Ingrese el tipo de operacion a realizar:");
            string operacion = (Console.ReadLine());
            if (operacion == suma)
            {
                Console.WriteLine("Ingrese el primer numero a sumar:");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("cual es el numero que le quieres sumar a.." + num1 + "por favor:");
                double num2 = double.Parse(Console.ReadLine());
                double resul = num1 + num2;
                Console.WriteLine("El resultado es :" + resul);
            }

            else if (operacion == resta) 
            {
                Console.WriteLine("Ingrese el primer numero a restar :");
                double rest1 =double.Parse(Console.ReadLine()); 
                Console.WriteLine("Ingrese el numero que quieres restarle a.. "+rest1+ "por favor :");
                double rest2 = double.Parse(Console.ReadLine());
                if (rest1 - rest2<0 )
                {
                    Console.WriteLine("el resultado sera un numero negativo");
                    double result = rest1 - rest2;
                    Console.WriteLine("el Resultado es :" + result);
                }
                else {
                    double result = rest1 - rest2;
                    Console.WriteLine("El Resultado es :" + result);
                }



            }
            else if (operacion == multiplicacion)
            {
                Console.WriteLine("Ingrese el primer número a multiplicar:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número por el que desea multiplicar " + num1 + ":");
                double num2 = double.Parse(Console.ReadLine());
                double resul = num1 * num2;
                Console.WriteLine("El resultado es: " + resul);
            }
            else if (operacion == division)
            {
                Console.WriteLine("Ingrese el dividendo:");
                double dividendo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor (asegúrese de que no sea cero):");
                double divisor = double.Parse(Console.ReadLine());

                if (divisor == 0)
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                else
                {
                    double resultado = dividendo / divisor;
                    Console.WriteLine("El resultado es: " + resultado);
                }
            }
            else
            {
                Console.WriteLine("Operación no válida. Por favor, ingrese 'suma', 'resta', 'multiplicación' o 'división'.");
            }






        }
    }
}
