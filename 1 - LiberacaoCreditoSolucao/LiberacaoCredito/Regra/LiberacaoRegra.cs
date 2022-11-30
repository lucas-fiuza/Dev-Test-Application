using LiberacaoCredito.Entidades;
using LiberacaoCredito.IRegra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberacaoCredito.Regra
{
    public class LiberacaoRegra : ILiberacaoRegra
    {
        TipoCredito tipoCredito = new TipoCredito();

        public ResultadoLiberacao VerificaLiberacaoCredito(RequisicaoLiberacao item)
        {
            ResultadoLiberacao resultado = new ResultadoLiberacao();

            var prop = tipoCredito.GetType().GetProperty(item.TipoCredito);
            double percCredito = double.Parse(prop.GetValue(tipoCredito).ToString());


            resultado.ValorJuros = item.ValorCredito * percCredito;
            resultado.TotalComJuros = item.ValorCredito + resultado.ValorJuros;

            resultado.StatusCredito = ValidaValor(item.ValorCredito, item.TipoCredito);
            resultado.StatusCredito = resultado.StatusCredito == "Aprovado" ? ValidaParcela(item.QuantidadeParcelas) : resultado.StatusCredito;
            resultado.StatusCredito = resultado.StatusCredito == "Aprovado" ? ValidaDataVencimento(item.DataVencimento) : resultado.StatusCredito;


            return resultado;
        }

        private string ValidaValor(double valor, string tipocredito)
        {
            bool valido = true;

            valido = (valor > 0 && valor < 1000000);

            if(valido)
                valido = tipocredito == "Pessoa_Juridica" ? valor >= 15000 : valido;

            return valido ? "Aprovado" : "Recusado" ;
        }

        public string ValidaParcela(int parcelas)
        {
            return (parcelas >= 5 && parcelas <= 72) ? "Aprovado" : "Recusado";
        }

        public string ValidaDataVencimento(DateTime data)
        {
            int vlrDias = (int)data.Subtract(DateTime.Now).TotalDays;

            return (vlrDias >= 15 && vlrDias <= 40) ? "Aprovado" : "Recusado";
        }
    }
}
