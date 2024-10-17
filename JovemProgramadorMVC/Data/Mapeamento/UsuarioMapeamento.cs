﻿using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC.Data.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Email).HasColumnType("varchar(30)");
            builder.Property(t => t.Senha).HasColumnType("varchar(30)");

        }
    }
}