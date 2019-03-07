import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Member } from '../_models/Member';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  baseUrl = 'http://localhost:5000/api/users/';

  constructor(private http: HttpClient) { }

  signUp(member: Member) {
    return this.http.post<Member>(this.baseUrl + 'register', member);
  }
}
