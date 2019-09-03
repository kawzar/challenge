import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  login(username: string, password: string) {
    return this.http.post<any>('/api/users/authenticate/', { username: username, password: password })
      .pipe(
        map(result => {
          localStorage.setItem('loggedUser', result.id.toString());
          return true;
        })
      );
  }

  register(username: string, password: string){
    return this.http.post('/api/users/register', {username: username, password: password});
  }

  logout() {
    localStorage.removeItem('loggedUser');
  }

  public get loggedIn(): boolean {
    return (localStorage.getItem('loggedUser') !== null);
  }

  public get loggedUserId(): number {
    return +localStorage.getItem('loggedUser');
  }
}
