using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudreal
{
    public class Producao
    {
        public int ID { get; set; }
        public string NomeProduto { get; set; }
        public int Datainicio { get; set; }
        public int Prazo { get; set; }
        public int Qtd { get; set; }
        public int DataFim { get; set; }
        public string Prioridade { get; set; }
        public int ID_Fornecedor { get; set; }
        public int Codigo_Cliente { get; set; }
        public int N_Etapas { get; set; }
    }
}
