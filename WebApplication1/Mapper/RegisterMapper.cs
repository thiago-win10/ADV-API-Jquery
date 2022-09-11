using AutoMapper;
using Mercado.Application.Command;
using Mercado.Entidades.Models;
using Mercado.Entidades.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercado.Web.Mapper
{
    public class RegisterMapper : Profile
    {
        public RegisterMapper()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<AdicionarClienteCommand, ClienteViewModel>();
            CreateMap<AtualizarClienteCommand, ClienteViewModel>();

        }
    }
}
