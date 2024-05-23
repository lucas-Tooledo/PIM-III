using ConsoleApp1555;
using ConsoleApp2;
using System;
using System.Collections.Generic;

namespace CRUDApplication
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static List<Funcionario> funcionarios = new List<Funcionario>();
        static List<Fornecedor> fornecedores = new List<Fornecedor>();
        static List<Gerente> gerentes = new List<Gerente>();
        static List<Produto> produtos = new List<Produto>();
        static List<Producao> producao = new List<Producao>();
        static List<Tarefa> tarefas = new List<Tarefa>();

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("\nMENU PRINCIPAL:");
                Console.WriteLine("1. Cliente");
                Console.WriteLine("2. Funcionário");
                Console.WriteLine("3. Fornecedor");
                Console.WriteLine("4. Produto");
                Console.WriteLine("5. Producao");
                Console.WriteLine("6. Tarefa");
                Console.WriteLine("0. Sair");
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: MenuCliente(); break;
                    case 2: MenuFuncionario(); break;
                    case 3: MenuFornecedor(); break;
                    case 4: MenuProduto(); break;
                    case 5: MenuProducao(); break;
                    case 6: MenuTarefa(); break;
                }
            } while (opcao != 0);
        }

        static void MenuCliente()
        {
            int opcao;
            do
            {
                Console.WriteLine("\nMENU CLIENTE:");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Visualizar");
                Console.WriteLine("3. Editar");
                Console.WriteLine("0. Voltar");
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: AdicionarCliente(); break;
                    case 2: VisualizarClientes(); break;
                    case 3: EditarCliente(); break;
                }
            } while (opcao != 0);
        }

        static void MenuFuncionario()
        {
            int opcao;
            do
            {
                Console.WriteLine("\nMENU FUNCIONÁRIO:");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Visualizar");
                Console.WriteLine("0. Voltar");
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: AdicionarFuncionario(); break;
                    case 2: VisualizarFuncionarios(); break;
                }
            } while (opcao != 0);
        }

        static void MenuFornecedor()
        {
            int opcao;
            do
            {
                Console.WriteLine("\nMENU FORNECEDOR:");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Visualizar");
                Console.WriteLine("0. Voltar");
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: AdicionarFornecedor(); break;
                    case 2: VisualizarFornecedores(); break;
                }
            } while (opcao != 0);
        }

        static void MenuProducao()
        {
            int opcao;
            do
            {
                Console.WriteLine("\nMENU PRODUCAO:");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("0. Voltar");
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: AdicionarProducao(); break;
                }
            } while (opcao != 0);
        }

        static void MenuProduto()
        {
            int opcao;
            do
            {
                Console.WriteLine("\nMENU PRODUTO:");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Visualizar");
                Console.WriteLine("3. Editar");
                Console.WriteLine("0. Voltar");
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: AdicionarProduto(); break;
                    case 2: VisualizarProdutos(); break;
                    case 3: EditarProduto(); break;
                }
            } while (opcao != 0);
        }

        static void MenuTarefa()
        {
            int opcao;
            do
            {
                Console.WriteLine("\nMENU TAREFA:");
                Console.WriteLine("1. Adicionar");
                Console.WriteLine("2. Visualizar");
                Console.WriteLine("3. Atualizar Status");
                Console.WriteLine("4. Editar");
                Console.WriteLine("0. Voltar");
                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: AdicionarTarefa(); break;
                    case 2: VisualizarTarefas(); break;
                    case 3: AtualizarStatusTarefa(); break;
                    case 4: EditarTarefa(); break;
                }
            } while (opcao != 0);
        }
    }
}

