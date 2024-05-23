using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1555
{
    class Produto
    {
        public char NomeProduto { get; set; }
        public int ID_Produto { get; set; }

        public void Visualizar()
        {
            Console.WriteLine($"Produto ID: {ID_Produto}, Nome: {NomeProduto}");
        }

        public void Cadastrar()
        {
            Console.WriteLine($"Cadastrando produto {NomeProduto}");
        }
    }
}
