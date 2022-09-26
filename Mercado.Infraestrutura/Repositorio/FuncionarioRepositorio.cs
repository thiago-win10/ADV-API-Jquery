using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Context;
using Mercado.Infraestrutura.Interface;

namespace Mercado.Infraestrutura.Repositorio
{
    public class FuncionarioRepositorio : BaseRepositorio<Funcionario>, IFuncionarioRepositorio
    {
        public FuncionarioRepositorio(MercadoContext mercadoContext) : base(mercadoContext)
        {

        }
    }
}
