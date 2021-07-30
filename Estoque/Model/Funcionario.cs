using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Model
{
    class Funcionario
    {
        private int id { get; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string contato { get; set; }
        public string contato2 { get; set; }
        public Funcionario(int id, string nome, string senha, string contato, string contato2)
        {
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.contato = contato;
            this.contato2 = contato2;
        }
    }
}
