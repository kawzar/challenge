import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/interfaces/user';
import { AuthService } from 'src/app/services/auth.service';
import { Router } from '@angular/router';
import { AlertService } from 'src/app/services/alert.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  user: User = {id: 0, username:"", password:""};

  constructor(private auth: AuthService, private router: Router, private alertService: AlertService) { }

  ngOnInit() {
  }

  login($event){
    $event.preventDefault();
    this.auth.login(this.user.username, this.user.password).subscribe(
      data => {
          this.router.navigate(['post-list']);
      },
      error => {
          this.alertService.error(error);
      });
  }
}
