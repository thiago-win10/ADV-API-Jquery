using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Context;
using Mercado.Infraestrutura.Interface;

namespace Mercado.Infraestrutura.Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(MercadoContext mercadoContext) : base(mercadoContext)
        {

        }
    }
}
