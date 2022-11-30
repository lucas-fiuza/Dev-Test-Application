import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { first, Observable } from 'rxjs';
import { RequisicaoLiberacao, TipoCredito } from './Model/tipocredito.model';

@Injectable({
  providedIn: 'root'
})
export class ConsultacreditoService {

  constructor(
    private http: HttpClient
  ) {}

  retornaListaCredito(){
    return this.http.get("http://localhost:5000/ListaCredito").pipe(first());
  }

  consultaSolicitacaoCredito(item: RequisicaoLiberacao)
  {
    return this.http.post("http://localhost:5000/ConsultaCredito",item).pipe(first());
  }
}
