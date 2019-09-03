import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/interfaces/post';
import { PostsService } from 'src/app/services/posts.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.scss']
})
export class AddComponent implements OnInit {

  post: Post = {id: 0, title: "", content: "", author:{id: 1, username:""}};
  constructor(private postsService:PostsService, private router: Router) { }

  ngOnInit() {
  }

  savePost($event){
    $event.preventDefault();
    console.log("save post");
    this.postsService.savePost(this.post).subscribe(result =>  this.router.navigate(['post-list']));
  }
}
