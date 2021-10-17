using Business.Interfaces;
using Business.Model;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ContextApiPires contextApiPires) : base(contextApiPires)
        {
        }
    }
}
