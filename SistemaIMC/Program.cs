using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Wenderson", 18, 70.5, 1.75);

            //pessoa.NomePessoa();
            //pessoa.IdadePessoa();
            //pessoa.PesoPessoa();
            //pessoa.AlturaPessoa();

            Pessoa.CalcularIMC(71, 1.75);
            Console.WriteLine(Pessoa.FaixaDeCategoria(23));
            Console.ReadKey();  
        }
    }
}
