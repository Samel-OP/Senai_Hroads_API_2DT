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
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
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
                return Ok(_usuarioRepository.Listar());
            }
            catch (Exception excep)
            {

                return BadRequest(excep);
            }
        }


        /// <summary>
        /// Lista um usuário pelo seu Id
        /// </summary>
        /// <returns>Um usuário e um status code.</returns>
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);


            if (usuarioBuscado == null)
            {
                return NotFound(
                    new
                    {
                        mensagem = "Esse usuário não existe ou algo deu errado!",
                        erro = true
                    });
            }

            try
            {
                return Ok(usuarioBuscado);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Atualiza um usuário existente pelo seu Id
        /// </summary>
        /// <param name="id">Id do usuário</param>
        /// <param name="usuarioAtualizado">Objeto onde está as informções atualizadas</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult AtualizarPorId(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);


            if (usuarioBuscado == null)
            {
                return NotFound(
                    new
                    {
                        mensagem = "Esse usuário não existe ou algo deu errado!",
                        erro = true
                    });
            }

            try
            {
                _usuarioRepository.Atualizar(id, usuarioAtualizado);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {

            if (novoUsuario != null)
            {
                try
                {
                    _usuarioRepository.Cadastrar(novoUsuario);
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
        /// Deleta um usuário existente
        /// </summary>
        /// <param name="id">id do usuário que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        /// ex: http://localhost:5000/api/usuario/excluir/2
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);

            if (usuarioBuscado != null)
            {
                try
                {
                    _usuarioRepository.Deletar(id);
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
