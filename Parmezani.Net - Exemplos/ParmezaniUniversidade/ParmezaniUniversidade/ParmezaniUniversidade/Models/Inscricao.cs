using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmezaniUniversidade.Models
{

    public enum Grade
    {
        A,B,C,D,F
    }

    public class Inscricao
    {
        public int InscricaoID { get; set; }
        public int CursoID { get; set; }
        public int AlunoID { get; set; }
        public Grade? Grade { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Aluno Aluno { get; set; }


    }
}