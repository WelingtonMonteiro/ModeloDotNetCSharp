using System.ComponentModel;

namespace ViewModel.Pessoa
{
    public class PessoaViewModelList
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }

        [DisplayName("Sobrenome")]
        public string SobreNome { get; set; }

        public string CPF { get; set; }
    }
}
