using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Context;
using Mercado.Infraestrutura.Interface;

namespace Mercado.Infraestrutura.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(MercadoContext mercadoContext) : base(mercadoContext)
        {

        }
    }
}
