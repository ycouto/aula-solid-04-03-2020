using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_solid.Entidades
{
    public class Pessoa
    {
        public string Documento { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public Pessoa(string documento, string nome, string email)
        {
            Documento = documento ?? throw new Exception("Informe o documento!");
            Nome = nome ?? throw new Exception("Informe o Nome!");
            Email = email ?? throw new Exception("Informe o email!");
        }
    }
}
