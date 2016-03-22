using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginacaoAspNetMvcAjax.Models
{
    public class Contexto
    {
        public List<ClienteModel> Clientes
        {
            get
            {
                return new List<ClienteModel> 
                                            {
                                                new ClienteModel{Id=1, Nome="Diego Neves", Idade = 26},
                                                new ClienteModel{Id=2, Nome="Fulano Souza", Idade = 12},
                                                new ClienteModel{Id=3, Nome="Daniela Camargo", Idade = 22},
                                                new ClienteModel{Id=4, Nome="Luis Almeida", Idade = 21},
                                                new ClienteModel{Id=5, Nome="Caetano Lima", Idade = 24},
                                                new ClienteModel{Id=6, Nome="Luana Cabral", Idade = 15},
                                                new ClienteModel{Id=7, Nome="Juliano Pereira", Idade = 18},
                                                new ClienteModel{Id=8, Nome="Amaral Jorge", Idade = 17}
                                            };
            }
        }
    }
}