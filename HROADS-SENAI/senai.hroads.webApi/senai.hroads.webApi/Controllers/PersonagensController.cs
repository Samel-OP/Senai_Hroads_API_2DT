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
    [Produces("application/json")] //definindo que a resposta da API será em json
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        private IPersonagemRepository _personagemRepository { get; set; }

        /// <summary>
        /// construtor que atribui os métodos a interface
        /// </summary>
        public PersonagensController()
        {
            _personagemRepository = new PersonagemRepository();
        }


 
        [Authorize(Roles = "2")]
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_personagemRepository.Listar());
            }
            catch (Exception execp)
            {
                return BadRequest(execp);
            }
        }

        //TESTADO
        [Authorize(Roles = "1, 2")]
        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            Personagem personagemAchadao = _personagemRepository.BuscarPorId(id);

            if (personagemAchadao != null )
            {
                try
                {
                    return Ok(personagemAchadao);
                }
                catch (Exception execp)
                {

                    return BadRequest(execp);
                }
            }

            return NotFound(
                new
                {
                    mensagem = "O id passado não fui encontrado !",
                    erro = true
                }
                );
        }

        //TESTADO 
        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Cadastrar(Personagem novoPersonagem)
        {
            if (novoPersonagem != null)
            {
                try
                {
                    _personagemRepository.Cadastrar(novoPersonagem);
                    return StatusCode(201);
                }
                catch (Exception excep)
                {
                    return BadRequest(excep);
                }
            }

            return NoContent();
        }

        //TESTADO
        [Authorize(Roles = "2")]
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Personagem personagemAtualizado)
        {
            Personagem personagemBuscado = _personagemRepository.BuscarPorId(id);

            if (personagemAtualizado == null)
            {
                return NotFound(
                    new
                    {
                        mensagem = "Id não encontrado !",
                        erro = true
                    }
                    );
            }


            try
            {
                _personagemRepository.Atualizar(id, personagemAtualizado);
                return StatusCode(200);
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }

        }

        //TESTADO
        [Authorize(Roles = "2")]
        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            Personagem personagemBuscado = _personagemRepository.BuscarPorId(id);

            if (personagemBuscado == null)
            {
                return NotFound("Personagem não encontrado !");
            }

            try
            {
                _personagemRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }
        }

    }
}
