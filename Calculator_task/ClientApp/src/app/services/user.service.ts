import { Injectable } from '@angular/core';
import { UserViewModel } from '../models/UserVewModel';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';


@Injectable({
    providedIn: 'root'
})
export class UserService {

    baseURL: string;

    constructor(private http: HttpClient) {
        this.baseURL = 'https://localhost:44360/Conversion/';
    }

    add(user: UserViewModel){
        const url = this.baseURL + 'CalculateAdd';
        return this.http.post(url, user);
    }

    minus(user: UserViewModel) {
      const url = this.baseURL + 'CalculateMinus';
    return this.http.post(url, user);
  }

 

}
