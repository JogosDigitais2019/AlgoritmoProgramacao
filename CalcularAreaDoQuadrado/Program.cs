using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreaDoQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex - 001 - Calculo da Área do Quadrado

            decimal baseQ, altura, area;

            Console.WriteLine("Informe o valor da base: ");
            baseQ = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o valor da altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            area = baseQ * altura;

            Console.WriteLine("A área do quadrado é: " + area);

            Console.ReadKey();

        }
    }
}
