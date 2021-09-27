import { Component } from '@angular/core';
import { AppService } from './app.service'
import { IUsuario } from './usuarios'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})



export class AppComponent {    
  IUsuario = [];
  constructor(private api:AppService){}
  
  ngOnInit() 
  {
    this.api.getList().subscribe(data => {      
      console.log(data);
    })
  }
}
