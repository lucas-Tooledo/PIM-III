using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudreal
{
    public class Fornecedor
    {
        public int Codigo { get; set; }
        public string Nome_empresa { get; set; }
        public double Contato_principal { get; set; }
        public int Data_registro { get; set; }
        public string Status { get; set; }
        public string Estado { get; set; }
        public int Cnpj { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
    }
}
