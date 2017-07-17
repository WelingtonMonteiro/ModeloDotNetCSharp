using Domain.Entities;
using Persistence.Entity.TemplateConfiguration;
using System;

namespace Persistence.Entity.Configurations
{
    public class AnimalConfiguration : PersistenceTypeConfiguration<Animal>
    {
        public override void ConfiguraCampos()
        {

        }

        public override void ConfiguraChavePrimaria()
        {
            HasKey(p => p.AnimalId);
        }

        public override void ConfiguraNomeTabela()
        {
            ToTable("animais");
        }

        public override void ConfiguraRelacionamentos()
        {
            HasRequired<Pessoa>(p => p.Pessoa)
                .WithMany(p => p.Animais)
                .HasForeignKey(p => p.PessoaId);
        }
    }
}
