import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/interfaces/post';
import { PostsService } from 'src/app/services/posts.service';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.scss']
})
export class AddComponent implements OnInit {

  post: Post = {Id: 0, Title: "", Content: "", Author:{Id: 1, Username:""}};
  constructor(private postsService:PostsService) { }

  ngOnInit() {
  }

  savePost($event){
    $event.preventDefault();
    console.log("save post");
    this.postsService.savePost(this.post).subscribe(result => console.log("saved!"));
  }
}
