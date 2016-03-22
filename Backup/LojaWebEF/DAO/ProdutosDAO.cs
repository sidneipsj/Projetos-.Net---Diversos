using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class ProdutosDAO
    {
        private EntidadesContext contexto;

        public ProdutosDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adiciona(Produto produto)
        {
            
        }

        public void Remove(Produto produto)
        {
            
        }

        public void Atualiza(Produto produto)
        {
            
        }

        public Produto BuscaPorId(int id)
        {
            return new Produto();
        }

        public IEnumerable<Produto> Lista()
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> ProdutosComPrecoMaiorDoQue(decimal? preco)
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> ProdutosDaCategoria(string nomeCategoria)
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> ProdutosDaCategoriaComPrecoMaiorDoQue(decimal? preco, string nomeCategoria)
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> ListaPaginada(int paginaAtual)
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> BuscaPorPrecoCategoriaENome(decimal? preco, string nomeCategoria, string nome)
        {
            return new List<Produto>();
        }
    }
}