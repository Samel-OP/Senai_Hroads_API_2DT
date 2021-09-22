using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using senai.hroads.webApi_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadeController : ControllerBase
    {
        private IHabilidadeRepository _habilidadeRepository { get; set; }

        public HabilidadeController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }


        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Uma lista de usuários e um status code.</returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_habilidadeRepository.Listar());
            }
            catch (Exception excep)
            {

                return BadRequest(excep);
            }
        }


        /// <summary>
        /// Lista uma habilidade pelo seu Id
        /// </summary>
        /// <returns>Uma habilidade e um status code.</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Habilidade habilidadeBuscada = _habilidadeRepository.BuscarPorId(id);


            if (habilidadeBuscada == null)
            {
                return NotFound(
                    new
                    {
                        mensagem = "Essa habilidade não existe ou algo deu errado!",
                        erro = true
                    });
            }

            try
            {
                return Ok(habilidadeBuscada);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza uma habilidade existente pelo seu Id
        /// </summary>
        /// <param name="id">Id da habilidade</param>
        /// <param name="habilidadeAtualizada">Objeto onde está as informções atualizadas</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult AtualizarPorId(int id, Habilidade habilidadeAtualizada)
        {
            Habilidade habilidadeBuscada = _habilidadeRepository.BuscarPorId(id);


            if (habilidadeBuscada == null)
            {
                return NotFound(
                    new
                    {
                        mensagem = "Essa habilidade não existe ou algo deu errado!",
                        erro = true
                    });
            }

            try
            {
                _habilidadeRepository.Atualizar(id, habilidadeAtualizada);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra uma nova habilidade
        /// </summary>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Habilidade novaHabilidade)
        {

            if (novaHabilidade != null)
            {
                try
                {
                    _habilidadeRepository.Cadastrar(novaHabilidade);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
            }

            return NotFound(
                new
                {
                    mensagem = "Campo vazio !",
                    erro = true
                });
        }

        /// <summary>
        /// Deleta uma habilidade existente
        /// </summary>
        /// <param name="id">id da habilidade que será deletada</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// ex: http://localhost:5000/api/usuario/excluir/2
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            Habilidade habilidadeBuscada = _habilidadeRepository.BuscarPorId(id);

            if (habilidadeBuscada != null)
            {
                try
                {
                    _habilidadeRepository.Deletar(id);
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
            }

            return NotFound("Id não encontrado ou o campo está vazio!");
        }
    }
}
