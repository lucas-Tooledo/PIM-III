using System;
using System.Collections.Generic;
using System.Linq;

namespace crudreal
{
    class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Tarefas> tarefas = new List<Tarefas>();
        List<Fornecedor> fornecedores = new List<Fornecedor>();
        List<Cliente> clientes = new List<Cliente>();
        List<Producao> producoes = new List<Producao>();
        Gerente gerente = new Gerente();
        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Adicionar Funcionário");
            Console.WriteLine("2. Pesquisar Funcionário");
            Console.WriteLine("3. Editar Funcionário");
            Console.WriteLine("4. Arquivar Funcionário");
            Console.WriteLine("5. Adicionar Tarefa");
            Console.WriteLine("6. Pesquisar Tarefa");
            Console.WriteLine("7. Editar Tarefa");
            Console.WriteLine("8. Arquivar Tarefa");
            Console.WriteLine("9. Adicionar Fornecedor");
            Console.WriteLine("10. Pesquisar Fornecedor");
            Console.WriteLine("11. Editar Fornecedor");
            Console.WriteLine("12. Arquivar Fornecedor");
            Console.WriteLine("13. Adicionar Cliente");
            Console.WriteLine("14. Pesquisar Cliente");
            Console.WriteLine("15. Editar Cliente");
            Console.WriteLine("16. Arquivar Cliente");
            Console.WriteLine("17. Adicionar Produção");
            Console.WriteLine("18. Pesquisar Produção");
            Console.WriteLine("19. Editar Produção");
            Console.WriteLine("20. Arquivar Produção");
            Console.WriteLine("0. Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    gerente.AdicionarFuncionario(funcionarios);
                    break;
                case 2:
                    gerente.PesquisarFuncionario(funcionarios);
                    break;
                case 3:
                    gerente.EditarFuncionario(funcionarios);
                    break;
                case 4:
                    gerente.ArquivarFuncionario(funcionarios);
                    break;
                case 5:
                    gerente.AdicionarTarefa(tarefas);
                    break;
                case 6:
                    gerente.PesquisarTarefa(tarefas);
                    break;
                case 7:
                    gerente.EditarTarefa(tarefas);
                    break;
                case 8:
                    gerente.ArquivarTarefa(tarefas);
                    break;
                case 9:
                    gerente.AdicionarFornecedor(fornecedores);
                    break;
                case 10:
                    gerente.PesquisarFornecedor(fornecedores);
                    break;
                case 11:
                    gerente.EditarFornecedor(fornecedores);
                    break;
                case 12:
                    gerente.ArquivarFornecedor(fornecedores);
                    break;
                case 13:
                    gerente.AdicionarCliente(clientes);
                    break;
                case 14:
                    gerente.PesquisarCliente(clientes);
                    break;
                case 15:
                    gerente.EditarCliente(clientes);
                    break;
                case 16:
                    gerente.ArquivarCliente(clientes);
                    break;
                case 17:
                    gerente.AdicionarProducao(producoes);
                    break;
                case 18:
                    gerente.PesquisarProducao(producoes);
                    break;
                case 19:
                    gerente.EditarProducao(producoes);
                    break;
                case 20:
                    gerente.ArquivarProducao(producoes);
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
}
