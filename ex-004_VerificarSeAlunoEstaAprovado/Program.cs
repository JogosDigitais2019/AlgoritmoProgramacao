using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_004_VerificarSeAlunoEstaAprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nota01, nota02, media, mediaAprovacao = 6;

            Console.WriteLine("Informe a nota 01: ");
            nota01 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a nota 02: ");
            nota02 = Convert.ToDecimal(Console.ReadLine());

            media = (nota01 + nota02) / 2;

            Console.WriteLine("A média do aluno é " + media);

            if(media >= mediaAprovacao)
            {
                Console.WriteLine("O aluno está APROVADO.");
            }
            else
            {
                Console.WriteLine("O aluno está RETIDO.");
            }

            Console.ReadKey();
        }
    }
}
