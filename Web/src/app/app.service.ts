import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IUsuario } from './usuarios';

@Injectable({
  providedIn: 'root'
})

export class AppService {  


  private _url: string = 'https://localhost:5001/Usuario/GetList';

  constructor(private http: HttpClient){ }


   /** GET users from the server */ 
   getList() 
   {
      return this.http.get<IUsuario[]>(this._url)
   }
  
}
