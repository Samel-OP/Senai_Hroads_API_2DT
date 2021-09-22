using Microsoft.EntityFrameworkCore;
using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Habilidade habilidadeAtualizada)
        {
            Habilidade habilidadeBuscada = ctx.Habilidade.Find(id);

            if (habilidadeAtualizada.nomeHabilidade != null)
            {
                habilidadeBuscada.nomeHabilidade = habilidadeAtualizada.nomeHabilidade;
            }

            ctx.Habilidade.Update(habilidadeBuscada);

            ctx.SaveChanges();
        }

        public Habilidade BuscarPorId(int id)
        {
            return ctx.Habilidade.FirstOrDefault(e => e.idHabilidade == id);
        }

        public void Cadastrar(Habilidade novaHabilidade)
        {
            ctx.Habilidade.Add(novaHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Habilidade habilidadeBuscada = BuscarPorId(id);

            ctx.Habilidade.Remove(habilidadeBuscada);

            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidade.Include(h => h.tiposHabilidade).ToList();
        }
    }
}
