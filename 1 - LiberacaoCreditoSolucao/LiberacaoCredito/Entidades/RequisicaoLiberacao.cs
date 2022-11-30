using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberacaoCredito.Entidades
{
    public class RequisicaoLiberacao
    {
        public double ValorCredito { get; set; }
        public string TipoCredito { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
