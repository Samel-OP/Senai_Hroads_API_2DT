using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi_.Interfaces;
using senai.hroads.webApi_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Controllers
{
    //resposta da API em json
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class ClassesControllers : ControllerBase
    {
        private IClasseRepository _classeRepository { get; set; }

        public ClassesControllers()
        {
            _classeRepository = new ClasseRepository();
        }


        //GET
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_classeRepository.Listar());
            }
            catch (Exception excep)
            {

               return BadRequest(excep);
            }
        }
    }
}
