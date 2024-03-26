import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Plano } from '../model/plano';

@Injectable({
  providedIn: 'root'
})
export class PlanoService {

  private url = "https://localhost:7047/api/Plano"

  constructor(private http: HttpClient) { }

  public obterPlanos() : Observable<Plano> {
    return this.http.get<Plano>(`${this.url}`);
  }
}
