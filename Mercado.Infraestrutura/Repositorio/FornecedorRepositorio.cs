using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Context;
using Mercado.Infraestrutura.Interface;

namespace Mercado.Infraestrutura.Repositorio
{
    public class FornecedorRepositorio : BaseRepositorio<Fornecedor>, IFornecedorRepositorio
    {
        public FornecedorRepositorio(MercadoContext mercadoContext) : base(mercadoContext)
        {

        }
    }
}
