using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nota01, nota02, media;

            Console.WriteLine("Informe a nota 01: ");
            nota01 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota 02: ");
            nota02 = Convert.ToDecimal(Console.ReadLine());

            media = (nota01 + nota02) / 2;

            Console.WriteLine("A média do aluno é " + media);

            Console.ReadKey();
        }
    }
}
