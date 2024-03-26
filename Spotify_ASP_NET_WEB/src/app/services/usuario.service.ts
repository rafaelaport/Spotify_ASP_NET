import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from '../model/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  private url = "https://localhost:7047/api/User"

  constructor(private http: HttpClient) { }

  public autenticar(email:String, senha: String) : Observable<Usuario> {
    return this.http.post<Usuario>(`${this.url}/login`, {
      email:email,
      senha:senha
    });
  }

  public criarUsuario(nome: String, email:String, senha: String, dataNascimento: String, plano: String) : Observable<Usuario> {
    return this.http.post<Usuario>(`${this.url}`, {
      nome: nome,
      email: email,
      senha: senha,
      dataNascimento: dataNascimento,
      plano: plano
    });
  }

}