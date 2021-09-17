using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



/// <summary>
/// classe responsável pelo Login
/// </summary>
namespace senai.hroads.webApi_.Domains
{

    //email de usuario
    //senha de usuario

    public class Login
    {
        [Required(ErrorMessage = "A senha do usuário é obrigatório!")]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "A senha deve conter entre 8 e 12 caracteres")]
        public string senha { get; set; }

        [Required(ErrorMessage = "O email do usuário é obrigatório!")]
        public string email { get; set; }

    }
}
