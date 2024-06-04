using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudreal
{
    public class Gerente : Usuario
    {
        public string Status { get; set; }

        // Métodos CRUD para Funcionário
        public void AdicionarFuncionario(List<Funcionario> funcionarios)
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Digite o ID do Funcionário:");
            funcionario.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome do Funcionário:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Contato do Funcionário:");
            funcionario.Contato = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CPF do Funcionário:");
            funcionario.CPF = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Status do Funcionário:");
            funcionario.Status = Console.ReadLine();
            funcionarios.Add(funcionario);
            Console.WriteLine("Funcionário incluído com sucesso.");
        }

        public void PesquisarFuncionario(List<Funcionario> funcionarios)
        {
            Console.WriteLine("Digite o ID do Funcionário a ser pesquisado:");
            int id = int.Parse(Console.ReadLine());
            Funcionario funcionario = funcionarios.FirstOrDefault(f => f.ID == id);
            if (funcionario != null)
            {
                funcionario.Visualizar();
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void EditarFuncionario(List<Funcionario> funcionarios)
        {
            Console.WriteLine("Digite o ID do Funcionário a ser editado:");
            int id = int.Parse(Console.ReadLine());
            Funcionario funcionario = funcionarios.FirstOrDefault(f => f.ID == id);
            if (funcionario != null)
            {
                Console.WriteLine("Digite o novo Nome do Funcionário:");
                funcionario.Nome = Console.ReadLine();
                Console.WriteLine("Digite o novo Contato do Funcionário:");
                funcionario.Contato = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo CPF do Funcionário:");
                funcionario.CPF = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo Status do Funcionário:");
                funcionario.Status = Console.ReadLine();
                Console.WriteLine("Funcionário editado com sucesso.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public void ArquivarFuncionario(List<Funcionario> funcionarios)
        {
            Console.WriteLine("Digite o ID do Funcionário a ser arquivado:");
            int id = int.Parse(Console.ReadLine());
            Funcionario funcionario = funcionarios.FirstOrDefault(f => f.ID == id);
            if (funcionario != null)
            {
                funcionarios.Remove(funcionario);
                Console.WriteLine("Funcionário arquivado com sucesso.");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        // Métodos CRUD para Tarefas
        public void AdicionarTarefa(List<Tarefas> tarefas)
        {
            Tarefas tarefa = new Tarefas();
            Console.WriteLine("Digite o Nome da Tarefa:");
            tarefa.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Prazo da Tarefa:");
            tarefa.Prazo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Prioridade da Tarefa:");
            tarefa.Prioridade = Console.ReadLine();
            Console.WriteLine("Digite a Etapa da Tarefa:");
            tarefa.Etapa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Número de Etapas da Tarefa:");
            tarefa.N_Etapas = int.Parse(Console.ReadLine());
            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa incluída com sucesso.");
        }

        public void PesquisarTarefa(List<Tarefas> tarefas)
        {
            Console.WriteLine("Digite o Nome da Tarefa a ser pesquisada:");
            string nome = Console.ReadLine();
            Tarefas tarefa = tarefas.FirstOrDefault(t => t.Nome == nome);
            if (tarefa != null)
            {
                Console.WriteLine($"Nome: {tarefa.Nome}, Prazo: {tarefa.Prazo}, Prioridade: {tarefa.Prioridade}, Etapa: {tarefa.Etapa}, Número de Etapas: {tarefa.N_Etapas}");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        public void EditarTarefa(List<Tarefas> tarefas)
        {
            Console.WriteLine("Digite o Nome da Tarefa a ser editada:");
            string nome = Console.ReadLine();
            Tarefas tarefa = tarefas.FirstOrDefault(t => t.Nome == nome);
            if (tarefa != null)
            {
                Console.WriteLine("Digite o novo Prazo da Tarefa:");
                tarefa.Prazo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova Prioridade da Tarefa:");
                tarefa.Prioridade = Console.ReadLine();
                Console.WriteLine("Digite a nova Etapa da Tarefa:");
                tarefa.Etapa = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo Número de Etapas da Tarefa:");
                tarefa.N_Etapas = int.Parse(Console.ReadLine());
                Console.WriteLine("Tarefa editada com sucesso.");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        public void ArquivarTarefa(List<Tarefas> tarefas)
        {
            Console.WriteLine("Digite o Nome da Tarefa a ser arquivada:");
            string nome = Console.ReadLine();
            Tarefas tarefa = tarefas.FirstOrDefault(t => t.Nome == nome);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa arquivada com sucesso.");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        // Métodos CRUD para Fornecedor
        public void AdicionarFornecedor(List<Fornecedor> fornecedores)
        {
            Fornecedor fornecedor = new Fornecedor();
            Console.WriteLine("Digite o Código do Fornecedor:");
            fornecedor.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome da Empresa:");
            fornecedor.Nome_empresa = Console.ReadLine();
            Console.WriteLine("Digite o Contato Principal:");
            fornecedor.Contato_principal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Data de Registro:");
            fornecedor.Data_registro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Status:");
            fornecedor.Status = Console.ReadLine();
            Console.WriteLine("Digite o Estado:");
            fornecedor.Estado = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ:");
            fornecedor.Cnpj = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CEP:");
            fornecedor.Cep = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Cidade:");
            fornecedor.Cidade = Console.ReadLine();
            fornecedores.Add(fornecedor);
            Console.WriteLine("Fornecedor incluído com sucesso.");
        }

        public void PesquisarFornecedor(List<Fornecedor> fornecedores)
        {
            Console.WriteLine("Digite o Código do Fornecedor a ser pesquisado:");
            int codigo = int.Parse(Console.ReadLine());
            Fornecedor fornecedor = fornecedores.FirstOrDefault(f => f.Codigo == codigo);
            if (fornecedor != null)
            {
                Console.WriteLine($"Código: {fornecedor.Codigo}, Nome da Empresa: {fornecedor.Nome_empresa}, Contato Principal: {fornecedor.Contato_principal}, Data de Registro: {fornecedor.Data_registro}, Status: {fornecedor.Status}, Estado: {fornecedor.Estado}, CNPJ: {fornecedor.Cnpj}, CEP: {fornecedor.Cep}, Cidade: {fornecedor.Cidade}");
            }
            else
            {
                Console.WriteLine("Fornecedor não encontrado.");
            }
        }

        public void EditarFornecedor(List<Fornecedor> fornecedores)
        {
            Console.WriteLine("Digite o Código do Fornecedor a ser editado:");
            int codigo = int.Parse(Console.ReadLine());
            Fornecedor fornecedor = fornecedores.FirstOrDefault(f => f.Codigo == codigo);
            if (fornecedor != null)
            {
                Console.WriteLine("Digite o novo Nome da Empresa:");
                fornecedor.Nome_empresa = Console.ReadLine();
                Console.WriteLine("Digite o novo Contato Principal:");
                fornecedor.Contato_principal = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova Data de Registro:");
                fornecedor.Data_registro = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo Status:");
                fornecedor.Status = Console.ReadLine();
                Console.WriteLine("Digite o novo Estado:");
                fornecedor.Estado = Console.ReadLine();
                Console.WriteLine("Digite o novo CNPJ:");
                fornecedor.Cnpj = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo CEP:");
                fornecedor.Cep = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova Cidade:");
                fornecedor.Cidade = Console.ReadLine();
                Console.WriteLine("Fornecedor editado com sucesso.");
            }
            else
            {
                Console.WriteLine("Fornecedor não encontrado.");
            }
        }

        public void ArquivarFornecedor(List<Fornecedor> fornecedores)
        {
            Console.WriteLine("Digite o Código do Fornecedor a ser arquivado:");
            int codigo = int.Parse(Console.ReadLine());
            Fornecedor fornecedor = fornecedores.FirstOrDefault(f => f.Codigo == codigo);
            if (fornecedor != null)
            {
                fornecedores.Remove(fornecedor);
                Console.WriteLine("Fornecedor arquivado com sucesso.");
            }
            else
            {
                Console.WriteLine("Fornecedor não encontrado.");
            }
        }

        // Métodos CRUD para Cliente
        public void AdicionarCliente(List<Cliente> clientes)
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Digite o Código do Cliente:");
            cliente.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome da Empresa:");
            cliente.Nome_empresa = Console.ReadLine();
            Console.WriteLine("Digite o Contato Principal:");
            cliente.Contato_principal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Data de Registro:");
            cliente.Data_registro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Status:");
            cliente.Status = Console.ReadLine();
            Console.WriteLine("Digite o Estado:");
            cliente.Estado = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ:");
            cliente.Cnpj = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CEP:");
            cliente.Cep = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Cidade:");
            cliente.Cidade = Console.ReadLine();
            Console.WriteLine("Digite a Classificação:");
            cliente.Classificacao = Console.ReadLine();
            clientes.Add(cliente);
            Console.WriteLine("Cliente incluído com sucesso.");
        }

        public void PesquisarCliente(List<Cliente> clientes)
        {
            Console.WriteLine("Digite o Código do Cliente a ser pesquisado:");
            int codigo = int.Parse(Console.ReadLine());
            Cliente cliente = clientes.FirstOrDefault(c => c.Codigo == codigo);
            if (cliente != null)
            {
                Console.WriteLine($"Código: {cliente.Codigo}, Nome da Empresa: {cliente.Nome_empresa}, Contato Principal: {cliente.Contato_principal}, Data de Registro: {cliente.Data_registro}, Status: {cliente.Status}, Estado: {cliente.Estado}, CNPJ: {cliente.Cnpj}, CEP: {cliente.Cep}, Cidade: {cliente.Cidade}, Classificação: {cliente.Classificacao}");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        public void EditarCliente(List<Cliente> clientes)
        {
            Console.WriteLine("Digite o Código do Cliente a ser editado:");
            int codigo = int.Parse(Console.ReadLine());
            Cliente cliente = clientes.FirstOrDefault(c => c.Codigo == codigo);
            if (cliente != null)
            {
                Console.WriteLine("Digite o novo Nome da Empresa:");
                cliente.Nome_empresa = Console.ReadLine();
                Console.WriteLine("Digite o novo Contato Principal:");
                cliente.Contato_principal = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova Data de Registro:");
                cliente.Data_registro = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo Status:");
                cliente.Status = Console.ReadLine();
                Console.WriteLine("Digite o novo Estado:");
                cliente.Estado = Console.ReadLine();
                Console.WriteLine("Digite o novo CNPJ:");
                cliente.Cnpj = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo CEP:");
                cliente.Cep = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova Cidade:");
                cliente.Cidade = Console.ReadLine();
                Console.WriteLine("Digite a nova Classificação:");
                cliente.Classificacao = Console.ReadLine();
                Console.WriteLine("Cliente editado com sucesso.");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        public void ArquivarCliente(List<Cliente> clientes)
        {
            Console.WriteLine("Digite o Código do Cliente a ser arquivado:");
            int codigo = int.Parse(Console.ReadLine());
            Cliente cliente = clientes.FirstOrDefault(c => c.Codigo == codigo);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente arquivado com sucesso.");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        // Métodos CRUD para Produção
        public void AdicionarProducao(List<Producao> producoes)
        {
            Producao producao = new Producao();
            Console.WriteLine("Digite o ID da Produção:");
            producao.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome do Produto:");
            producao.NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite a Data de Início:");
            producao.Datainicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Prazo:");
            producao.Prazo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade:");
            producao.Qtd = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Data de Fim:");
            producao.DataFim = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Prioridade:");
            producao.Prioridade = Console.ReadLine();
            Console.WriteLine("Digite o ID do Fornecedor:");
            producao.ID_Fornecedor = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Código do Cliente:");
            producao.Codigo_Cliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Número de Etapas:");
            producao.N_Etapas = int.Parse(Console.ReadLine());
            producoes.Add(producao);
            Console.WriteLine("Produção incluída com sucesso.");
        }

        public void PesquisarProducao(List<Producao> producoes)
        {
            Console.WriteLine("Digite o ID da Produção a ser pesquisada:");
            int id = int.Parse(Console.ReadLine());
            Producao producao = producoes.FirstOrDefault(p => p.ID == id);
            if (producao != null)
            {
                Console.WriteLine($"ID: {producao.ID}, Nome do Produto: {producao.NomeProduto}, Data de Início: {producao.Datainicio}, Prazo: {producao.Prazo}, Quantidade: {producao.Qtd}, Data de Fim: {producao.DataFim}, Prioridade: {producao.Prioridade}, ID do Fornecedor: {producao.ID_Fornecedor}, Código do Cliente: {producao.Codigo_Cliente}, Número de Etapas: {producao.N_Etapas}");
            }
            else
            {
                Console.WriteLine("Produção não encontrada.");
            }
        }

        public void EditarProducao(List<Producao> producoes)
        {
            Console.WriteLine("Digite o ID da Produção a ser editada:");
            int id = int.Parse(Console.ReadLine());
            Producao producao = producoes.FirstOrDefault(p => p.ID == id);
            if (producao != null)
            {
                Console.WriteLine("Digite o novo Nome do Produto:");
                producao.NomeProduto = Console.ReadLine();
                Console.WriteLine("Digite a nova Data de Início:");
                producao.Datainicio = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo Prazo:");
                producao.Prazo = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova Quantidade:");
                producao.Qtd = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova Data de Fim:");
                producao.DataFim = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nova Prioridade:");
                producao.Prioridade = Console.ReadLine();
                Console.WriteLine("Digite o novo ID do Fornecedor:");
                producao.ID_Fornecedor = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo Código do Cliente:");
                producao.Codigo_Cliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o novo Número de Etapas:");
                producao.N_Etapas = int.Parse(Console.ReadLine());
                Console.WriteLine("Produção editada com sucesso.");
            }
            else
            {
                Console.WriteLine("Produção não encontrada.");
            }
        }

        public void ArquivarProducao(List<Producao> producoes)
        {
            Console.WriteLine("Digite o ID da Produção a ser arquivada:");
            int id = int.Parse(Console.ReadLine());
            Producao producao = producoes.FirstOrDefault(p => p.ID == id);
            if (producao != null)
            {
                producoes.Remove(producao);
                Console.WriteLine("Produção arquivada com sucesso.");
            }
            else
            {
                Console.WriteLine("Produção não encontrada.");
            }
        }
    }
}
