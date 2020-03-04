using Aula_solid.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailService
                .EnviarEmail(new Entidades.Pessoa("0000000000", "Ronald", "yan_couto@outlook.com"));
            Console.ReadLine();

        }
    }
}
