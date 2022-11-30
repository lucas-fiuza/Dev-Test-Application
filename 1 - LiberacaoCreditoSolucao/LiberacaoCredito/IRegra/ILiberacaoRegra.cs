using LiberacaoCredito.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberacaoCredito.IRegra
{
    public interface ILiberacaoRegra
    {
        public ResultadoLiberacao VerificaLiberacaoCredito(RequisicaoLiberacao item);
    }
}
