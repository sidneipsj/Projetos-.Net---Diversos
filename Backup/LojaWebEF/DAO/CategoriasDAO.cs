using LojaWebEF.Entidades;
using LojaWebEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class CategoriasDAO
    {
        private EntidadesContext contexto;

        public CategoriasDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adiciona(Categoria categoria)
        {
            
        }

        public void Remove(Categoria categoria)
        {

        }

        public void Atualiza(Categoria categoria)
        {

        }

        public Categoria BuscaPorId(int id)
        {
            return null;
        }

        public IEnumerable<Categoria> Lista()
        {
            return new List<Categoria>();
        }

        public IEnumerable<Categoria> BuscaPorNome(string nome)
        {
            return new List<Categoria>();
        }

        public IEnumerable<ProdutosPorCategoria> ListaNumeroDeProdutosPorCategoria()
        {
            return new List<ProdutosPorCategoria>();
        }
    }

}