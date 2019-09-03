import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Post } from '../interfaces/post';

@Injectable({
  providedIn: 'root'
})

export class PostsService {
  baseUrl: string = "api/Posts/"

  constructor(private http: HttpClient) { }

  public getAll(): Observable<Post[]>{
    return this.http.get<Post[]>(`${this.baseUrl}AllPosts`);
  }

  public savePost(post: Post){
    let httpOptions = {
      headers: new HttpHeaders({ 'Authorization': localStorage.getItem('jwtToken') })
    };
    
    return this.http.post<Post>(`${this.baseUrl}/`, post, httpOptions);
  }

  public deletePost(id: number){
    const httpOptions = {
      headers: new HttpHeaders({
        'Authorization': localStorage.getItem('jwtToken')
      })
    };

    return this.http.delete('/api/users/' + id, httpOptions)
  }
}
