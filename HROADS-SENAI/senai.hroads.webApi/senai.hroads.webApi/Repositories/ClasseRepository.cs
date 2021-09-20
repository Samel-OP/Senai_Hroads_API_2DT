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
    public class ClasseRepository : IClasseRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int idClasse, Classe classeAtualizada)
        {
            Classe classeBuscada = ctx.Classe.Find(idClasse);

            if (classeAtualizada.nomeClasse != null)
            {
                classeBuscada.nomeClasse = classeAtualizada.nomeClasse;
            }

            ctx.Classe.Update(classeBuscada);

            ctx.SaveChanges();
        }

        public void Cadastrar(Classe novaClasse)
        {
            ctx.Classe.Add(novaClasse);

            ctx.SaveChanges();
        }

        public void Deletar(int idClasse)
        {
            Classe classeBuscada = ListarPorId(idClasse);

            ctx.Classe.Remove(classeBuscada);

            ctx.SaveChanges();
        }

        public List<Classe> Listar()
        {
            return ctx.Classe.ToList();
        }

        public Classe ListarPorId(int idClasse)
        {
            return ctx.Classe.FirstOrDefault(e => e.idClasse == idClasse);
        }
    }
}
