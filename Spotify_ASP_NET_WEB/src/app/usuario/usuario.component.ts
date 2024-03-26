import { Component } from '@angular/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import { FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { UsuarioService } from '../services/usuario.service';
import { Router } from '@angular/router';
import { PlanoService } from '../services/plano.service';
import { Plano } from '../model/plano';
import { CartaoService } from '../services/cartao.service';
import { Cartao } from '../model/cartao';

@Component({
  selector: 'app-usuario',
  standalone: true,
  imports: [MatSelectModule, MatFormFieldModule, MatInputModule, FormsModule, ReactiveFormsModule, CommonModule, MatButtonModule],
  templateUrl: './usuario.component.html',
  styleUrl: './usuario.component.css'
})
export class UsuarioComponent {
  nome = new FormControl('', [Validators.required]);
  email = new FormControl('', [Validators.required, Validators.email]);
  senha = new FormControl('', [Validators.required]);
  dataNascimento = new FormControl('', [Validators.required]);
  plano = new FormControl('', [Validators.required]);
  cartao = new FormControl('', [Validators.required]);
  errorMessage = '';
  planosCadastrados: any;
  cartoesCadastrados: any;

  constructor(private usuarioService: UsuarioService, 
              private planoService: PlanoService, 
              private cartaoService: CartaoService,
              private router: Router) {

  }

  ngOnInit()
  {
    this.obterPlanos();
    this.obterCartoes();
  }

  public obterPlanos(){
    this.planoService.obterPlanos().subscribe(
      data => {
      
        this.planosCadastrados = data;
      }
    );
  }

  public obterCartoes(){
    this.cartaoService.obterCartoes().subscribe(
      data => {
      
         this.cartoesCadastrados = data;
        // console.log(this.cartoesCadastrados[0])
        // console.log(this.cartoesCadastrados[0].numero)
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

    // let dadosCartaoSelecionado: any[] = [];

    // this.cartoesCadastrados.forEach(element => {
    //   if(element.id == cartaoValue)
    //     dadosCartaoSelecionado.push(element)
    // });

    this.usuarioService.criarUsuario(nomeValue, emailValue, senhaValue, dataNascientoValue, planoValue).subscribe(
      {
        error: (e) => {
          if (e.error) {
            this.errorMessage = e.error.error;
          }
        }
      });


  }

}
