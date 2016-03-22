using ParmezaniUniversidade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParmezaniUniversidade.DAL
{
    public class UniversidadeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Contexto>
    {
        protected override void Seed(Contexto context)
        {
            var alunos = new List<Aluno>
            {
                new Aluno{Nome="Carson",Sobrenome="Alexander",DataInscricao=DateTime.Parse("2005-09-01")},
                new Aluno{Nome="Meredith",Sobrenome="Alonso",DataInscricao=DateTime.Parse("2002-09-01")},
                new Aluno{Nome="Arturo",Sobrenome="Anand",DataInscricao=DateTime.Parse("2003-09-01")},
                new Aluno{Nome="Gytis",Sobrenome="Barzdukas",DataInscricao=DateTime.Parse("2002-09-01")},
                new Aluno{Nome="Yan",Sobrenome="Li",DataInscricao=DateTime.Parse("2002-09-01")},
                new Aluno{Nome="Peggy",Sobrenome="Justice",DataInscricao=DateTime.Parse("2001-09-01")},
                new Aluno{Nome="Laura",Sobrenome="Norman",DataInscricao=DateTime.Parse("2003-09-01")},
                new Aluno{Nome="Nino",Sobrenome="Olivetto",DataInscricao=DateTime.Parse("2005-09-01")}
            };

            alunos.ForEach(s => context.Alunos.Add(s));
            context.SaveChanges();
            
            var cursos = new List<Curso>
            {
                new Curso{CursoID=1050,Titulo="Chemistry",Creditos=3,},
                new Curso{CursoID=4022,Titulo="Microeconomics",Creditos=3,},
                new Curso{CursoID=4041,Titulo="Macroeconomics",Creditos=3,},
                new Curso{CursoID=1045,Titulo="Calculus",Creditos=4,},
                new Curso{CursoID=3141,Titulo="Trigonometry",Creditos=4,},
                new Curso{CursoID=2021,Titulo="Composition",Creditos=3,},
                new Curso{CursoID=2042,Titulo="Literature",Creditos=4,}
            };
            
            cursos.ForEach(s => context.Cursos.Add(s));
            context.SaveChanges();
            
            var inscricoes = new List<Inscricao>
            {
                new Inscricao{AlunoID=1,CursoID=1050,Grade=Grade.A},
                new Inscricao{AlunoID=1,CursoID=4022,Grade=Grade.C},
                new Inscricao{AlunoID=1,CursoID=4041,Grade=Grade.B},
                new Inscricao{AlunoID=2,CursoID=1045,Grade=Grade.B},
                new Inscricao{AlunoID=2,CursoID=3141,Grade=Grade.F},
                new Inscricao{AlunoID=2,CursoID=2021,Grade=Grade.F},
                new Inscricao{AlunoID=3,CursoID=1050},
                new Inscricao{AlunoID=4,CursoID=1050,},
                new Inscricao{AlunoID=4,CursoID=4022,Grade=Grade.F},
                new Inscricao{AlunoID=5,CursoID=4041,Grade=Grade.C},
                new Inscricao{AlunoID=6,CursoID=1045},
                new Inscricao{AlunoID=7,CursoID=3141,Grade=Grade.A},
            };
            inscricoes.ForEach(s => context.Inscricoes.Add(s));
            context.SaveChanges();
        }
    }
}