using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface IClasseHabilidadeRepository
    {
        //Cadastrar
        //Listar
        //Atualizar
        //ListarPorId
        //Deletar

        /// <summary>
        /// Cadastra uma classe habilidade
        /// </summary>
        /// <param name="novaClasseHabilidade">Objeto contendo as informações do</param>
        void Cadastrar(ClasseHabilidade novaClasseHabilidade);

        /// <summary>
        /// Lista todas as classes habilidades
        /// </summary>
        /// <returns> uma lista de classe habilidade</returns>
        List<ClasseHabilidade> Listar();


        /// <summary>
        /// atualiza uma classe habilidade pelo id
        /// </summary>
        /// <param name="id">id da classe habilidade que será atualizada</param>
        /// <param name="classeHabilidadeAtualizada">Objeto contendo classe habilidade atuaizado</param>
        void Atualizar(int id, ClasseHabilidade classeHabilidadeAtualizada);

        /// <summary>
        /// busca uma classe habilidade pelo id
        /// </summary>
        /// <param name="id"> id da classe habilidade que será buscado</param>
        /// <returns> classe habilidade buscada</returns>
        ClasseHabilidade BuscarPorId(int id);


        /// <summary>
        /// deleta uma classe habilidade
        /// </summary>
        /// <param name="id">id da classe habilidade passada</param>
        void Deletar(int id);
    }
}
