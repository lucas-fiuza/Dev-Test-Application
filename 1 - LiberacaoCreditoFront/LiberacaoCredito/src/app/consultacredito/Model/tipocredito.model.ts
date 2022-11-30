export interface TipoCredito {
    value: string;
    viewValue: string;
  }

export interface RequisicaoLiberacao
{
    ValorCredito: number;
    TipoCredito: string;
    QuantidadeParcelas: number;
    DataVencimento: Date;
}

export interface ResultadoLiberacao
{
    statusCredito: string ;
    totalComJuros: number ;
    valorJuros: number ;
}

export class Resultado implements ResultadoLiberacao
{
  totalComJuros: number;
  valorJuros: number;
  statusCredito: string;
}