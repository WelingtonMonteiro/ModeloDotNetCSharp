using System.Collections;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CPF { get; set; }

        public ICollection<Animal> Animais { get; set; }

        public Pessoa()
        {
            Animais = new HashSet<Animal>();
        }


    }
}
