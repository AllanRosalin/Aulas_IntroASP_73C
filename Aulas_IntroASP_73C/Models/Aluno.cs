using System.ComponentModel.DataAnnotations;

namespace Aulas_IntroASP_73C.Models
{
    public class Aluno
    {
        public int ID { get; set; }

        [Required (ErrorMessage = "Campo obrigatório")]
        public string ? Nome { get; set; }

        [Display(Name = "Data de Nasciemnto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Rg { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ? Telefone { get; set; }
    }
}
