using System.ComponentModel.DataAnnotations;

namespace GerenciaTelegrama.Models
{

    public partial class Usuario
    {

        [Display(Name = "SENHA")]
        [Required(ErrorMessage = "Preenchimento obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "USERNAME")]
        [Required(ErrorMessage = "Preenchimento obrigatório", AllowEmptyStrings = false)]
        public string Username { get; set; }
    }

}