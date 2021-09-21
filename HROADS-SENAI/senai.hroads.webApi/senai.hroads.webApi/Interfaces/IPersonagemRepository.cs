using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


   /// <summary>
   /// interface responsável pela entidade de personagem
   /// </summary>
namespace senai.hroads.webApi_.Interfaces
{
    interface IPersonagemRepository
    {
        //Cadastrar
        //Listar
        //Atualizar
        //ListarPorId
        //Deletar

        /// <summary>
        /// Cadastra um novo personagem
        /// </summary>
        /// <param name="novoPersonagem">Objeto contendo as informações do personagem</param>
        void Cadastrar(Personagem novoPersonagem);

        /// <summary>
        /// Lista todos os personagens
        /// </summary>
        /// <returns> uma lista de personagens</returns>
        List<Personagem> Listar();

        /// <summary>
        /// atualiza um personagem
        /// </summary>
        /// <param name="id">id do personagem</param>
        /// <param name="">Objeto contendo as informações de personagem</param>
        void Atualizar(int id, Personagem personagemAtualizado);

        /// <summary>
        /// busca um personagem pelo id
        /// </summary>
        /// <param name="id"> id do de personagem que será buscado</param>
        /// <returns> personagem buscado</returns>
        Personagem BuscarPorId(int id);


        /// <summary>
        /// deleta um personagem
        /// </summary>
        /// <param name="id">id do personagem passado</param>
        void Deletar(int id);
    }
}
