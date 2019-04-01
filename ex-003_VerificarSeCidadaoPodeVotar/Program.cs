using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_003_VerificarSeCidadaoPodeVotar
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto;
            int anoNascimento;
            int idade;

            Console.WriteLine("Informe o nome completo: ");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Informe o ano de nascimento: ");
            anoNascimento = Convert.ToInt32(Console.ReadLine());

            idade = 2019 - anoNascimento;

            Console.WriteLine("O cidadão possui " + idade + " anos.");

            if (idade >= 16)
            {
                Console.WriteLine("Pode votar.");
            }
            else
            {
                Console.WriteLine("NÃO pode votar.");
            }

            Console.ReadKey();
        }
    }
}
