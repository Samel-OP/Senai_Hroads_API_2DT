using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface IClasseRepository
    {
        //Cadastrar
        //Listar
        //Atualizar
        //ListarPorId
        //Deletar

        /// <summary>
        /// Cadastra uma nova Classe de personagem
        /// </summary>
        /// <param name="novaClasse">Objeto que vai conter as informções Classe</param>
        void Cadastrar(Classe novaClasse);

        /// <summary>
        /// Lista todas as Classes existentes
        /// </summary>
        /// <returns>Uma lista de Classes</returns>
        List<Classe> Listar();

        /// <summary>
        /// Atualiza as informações da Classe pelo Id
        /// </summary>
        /// <param name="idClasse">Id da classe que será atualizada</param>
        /// <param name="classeAtualizada">Objeto que vai conter as informações da classe atualizada</param>
        void Atualizar(int idClasse, Classe classeAtualizada);

        /// <summary>
        /// Lista a classe de acordo com seu id
        /// </summary>
        /// <param name="idClasse">Id que será listado</param>
        /// <returns>A classe buscada</returns>
        Classe ListarPorId(int idClasse);

        /// <summary>
        /// Deleta uma classe existente
        /// </summary>
        /// <param name="idClasse">Id da classe que será deletada</param>
        void Deletar(int idClasse);
    }
}
