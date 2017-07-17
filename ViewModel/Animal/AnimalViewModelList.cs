using System.ComponentModel;

namespace ViewModel.Animal
{
    public class AnimalViewModelList
    {
        public int AnimalId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        [DisplayName("Quantidade de patas")]
        public int QuantidadePatas { get; set; }
        
        [DisplayName("Dono")]
        public int PessoaId { get; set; }
    }
}
