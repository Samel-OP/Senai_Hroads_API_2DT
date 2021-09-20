using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using senai.hroads.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        //instância da context para que possemos acessar os atributos e métodos da mesma
        HroadsContext context = new HroadsContext();

        public void Atualizar(int id, Personagem personagemAtualizado)
        {
            //busca um personagem pelo id e atribui a personagemBuscado
            Personagem personagemBuscado = BuscarPorId(id);

            //verifica se se personagemBuscado está vazio
            if (personagemBuscado != null)
            {
                //personagemBuscado recebe as propriedades do objeto passo 
                personagemBuscado = personagemAtualizado;

                //comando que atualiza
                context.Personagem.Update(personagemAtualizado);
            }
            
            // salva todas as mudanças
            context.SaveChanges();
        }

        public Personagem BuscarPorId(int id)
        {
            // procura um personagem que tenha um idPersongem idêntico ao id passado
            return context.Personagem.FirstOrDefault(e => e.idPersonagem == id);
        }

        public void Cadastrar(Personagem novoPersonagem)
        {
            //verifica se o objeto passado não está vazio
            if (novoPersonagem != null)
            {
                //adiciona um novo personagem 
                context.Personagem.Add(novoPersonagem);

                //salva as alterações
                context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            //verifica se há algum registro com o id passado e atribui
            Personagem personagemBuscado = BuscarPorId(id);

            //deleta o registro pelo id passado
            context.Personagem.Remove(personagemBuscado);

            // salva as alterações
            context.SaveChanges();
        }

        public List<Personagem> Listar()
        {
            //retorna uma lista de personagens
            return context.Personagem.ToList();
        }
    }
}
