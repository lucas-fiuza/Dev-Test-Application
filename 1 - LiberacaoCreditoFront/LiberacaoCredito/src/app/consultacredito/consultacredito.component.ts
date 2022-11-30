import { Component, OnInit, ɵɵsetComponentScope } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators, AbstractControl } from '@angular/forms';
import { ConsultacreditoService } from './consultacredito.service';
import { RequisicaoLiberacao, Resultado, ResultadoLiberacao, TipoCredito } from './Model/tipocredito.model';

@Component({
  selector: 'app-consultacredito',
  templateUrl: './consultacredito.component.html',
  styleUrls: ['./consultacredito.component.scss']
})
export class ConsultacreditoComponent implements OnInit {
  mostrarResultado: boolean = false;

  consultaForm: FormGroup = new FormGroup(
    {
      valorcredito: new FormControl('',[Validators.required]),
      tipocredito: new FormControl('',[Validators.required]),
      quantidadeparcelas: new FormControl('',[Validators.required]),
      datavencimento: new FormControl('',[Validators.required])
    }
  );

  tipoCredito: TipoCredito[] = [];
  resultadoConsulta: Resultado = new Resultado();
  
  constructor(
    private consultaCreditoService: ConsultacreditoService
  ) { }

  ngOnInit(): void {
    this.carregarListaTipoCredito();
  }

  validaCampoValorCredito(): boolean {
    return !this.consultaForm.controls["valorcredito"].valid;
  }

  onSubmit(){
    console.log(this.consultaForm);
    if(this.consultaForm.valid)
    {
      let valores: RequisicaoLiberacao = this.consultaForm.value;
      this.consultaCreditoService.consultaSolicitacaoCredito(valores).subscribe(
        success => {
          this.resultadoConsulta = success as Resultado;
          this.mostrarResultado = true;
        },
        error => console.log(error),
        () => {
        }
      );
    }
  }
  carregarListaTipoCredito()
  {
    this.consultaCreditoService.retornaListaCredito().subscribe(res => {
      this.tipoCredito = res as TipoCredito[];
    });
  }

}
