using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClassCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausFahrenheit = 0, grausCelcius = 0;

            Console.WriteLine("Digite o valor em graus Fahrenheit: ");
            grausFahrenheit = Convert.ToInt16(Console.ReadLine());
            grausCelcius = (grausFahrenheit - 32.0) * (5.0 / 9.0);

            Console.WriteLine("O valor digitado em graus Celsius e de " + grausCelcius.ToString(".0"));
            Console.ReadKey();


        }
    }
}
