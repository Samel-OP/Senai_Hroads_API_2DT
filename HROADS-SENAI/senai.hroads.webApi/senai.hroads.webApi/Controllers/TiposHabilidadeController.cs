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
    public class TiposHabilidadeController : ControllerBase
    {
        private ITipoHabilidadeRepository _tiposHabilidadeRepository { get; set; }

        public TiposHabilidadeController()
        {
            _tiposHabilidadeRepository = new TipoHabilidadeRepository();
        }


        //TESTADO
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_tiposHabilidadeRepository.Listar());
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }
        }

        //TESTADO   
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            TiposHabilidade thAchada = _tiposHabilidadeRepository.BuscarPorId(id);


            if (thAchada == null)
            {
                return BadRequest(
                    new
                    {
                        mensagem = "Nenhuma TiposHabilidade possui o id passado",
                        erro = true
                    }
                    );
            }

            try
            {
                return Ok(_tiposHabilidadeRepository.BuscarPorId(id));
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }
        }

        //TESTADO
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(TiposHabilidade novaTiposHabilidade)
        {
            if (novaTiposHabilidade == null)
            {
                return NotFound("A Classe habilidade passada falta algum argumento ou não foi passado ! ");
            }

            try
            {
                _tiposHabilidadeRepository.Cadastrar(novaTiposHabilidade);
                return StatusCode(201);
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }
        }

        //TESTADO
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, TiposHabilidade chAtualizada)
        {
            TiposHabilidade tpAchada = _tiposHabilidadeRepository.BuscarPorId(id);

            if (tpAchada == null)
            {

                return BadRequest(
                    new
                    {
                        mensagem = "Tipo habilidade passada não existe !",
                        erro = true
                    }

                    );
            }

            try
            {
                _tiposHabilidadeRepository.Atualizar(id, chAtualizada);
                return Ok();
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }

        }

        //TESTADO
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            TiposHabilidade tpAchada = _tiposHabilidadeRepository.BuscarPorId(id);

            if (tpAchada == null)
            {

                return BadRequest(
                    new
                    {
                        mensagem = "tipo habilidade passada não existe !",
                        erro = true
                    }

                    );
            }


            try
            {
                _tiposHabilidadeRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception execp)
            {
                return BadRequest(execp);
            }
        }
    }
}
