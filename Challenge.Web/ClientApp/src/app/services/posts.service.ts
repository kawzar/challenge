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
    return this.http.post<Post>(`${this.baseUrl}SavePost`, post);
  }

  public deletePost(id: number){
    return this.http.delete(this.baseUrl + "DeletePost/" + id)
  }
}
