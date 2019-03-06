import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  baseUrl = 'http://localhost:5000';
  member: any[];

  constructor(private http: HttpClient) { }

  register() {
    return this.http.post(this.baseUrl)
  }
}
