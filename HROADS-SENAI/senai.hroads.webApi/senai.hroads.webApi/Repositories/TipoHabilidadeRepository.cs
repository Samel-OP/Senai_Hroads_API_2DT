using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, TiposHabilidade tipoHabilidadeAtualizado)
        {
            TiposHabilidade tiposHabilidadeBuscado = BuscarPorId(id);

            if (tipoHabilidadeAtualizado.tituloTipoHabilidade != null)
            {
                tiposHabilidadeBuscado.tituloTipoHabilidade = tipoHabilidadeAtualizado.tituloTipoHabilidade;
            }

            ctx.TipoHabilidade.Update(tiposHabilidadeBuscado);

            ctx.SaveChanges();
        }

        public TiposHabilidade BuscarPorId(int id)
        {
            return ctx.TipoHabilidade.FirstOrDefault(e => e.idTipoHabilidade == id);
        }

        public void Cadastrar(TiposHabilidade novoTipoHabilidade)
        {
            ctx.TipoHabilidade.Add(novoTipoHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TiposHabilidade tipoHabilidadeBuscado = BuscarPorId(id);

            ctx.TipoHabilidade.Remove(tipoHabilidadeBuscado);

            ctx.SaveChanges();
        }

        public List<TiposHabilidade> Listar()
        {
            return ctx.TipoHabilidade.ToList();
        }
    }
}
