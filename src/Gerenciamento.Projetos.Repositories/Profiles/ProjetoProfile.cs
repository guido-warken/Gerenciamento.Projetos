﻿using AutoMapper;
using Gerenciamento.Projetos.Entities;
using Gerenciamento.Projetos.Repositories.Models;

namespace Gerenciamento.Projetos.Repositories.Profiles
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
