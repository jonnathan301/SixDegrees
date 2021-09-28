export class Usuario {
     usuId: number;
     nombre: string;
     apellido: string;

     constructor(usuarioResponse : any) {
          this.usuId = usuarioResponse.usuId;
          this.nombre = usuarioResponse.nombre;
          this.apellido = usuarioResponse.apellido;
     }
}
  