import { Component } from '@angular/core';
import { AppService } from './app.service'
import { Usuario } from './usuarios'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})



export class AppComponent {    
  Usuarios = [];  

  constructor(private api:AppService){}
  
  getList() 
  {
    this.api.getList().subscribe(data => {  
      // show data     
      console.log(data);
      alert(data)
      this.Usuarios = data;   
      //let usuario = new Usuario(data);
      //console.log(usuario)
    })
  }
}
