using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            var valorN = "";

            Console.WriteLine("Digite un numero por favor:");
            number1 = Convert.ToInt16(Console.ReadLine());

            switch (number1) {

                case 0:
                    valorN = "cero";
                    break;
                case 1:
                    valorN = "uno"; 
                    break;
                case 2:
                    valorN = "dos";
                    break;
                case 3:
                    valorN = "tres";
                    break;
                case 4:
                    valorN = "cuatro";
                    break;
                case 5:
                    valorN = "cinco";
                    break;
                case 6:
                    valorN = "seis";
                    break;
                case 7:
                    valorN = "siete";
                    break;
                case 8:
                    valorN = "ocho";
                    break;
                case 9:
                    valorN = "nueve";
                    break;
                default:
                    Console.WriteLine("Numero fuera de rango.");
                    break;


            }

            if (number1 <= 9 && number1 >= 0) {
                Console.WriteLine("El numero digitado es {0}", valorN);
            }
            
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();


        }
    }
}
