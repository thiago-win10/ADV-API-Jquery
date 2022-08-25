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
    public class FornecedorService : BaseService<Fornecedor>, IFornecedorService
    {
        public FornecedorService(IBaseRepositorio<Fornecedor> db) : base(db)
        {

        }
    }
}
