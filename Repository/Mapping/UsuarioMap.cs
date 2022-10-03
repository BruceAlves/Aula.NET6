using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class UsuarioMap
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("inserirUsuario");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasColumnName("nome");
            builder.Property(p => p.Email).HasColumnName("email");
            builder.Property(p => p.Senha).HasColumnName("senha");
            builder.Property(p => p.Tipo).HasColumnName("tipo");
        }

    }
}
