namespace Domain.Entities
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadePatas { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }

    }
}
