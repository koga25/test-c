using System.ComponentModel.DataAnnotations;

namespace Hacka.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Insira a sua senha")]
        public string CPF { get; set; } = "";
    }
}
