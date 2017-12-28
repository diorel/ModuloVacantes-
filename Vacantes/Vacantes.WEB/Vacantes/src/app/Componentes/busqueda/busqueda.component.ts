import { Component } from '@angular/core';

@Component({
  selector: 'app-busqueda',
  templateUrl: './busqueda.component.html',
  styleUrls: ['./busqueda.component.css']
})
export class BusquedaComponent {

    Vacantes = [
        { Clave: 'Ingeniero', Escolaridad: 'Ingenieria', Experiencia: '2 años', Genero: 'Indistinto' },
        { Clave: 'Desarrollo', Escolaridad: 'Ingenieria', Experiencia: '2 años', Genero: 'Indistinto' },
        { Clave: 'Mantenimiento', Escolaridad: 'Ingenieria', Experiencia: '2 años', Genero: 'Indistinto' },
        { Clave: 'Sistemas', Escolaridad: 'Ingenieria', Experiencia: '2 años', Genero: 'Indistinto' }
    ]

    model1: any = {};
    model2: any = {};
    msg: string = '';
    hideupdate: boolean = true;
    Cambio: string = '';

    buscar(): void {
        this.Cambio = 'Vacantes encontradas';
    }
}
