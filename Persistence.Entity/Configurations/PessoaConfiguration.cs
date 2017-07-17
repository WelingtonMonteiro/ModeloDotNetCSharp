using System;
using Domain.Entities;
using Persistence.Entity.TemplateConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persistence.Entity.Configurations
{
    public class PessoaConfiguration : PersistenceTypeConfiguration<Pessoa>
    {
        public override void ConfiguraCampos()
        {
            Property(p => p.CPF)
            .HasMaxLength(14);
        }

        public override void ConfiguraChavePrimaria()
        {
            HasKey(p => p.PessoaId);

            Property(p => p.CPF)
                .HasColumnAnnotation("Index",
                    new IndexAnnotation(new[]
                    {
                            new IndexAttribute("IX_pessoa_CPF")
                            {
                                IsUnique = true,
                                Order = 1
                            }
                    }));

        }

        public override void ConfiguraNomeTabela()
        {
            ToTable("pessoas");
        }

        public override void ConfiguraRelacionamentos()
        {
            HasMany(p => p.Animais);
        }
    }
}
