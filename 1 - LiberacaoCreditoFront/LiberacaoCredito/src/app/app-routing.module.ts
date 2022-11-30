import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConsultacreditoComponent } from './consultacredito/consultacredito.component';

const routes: Routes = [
  { path: '', redirectTo: '/consultacredito', pathMatch: 'full' },
  { path: 'consultacredito', component: ConsultacreditoComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
