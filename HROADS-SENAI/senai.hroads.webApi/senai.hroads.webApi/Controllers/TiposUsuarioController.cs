using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi_.Domains;
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
    public class TiposUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository { get; set; }

        public TiposUsuarioController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Lista todos os tipos de usuários
        /// </summary>
        /// <returns>Uma lista de tipos de usuários e um status code.</returns>
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_tipoUsuarioRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Lista um tipo de usuário pelo seu Id
        /// </summary>
        /// <returns>Um tipo de usuário e um status code.</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            TiposUsuario tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(id);
            
            if (tipoUsuarioBuscado == null)
            {
                return NotFound(
                    new 
                    {
                        mensagem = "Esse tipo de usuário não existe ou algo de errado!",
                        erro = true
                    });
            }

            try
            {
                return Ok(tipoUsuarioBuscado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza um tipo de usuário existente pelo seu Id
        /// </summary>
        /// <param name="id">Id do tipo de usuário</param>
        /// <param name="tiposUsuarioAtualizado">Objeto onde está as informções atualizadas</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult AtualizarPorId(int id, TiposUsuario tiposUsuarioAtualizado)
        {
            TiposUsuario tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(id);

            if (tipoUsuarioBuscado == null)
            {
                return NotFound(
                    new
                    {
                        mensagem = "Esse tipo de usuário não existe ou algo deu errado!",
                        erro = true
                    });
            }

            try
            {
                _tipoUsuarioRepository.Atualizar(id, tiposUsuarioAtualizado);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra um novo tipo de usuário
        /// </summary>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "administrador")]
        [HttpPost]
        public IActionResult Cadastrar(TiposUsuario novoTipoUsuario)
        {
            if (novoTipoUsuario != null)
            {
                try
                {
                    _tipoUsuarioRepository.Cadastrar(novoTipoUsuario);
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
                    mensagem = "Campo vazio!",
                    erro = true
                });
        }

        /// <summary>
        /// Deleta um tipo de usuário existente
        /// </summary>
        /// <param name="id">id do tipo de usuário que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// ex: http://localhost:5000/api/tiposUsuario/excluir/1
        [HttpDelete("id")]
        public IActionResult Deletar(int id)
        {
            TiposUsuario tipoUsuarioBuscado = _tipoUsuarioRepository.BuscarPorId(id);

            if (tipoUsuarioBuscado != null)
            {
                try
                {
                    _tipoUsuarioRepository.Deletar(id);
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
