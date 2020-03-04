using Aula_solid.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_solid.Servicos
{
    internal class EmailService
    {
        public static void EnviarEmail(Pessoa pessoa)
            => Console.WriteLine($"Para: {pessoa.Email}, Mensagem: Olá {pessoa.Nome}");
    }
}
