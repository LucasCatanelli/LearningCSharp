using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int centimetros = 0, resultadoCentrimetros = 0, resultadoMilimetros = 0;


            Console.WriteLine("Digite o valor em metros: ");
            centimetros = Convert.ToInt16(Console.ReadLine());
            resultadoCentrimetros = centimetros * 100;
            resultadoMilimetros = centimetros * 1000;

            Console.WriteLine("O valor digitado em metros convertido para centimetros e " + resultadoCentrimetros.ToString());
            Console.ReadKey();

            Console.WriteLine("O valor digitado em metros convertido para milimetros e " + resultadoMilimetros.ToString());
            Console.ReadKey();
        }
    }
}


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
