import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';

export class Usuario {
  constructor
  ( 
    public usuId: number, 
    public nombre: string,
    public apellido: string
  ){}
}

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,    
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
