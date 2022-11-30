using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberacaoCredito.Entidades
{
    public class ResultadoLiberacao
    {
        public string StatusCredito { get; set; }
        public double TotalComJuros { get; set; }
        public double ValorJuros { get; set; }
    }
}
