using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.InfraStructure.EntitiesConfiguration
{
    public class LivrariaConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.HasKey(t => t.LivroId);
            builder.Property(p => p.Titulo).HasMaxLength(300).IsRequired();
            builder.Property(p => p.Autor).HasMaxLength(300).IsRequired();
            builder.Property(p => p.Lancamento).IsRequired();
            builder.Property(p => p.Capa).HasMaxLength(200);
        }
    }
}