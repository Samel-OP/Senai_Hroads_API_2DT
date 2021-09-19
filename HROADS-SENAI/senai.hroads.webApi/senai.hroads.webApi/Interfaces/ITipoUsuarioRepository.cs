using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        //Cadastrar
        //Listar
        //Atualizar
        //ListarPorId
        //Deletar

        /// <summary>
        /// Cadastra um novo tipo de usuario 
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto contendo as informações do</param>
        void Cadastrar(TiposUsuario novoTipoUsuario);

        /// <summary>
        /// Lista todos os tipos de usuario
        /// </summary>
        /// <returns> uma lista de tipos de usuario</returns>
        List<TiposUsuario> Listar();


        /// <summary>
        /// atualiza um tipo de usuario pelo id
        /// </summary>
        /// <param name="id">id do tipo usuario que será atualizado</param>
        /// <param name="tipoUsuarioAtualizado">Objeto contendo o tipo usuario atuaizado</param>
        void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado);

        /// <summary>
        /// busca um tipo usuario pelo id
        /// </summary>
        /// <param name="id"> id do tipo usuario que será buscado</param>
        /// <returns>o tipo usuariio buscado</returns>
        TiposUsuario BuscarPorId(int id);


        /// <summary>
        /// deleta um tipo de usuario
        /// </summary>
        /// <param name="id">id do tipo de usuario passado</param>
        void Deletar(int id);

    }
}
