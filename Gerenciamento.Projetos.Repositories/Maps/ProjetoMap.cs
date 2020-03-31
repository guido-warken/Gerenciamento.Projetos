﻿using Gerenciamento.Projetos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerenciamento.Projetos.Repositories.Maps
{
    public class ProjetoMap : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.ToTable("projeto").HasKey(p => p.Id);
            builder.Property(p => p.Id)
            .HasColumnName("idProjeto")
            .ValueGeneratedOnAdd();
            builder.Property(p => p.Nome)
            .HasColumnName("nome")
            .HasMaxLength(30);
            builder.Property(p => p.Descricao)
            .HasColumnName("descricao");
            builder.HasMany(p => p.Lancamentos)
            .WithOne(l => l.Projeto)
            .HasForeignKey(l => l.ProjetoId)
            .HasPrincipalKey(p => p.Id);
        }
    }
}
