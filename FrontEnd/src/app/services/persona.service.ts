import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { H001_Persona } from '../entity/H001_Persona';
import { H001_TipoDocumento } from '../entity/H001_TipoDocumento';
import { H001_Departamento } from '../entity/H001_Departamento';

@Injectable({
    providedIn: 'root'
  })
export class PersonaService {
    private apiUrl = 'https://localhost:44389/api/';

    constructor(
        private http: HttpClient
        ) {}

    insPersona(payload:H001_Persona): Observable<H001_Persona>{
        return this.http.post<H001_Persona>(this.apiUrl + 'H001_Paciente/InsertarPaciente',payload);
    }

    listTipoDocumento(option: number): Observable<H001_TipoDocumento[]>{
        return this.http.get<H001_TipoDocumento[]>(this.apiUrl + 'H001_TipoDocumento/ListarTipoDocumento?option='+ option)
    }
    
    listDepartamento(option: number): Observable<H001_Departamento[]>{
        return this.http.get<H001_Departamento[]>(this.apiUrl + 'H001_Ubigeo/ListarDepartamento?option='+ option)
    }

    listProvincia(option: number, codDep: string): Observable<H001_Departamento[]>{
        return this.http.get<H001_Departamento[]>(this.apiUrl + 'H001_Ubigeo/ListarProvincia/'+ codDep +'?option='+ option)
    }

    listDistrito(option: number, codDep: string, codDis: string): Observable<H001_Departamento[]>{
        return this.http.get<H001_Departamento[]>(this.apiUrl + 'H001_Ubigeo/ListarDistrito/'+ codDep + '/' + codDis +'?option='+ option)
    }
}