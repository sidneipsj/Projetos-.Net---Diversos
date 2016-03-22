using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class VendasDAO
    {
        private EntidadesContext contexto;

        public VendasDAO(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public void Adiciona(Venda venda)
        {

        }

        public IEnumerable<Venda> Lista()
        {
            return new List<Venda>();
        }
    }
}