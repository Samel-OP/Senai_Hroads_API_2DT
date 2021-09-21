﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.ViewModels
{
    /// <summary>
    /// Classe responsável pelo modelo Login
    /// </summary>
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail do usuário!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário!")]
        public string Senha { get; set; }

 
        public string idUsuario { get; set; }

       
        public string idTipoUsuario { get; set; }
    }
}
