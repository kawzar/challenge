import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/interfaces/post';
import { PostsService } from 'src/app/services/posts.service';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.scss']
})
export class PostListComponent implements OnInit {

  constructor(private postsService: PostsService, private auth: AuthService) { }

  posts: Post[] = [];
  searchText : string;
  userLoggedIn: boolean;

  ngOnInit() {
    this.postsService.getAll().subscribe(result => this.posts = result);
    this.userLoggedIn = this.auth.loggedIn;
  }

  delete($event, id: number){
    this.postsService.deletePost(id).subscribe(result => this.ngOnInit);
  }
}
