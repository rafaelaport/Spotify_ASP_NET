import { Component } from '@angular/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import {  MatDialog } from '@angular/material/dialog';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { UsuarioService } from '../services/usuario.service';
import { Router } from '@angular/router';
import { PlanoService } from '../services/plano.service';
import { Cartao } from '../model/cartao';
import { DialogElementsExampleDialogComponent } from '../core/dialog-elements-example-dialog/dialog-elements-example-dialog.component';

@Component({
  selector: 'app-usuario',
  standalone: true,
  imports: [MatSelectModule, 
            MatFormFieldModule, 
            MatInputModule, 
            FormsModule, 
            ReactiveFormsModule, 
            CommonModule, 
            MatButtonModule],
  templateUrl: './usuario.component.html',
  styleUrl: './usuario.component.css'
})
export class UsuarioComponent {
  nome = new FormControl('', [Validators.required]);
  email = new FormControl('', [Validators.required, Validators.email]);
  senha = new FormControl('', [Validators.required]);
  dataNascimento = new FormControl('');
  plano = new FormControl('', [Validators.required]);
  cartao = new FormControl('', [Validators.required]);
  limite = new FormControl('', [Validators.required]);
  errorMessage = '';
  planosCadastrados: any;

  constructor(private usuarioService: UsuarioService,
    private planoService: PlanoService,
    private router: Router,
    public dialog: MatDialog) {

  }

  ngOnInit() {
    this.obterPlanos();
  }

  public obterPlanos() {
    this.planoService.obterPlanos().subscribe(
      data => {

        this.planosCadastrados = data;
      }
    );
  }

  public criarUsuario() {
    if (this.nome.invalid || this.email.invalid || this.senha.invalid || this.dataNascimento.invalid || this.plano.invalid || this.cartao.invalid) {
      return;
    }

    let nomeValue = this.nome.getRawValue() as String;
    let emailValue = this.email.getRawValue() as String;
    let senhaValue = this.senha.getRawValue() as String;
    let dataNascientoValue = this.dataNascimento.getRawValue() as String;
    let planoValue = this.plano.getRawValue() as String;
    let cartaoValue = this.cartao.getRawValue() as String;
    let limiteValue = this.limite.getRawValue() as String;

    this.usuarioService.criarUsuario(nomeValue, emailValue, senhaValue, dataNascientoValue, planoValue, cartaoValue, limiteValue).subscribe(
      data => {
        if (data) {
          this.openDialog();
        }
      },
      (error): any => {
        if (error.error) {
          this.errorMessage = error.error.error;
        }
      });
  } 

  openDialog() {
    this.dialog.open(DialogElementsExampleDialogComponent);
  }

}
