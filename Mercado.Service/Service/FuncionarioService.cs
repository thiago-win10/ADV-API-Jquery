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
    public class FuncionarioService : BaseService<Funcionario>, IFuncionarioService
    {
        public FuncionarioService(IBaseRepositorio<Funcionario> db) : base(db)
        {
                
        }
    }
}
