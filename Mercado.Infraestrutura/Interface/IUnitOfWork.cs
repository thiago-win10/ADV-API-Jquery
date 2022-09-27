﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Infraestrutura.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
