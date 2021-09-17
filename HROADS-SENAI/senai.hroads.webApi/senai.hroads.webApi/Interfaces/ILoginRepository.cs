using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// interface responsável por login
/// </summary>
namespace senai.hroads.webApi_.Interfaces
{
    interface ILoginRepository
    {


        /// <summary>
        /// Logar no sistema
        /// </summary>
        /// <param name="senha">senha do usuario</param>
        /// <param name="email">email do usuário</param>
        /// <returns>um token contendo as informações do usuário</returns>
        Login Logar(string senha, string email);
    }
}
