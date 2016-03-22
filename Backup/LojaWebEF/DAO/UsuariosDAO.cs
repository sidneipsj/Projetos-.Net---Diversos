using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class UsuariosDAO
    {
        private EntidadesContext contexto;

        public UsuariosDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adiciona(Usuario usuario)
        {

        }

        public void Remove(Usuario usuario)
        {

        }

        public void Atualiza(Usuario usuario)
        {

        }

        public Usuario BuscaPorId(int id)
        {
            return null;
        }

        public IEnumerable<Usuario> Lista()
        {
            return new List<Usuario>();
        }
    }
}