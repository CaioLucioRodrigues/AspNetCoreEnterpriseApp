using NSE.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSE.Cliente.API.Application.Commands
{
    public class RegistrarClienteCommand : Command
    {
        public RegistrarClienteCommand(Guid id, string nome, string email, string cpf)
        {
            AggregateId = id;
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }

        public Guid Id { get; private set; }
        
        public string Nome { get; private set; }
        
        public string Email { get; private set; }
        
        public string Cpf { get; private set; }
    }
}
