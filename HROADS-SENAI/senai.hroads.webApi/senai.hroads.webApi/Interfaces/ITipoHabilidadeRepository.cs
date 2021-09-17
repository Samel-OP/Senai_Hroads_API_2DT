using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        //Cadastrar
        //Listar
        //Atualizar
        //ListarPorId
        //Deletar

        /// <summary>
        /// Cadastra um novo tipo de habilidade
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto contendo as informações do novo tipo de habilidade</param>
        void Cadastrar(TiposHabilidade novoTipoHabilidade);

        /// <summary>
        /// Lista todos os tipos de habilidade
        /// </summary>
        /// <returns> uma lista de tipos de habilidade</returns>
        List<TiposHabilidade> Listar();


        /// <summary>
        /// atualiza um tipo de habilidae pelo id
        /// </summary>
        /// <param name="id">id do tipo habilidade que será atualizado</param>
        /// <param name="tipoHabilidadeAtualizado">Objeto contendo o tipo habilidade atuaizado</param>
        void Atualizar(int id, TiposUsuario tipoHabilidadeAtualizado);

        /// <summary>
        /// busca um tipo habilidade pelo id
        /// </summary>
        /// <param name="id"> id do tipo usuari que será buscado</param>
        /// <returns>o tipo usuariio buscado</returns>
        TiposUsuario BuscarPorId(int id);


        /// <summary>
        /// deleta um tipo de usuario
        /// </summary>
        /// <param name="id">id do tipo de usuario passado</param>
        void Deletar(int id);
    }
}
