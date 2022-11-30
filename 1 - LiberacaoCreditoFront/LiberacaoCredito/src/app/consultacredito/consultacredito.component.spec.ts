import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultacreditoComponent } from './consultacredito.component';

describe('ConsultacreditoComponent', () => {
  let component: ConsultacreditoComponent;
  let fixture: ComponentFixture<ConsultacreditoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConsultacreditoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultacreditoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
