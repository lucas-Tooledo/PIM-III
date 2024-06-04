using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudreal
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Contato { get; set; }
        public int CPF { get; set; }

        public virtual void Visualizar()
        {
            Console.WriteLine($"ID: {ID}, Nome: {Nome}, Contato: {Contato}, CPF: {CPF}");
        }

        public virtual Usuario Pesquisar(List<Usuario> usuarios, int id)
        {
            return usuarios.FirstOrDefault(u => u.ID == id);
        }
    }
}
