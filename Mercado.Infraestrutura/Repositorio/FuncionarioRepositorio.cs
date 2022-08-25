using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Context;
using Mercado.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Infraestrutura.Repositorio
{
    public class FuncionarioRepositorio : BaseRepositorio<Funcionario>, IFuncionarioRepositorio
    {
        public FuncionarioRepositorio(MercadoContext mercadoContext) : base(mercadoContext)
        {

        }
    }
}
