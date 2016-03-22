using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParmezaniUniversidade.ViewModel
{
    public class InscricaoDataGrupo
    {
        [DataType(DataType.Date)]
        public DateTime? InscricaoData { get; set; }
        public int contadorAlunos { get; set; }
    }
}