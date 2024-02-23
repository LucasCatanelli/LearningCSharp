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
            Console.WriteLine("Digite o valor em metros: ");
            int centimetros = Convert.ToInt16(Console.ReadLine());
            int resultadoCentrimetros = centimetros * 100;
            int resultadoMilimetros = centimetros * 1000;

            Console.WriteLine("O valor digitado em metros convertido para centimetros e " + resultadoCentrimetros.ToString());
            Console.ReadKey();

            Console.WriteLine("O valor digitado em metros convertido para milimetros e " + resultadoMilimetros.ToString());
            Console.ReadKey();
        }
    }
}
