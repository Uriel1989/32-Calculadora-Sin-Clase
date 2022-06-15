using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora");

            Console.WriteLine("Introduce el primer valor para la operacion deseada: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el segundo valor para la operacion deseada: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ahora ingrese la letra correspondiente a la operacion deseada: " + Environment.NewLine + "S.suma"
                + Environment.NewLine + "R.resta" + Environment.NewLine + "M.multiplicacion" + Environment.NewLine + "D.division");
            char letra = Convert.ToChar(Console.ReadLine());

            double resultado;

            switch (letra) /*En este caso es mas conveniente utilizar el SWITCH/CASE en lugar del IF/ELSE,
                             aunque en apariencia parecen cumplir la misma funcion, el primero resulta mas conveniente
                             ya que habilita una redaccion mas sencilla en contraposicion con el segundo*/
            {
                case 's':
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado es:" +  resultado);
                        break;
                case 'r':
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado es:" + resultado);
                    break;
                case 'm':
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado es:" + resultado);
                    break;
                case 'd':
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado es:" + resultado);
                    break;

                default:
                    Console.WriteLine("Valor introducido incorrecto, por favor re-ingrese datos");
                    break;


            }
            Console.ReadKey();
        }
    }
}
