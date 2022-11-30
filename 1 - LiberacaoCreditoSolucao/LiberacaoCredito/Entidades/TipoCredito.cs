using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiberacaoCredito.Entidades
{
    public class TipoCredito
    {
        public double Consignado 
        {
            get 
            {
                return 0.01;
            }
        }

        public double Direto
        {
            get
            {
                return 0.02;
            }
        }

        public double Pessoa_Fisica
        {
            get
            {
                return 0.03;
            }
        }

        public double Pessoa_Juridica
        {
            get
            {
                return 0.05;
            }
        }

        public double Imobiliario
        {
            get
            {
                return 0.09;
            }
        }

    }
}
