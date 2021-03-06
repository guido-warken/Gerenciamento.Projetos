﻿using AutoMapper;
using Softplan.Gerenciamento.Projetos.Entities;
using Softplan.Gerenciamento.Projetos.Repositories.Models;

namespace Softplan.Gerenciamento.Projetos.Repositories.Profiles
{
    public class ProjetoProfile : Profile
    {
        public ProjetoProfile()
        {
            CreateMap<ProjetoModel, Projeto>();
            CreateMap<Projeto, ProjetoModel>();
        }
    }
}
