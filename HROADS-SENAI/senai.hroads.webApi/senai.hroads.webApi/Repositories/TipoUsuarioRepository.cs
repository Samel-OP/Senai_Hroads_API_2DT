using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi_.Contexts;
using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF core
        /// </summary>
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado)
        {
            TiposUsuario tiposUsuarioBuscado = BuscarPorId(id);

            if (tipoUsuarioAtualizado.tituloTipoUsuario != null)
            {
                tiposUsuarioBuscado.tituloTipoUsuario = tipoUsuarioAtualizado.tituloTipoUsuario;
            }

            ctx.TiposUsuario.Update(tiposUsuarioBuscado);

            ctx.SaveChanges();
        }

        public TiposUsuario BuscarPorId(int id)
        {
            return ctx.TiposUsuario.FirstOrDefault(e => e.idTipoUsuario == id);
        }

        public void Cadastrar(TiposUsuario novoTipoUsuario)
        {
            ctx.TiposUsuario.Add(novoTipoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TiposUsuario tiposUsuarioBuscado = BuscarPorId(id);

            ctx.TiposUsuario.Remove(tiposUsuarioBuscado);

            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return ctx.TiposUsuario.ToList();
        }
    }
}
