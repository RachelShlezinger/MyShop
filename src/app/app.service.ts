import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor(private _http: HttpClient) { }

  baseUrl = 'http://localhost:58850/api/Home'

  getShop(filter?: string): Observable<any> {
    const urlFilter = filter ? `?filter=${filter}` : '';
    return this._http.get<any>(`${this.baseUrl}/shop${urlFilter}`);
  }
}
