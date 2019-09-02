import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/interfaces/post';
import { PostsService } from 'src/app/services/posts.service';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.scss']
})
export class PostListComponent implements OnInit {

  constructor(private postsService: PostsService) { }

  posts: Post[] = [];

  ngOnInit() {
    console.log("hola");
    this.postsService.getAll().subscribe(result => this.posts = result);
  }

}
