import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/interfaces/post';
import { PostsService } from 'src/app/services/posts.service';
import { AuthService } from 'src/app/services/auth.service';
import { AlertService } from 'src/app/services/alert.service';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.scss']
})
export class PostListComponent implements OnInit {

  constructor(private postsService: PostsService, private auth: AuthService, private alertService: AlertService) { }

  posts: Post[] = [];
  searchText : string;
  userLoggedIn: boolean;

  ngOnInit() {
    this.postsService.getAll().subscribe(result => this.posts = result);
    this.userLoggedIn = this.auth.loggedIn;
  }

  delete($event, id: number){
    $event.preventDefault();
    if(confirm("Are you sure you want to delete this post?")) {
    this.postsService.deletePost(id).subscribe(
      data => {
          this.ngOnInit();
      },
      error => {
          this.alertService.error(error);
      });
    }
  }

  logout($event){
    $event.preventDefault();
    this.auth.logout();

    this.userLoggedIn = this.auth.loggedIn;
  }
}
