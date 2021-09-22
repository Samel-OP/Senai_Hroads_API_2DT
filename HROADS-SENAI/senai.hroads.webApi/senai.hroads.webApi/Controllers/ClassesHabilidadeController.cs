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
    public class ClassesHabilidadeController : ControllerBase
    {
        private IClasseHabilidadeRepository _classeHabilidadeRepository { get; set; }

        public ClassesHabilidadeController()
        {
            _classeHabilidadeRepository = new ClasseHabilidadeRepository();
        }


        //TESTADO
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_classeHabilidadeRepository.Listar());
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }
        }

        //TESTADO   
        [HttpGet("{id}")]
        public IActionResult ListarPorId (int id)
        {
            ClasseHabilidade chAchada = _classeHabilidadeRepository.BuscarPorId(id);


            if (chAchada == null)
            {
                return BadRequest(
                    new
                    {
                        mensagem = "Nenhuma ClasseHabilidade possui o id passado",
                        erro = true
                    }
                    );
            }

            try
            {
                return Ok(_classeHabilidadeRepository.BuscarPorId(id));
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }
        }

        //TESTADO
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(ClasseHabilidade novaClasseHabilidade)
        {
            if (novaClasseHabilidade == null)
            {
               return NotFound("A Classe habilidade passada falta algum argumento ou não foi passado ! ");
            }

            try
            {
                _classeHabilidadeRepository.Cadastrar(novaClasseHabilidade);
                return StatusCode(201);
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }
        }

        //TESTADO
        [HttpPut("{id}")]
        public IActionResult  Atualizar(int id, ClasseHabilidade chAtualizada)
        {
            ClasseHabilidade chAchada = _classeHabilidadeRepository.BuscarPorId(id);

            if (chAchada == null)
            {

               return BadRequest(
                   new
                   {
                       mensagem = "Classe habilidade passada não existe !",
                       erro = true
                   }
                   
                   );
            }

            try
            {
                _classeHabilidadeRepository.Atualizar(id, chAtualizada);
                return Ok();
            }
            catch (Exception excep)
            {
                return BadRequest(excep);
            }
           
        }

        //TESTADO
        [HttpDelete("{id}")]
        public IActionResult Deletar (int id)
        {
            ClasseHabilidade chAchada = _classeHabilidadeRepository.BuscarPorId(id);

            if (chAchada == null)
            {

                return BadRequest(
                    new
                    {
                        mensagem = "Classe habilidade passada não existe !",
                        erro = true
                    }

                    );
            }


            try
            {
                _classeHabilidadeRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception execp)
            {
                return BadRequest(execp);
            }
        }

    }
}
