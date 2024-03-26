import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cartao } from '../model/cartao';

@Injectable({
  providedIn: 'root'
})
export class CartaoService {

  private url = "https://localhost:7047/api/cartao"

  constructor(private http: HttpClient) { }

  public obterCartoes() : Observable<Cartao> {
    return this.http.get<Cartao>(`${this.url}`);
  }
}
