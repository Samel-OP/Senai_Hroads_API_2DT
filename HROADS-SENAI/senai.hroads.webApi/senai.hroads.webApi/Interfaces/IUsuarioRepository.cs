using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IUsuarioRepository
    {
        //Cadastrar
        //Listar
        //Atualizar
        //ListarPorId
        //Deletar

        Usuario Login(string email, string senha);

        /// <summary>
        /// Cadastra um novo tipo de usuario 
        /// </summary>
        /// <param name="novoUsuario">Objeto contendo as informações do</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Lista todos os tipos de usuario
        /// </summary>
        /// <returns> uma lista de usuario</returns>
        List<Usuario> Listar();

        /// <summary>
        /// atualiza um tipo de usuario pelo id
        /// </summary>
        /// <param name="id">id do tipo usuario que será atualizado</param>
        /// <param name="UsuarioAtualizado">Objeto contendo o tipo usuario atuaizado</param>
        void Atualizar(int id, Usuario UsuarioAtualizado);

        /// <summary>
        /// busca um tipo usuario pelo id
        /// </summary>
        /// <param name="id"> id do tipo usuario que será buscado</param>
        /// <returns>o tipo usuariio buscado</returns>
        Usuario BuscarPorId(int id);

        /// <summary>
        /// deleta um tipo de usuario
        /// </summary>
        /// <param name="id">id do tipo de usuario passado</param>
        void Deletar(int id);
    }
}
