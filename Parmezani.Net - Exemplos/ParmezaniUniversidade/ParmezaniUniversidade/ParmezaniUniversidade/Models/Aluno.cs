using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmezaniUniversidade.Models
{
    public class Aluno
    {

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataInscricao { get; set; }
        public string Secret { get; set; }
        public virtual ICollection<Inscricao> Inscricoes { get; set; }

    }
}