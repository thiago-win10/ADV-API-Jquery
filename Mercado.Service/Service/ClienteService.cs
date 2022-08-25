using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Interface;
using Mercado.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Service.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        public ClienteService(IBaseRepositorio<Cliente> db) : base(db)
        {

        }
    }
}
