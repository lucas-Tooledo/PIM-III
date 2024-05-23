using ConsoleApp1555;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Gerente : Usuario
    {
        public char Status { get; set; }

        static void AdicionarFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Digite o ID do Funcionário: ");
            funcionario.Id = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Funcionário: ");
            funcionario.Nome = Console.ReadLine();
            funcionario.Add(funcionario);
        }
        static void VisualizarFuncionarios()
        {
            foreach (var funcionario in funcionario)
            {
                funcionario.Visualizar();
            }
        }

        // Métodos CRUD para Cliente
        static void AdicionarCliente()
        {
            Cliente cliente = new Cliente();
            Console.Write("Digite o ID do Cliente: ");
            cliente.Id = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Cliente: ");
            cliente.Nome = Console.ReadLine();
            clientes.Add(cliente);
        }

        static void VisualizarCliente()
        {
            foreach (var cliente in cliente)
            {
                cliente.Visualizar();
            }
        }

        static void EditarCliente()
        {
            Console.Write("Digite o ID do Cliente para Editar: ");
            int id = int.Parse(Console.ReadLine());
            Cliente cliente = cliente.Find(g => g.Id == id);
            if (cliente != null)
            {
                Console.Write("Digite o novo Nome do Cliente: ");
                cliente.Nome = Console.ReadLine();
                cliente.Editar();
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }

        // Métodos CRUD para Fornecedor
        static void AdicionarFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();
            Console.Write("Digite o ID do Fornecedor: ");
            fornecedor.Id = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Fornecedor: ");
            fornecedor.Nome = Console.ReadLine();
            fornecedor.Add(fornecedor);
        }

        static void VisualizarFornecedores()
        {
            foreach (var fornecedor in fornecedor)
            {
                fornecedor.Visualizar();
            }
        }
        // Métodos CRUD para Tarefa
        static void AdicionarTarefa()
        {
            Tarefa tarefa = new Tarefa();
            Console.Write("Digite o ID da Tarefa: ");
            tarefa.TarefaId = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição da Tarefa: ");
            tarefa.Descricao = Console.ReadLine();
            Console.Write("Digite o Status da Tarefa: ");
            tarefa.Status = Console.ReadLine();
            tarefas.Add(tarefa);
        }

        static void VisualizarTarefas()
        {
            foreach (var tarefa in tarefas)
            {
                tarefa.Visualizar();
            }
        }

        static void AtualizarStatusTarefa()
        {
            Console.Write("Digite o ID da Tarefa para Atualizar Status: ");
            int id = int.Parse(Console.ReadLine());
            Tarefa tarefa = tarefa.Find(t => t.TarefaId == id);
            if (tarefa != null)
            {
                Console.Write("Digite o novo Status da Tarefa: ");
                tarefa.Status = Console.ReadLine();
                tarefa.Atualizar_Status();
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }

        static void EditarTarefa()
        {
            Console.Write("Digite o ID da Tarefa para Editar: ");
            int id = int.Parse(Console.ReadLine());
            Tarefa tarefa = tarefa.Find(t => t.TarefaId == id);
            if (tarefa != null)
            {
                Console.Write("Digite a nova Descrição da Tarefa: ");
                tarefa.Descricao = Console.ReadLine();
                tarefa.Editar_Tarefa();
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }

        static void Producao()
        {
            Producao producao = new Producao();
            Console.Write("Digite o ID da producao: ");
            producao.Producao = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição da produção: ");
            producao.Descricao = Console.ReadLine();
            producao.Add(producao);
        }
    }
}

