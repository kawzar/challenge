import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/interfaces/post';
import { PostsService } from 'src/app/services/posts.service';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.scss']
})
export class AddComponent implements OnInit {

  post: Post = {id: 0, title: "", content: "", author:{id: 0, username:"", password:""}};
  constructor(private postsService:PostsService, private router: Router, private auth: AuthService) { }

  ngOnInit() {
  }

  savePost($event){
    $event.preventDefault();
    console.log("save post");
    this.post.author.id = this.auth.loggedUserId;
    this.postsService.savePost(this.post).subscribe(result =>  this.router.navigate(['post-list']));
  }
}
