using System;
using System.Globalization;
namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa PrimeiraPessoa, SegundaPessoa;
            PrimeiraPessoa = new Pessoa();
            SegundaPessoa = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa:");
            Console.Write("Nome: ");
            PrimeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            PrimeiraPessoa.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Dados da Segunda Pessoa");
            Console.Write("Nome: ");
            SegundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            SegundaPessoa.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (PrimeiraPessoa.Idade > SegundaPessoa.Idade)
            {
                Console.WriteLine("Pessoa mais Velha: " + PrimeiraPessoa.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais Velha: " + SegundaPessoa.Nome);
            }
        }
    }
}
