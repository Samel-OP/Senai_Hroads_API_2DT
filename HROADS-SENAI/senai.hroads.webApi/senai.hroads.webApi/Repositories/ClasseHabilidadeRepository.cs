using System;
using System.Collections.Generic;
using senai.hroads.webApi_.Domains;
using System.Linq;
using System.Threading.Tasks;
using senai.hroads.webApi_.Interfaces;
using senai.hroads.webApi_.Contexts;
using Microsoft.EntityFrameworkCore;

namespace senai.hroads.webApi_.Repositories
{
    public class ClasseHabilidadeRepository : IClasseHabilidadeRepository
    {
        HroadsContext context = new HroadsContext();

        public void Atualizar(int id, ClasseHabilidade classeHabilidadeAtualizada)
        {
            ClasseHabilidade chAchado = BuscarPorId(id);

            if (chAchado != null)
            {
                chAchado = classeHabilidadeAtualizada;

                //atualiza a CH se ela tiver sido achada.
                context.ClasseHabilidade.Update(chAchado);

                //salva as alterações
                context.SaveChanges();
            }
        }

        public ClasseHabilidade BuscarPorId(int id)
        {
            // returnn o método que verifica se há alguma ch com o mesmo id passado
            return context.ClasseHabilidade.FirstOrDefault(e => e.idClasseHabilidade == id);
        }

        public void Cadastrar(ClasseHabilidade novaClasseHabilidade)
        {
            //cadastra uma nova classe habilidade
            context.ClasseHabilidade.Add(novaClasseHabilidade);

            //salva as alterações
            context.SaveChanges();
        }

        public void Deletar(int id)
        {
            //busca uma ch e verifica a atribui caso ela tenha sido achada
            ClasseHabilidade chAchado = BuscarPorId(id);

            //remove o registro pelo id passado
            context.ClasseHabilidade.Remove(chAchado);

            //salve as alterações
            context.SaveChanges();

        }

        public List<ClasseHabilidade> Listar()
        {
            //lista todas as ch's
            return context.ClasseHabilidade.Include(c => c.classe).Include(h => h.habilidade).ToList();
        }
    }
}
