using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface IHabilidadeRepository
    {
        //Cadastrar
        //Listar
        //Atualizar
        //ListarPorId
        //Deletar

        /// <summary>
        /// Cadastra uma nova habilidade 
        /// </summary>
        /// <param name="novaHabilidade">Objeto contendo as informações da habilidade</param>
        void Cadastrar(Habilidade novaHabilidade);

        /// <summary>
        /// Lista todas as habilidades
        /// </summary>
        /// <returns> uma lista de habilidades</returns>
        List<Habilidade> Listar();


        /// <summary>
        /// atualiza uma habilidade
        /// </summary>
        /// <param name="id">id da habilidade que será atualizado</param>
        /// <param name="habilidadeAtualizada">Objeto contendo as inforamções da habilidade atualizada</param>
        void Atualizar(int id, Habilidade habilidadeAtualizada);

        /// <summary>
        /// busca uma habilidade pelo id
        /// </summary>
        /// <param name="id"> id da habilidade que será buscada</param>
        /// <returns>o tipo usuariio buscado</returns>
        Habilidade BuscarPorId(int id);


        /// <summary>
        /// deleta uma habilidade
        /// </summary>
        /// <param name="id">id da habilidade passada</param>
        void Deletar(int id);
    }
}
