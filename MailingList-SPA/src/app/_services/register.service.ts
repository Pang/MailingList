import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  baseUrl = 'http://localhost:5000';
  member: any[];

  register(){
    return this.http.
  }
  constructor() { }
}
