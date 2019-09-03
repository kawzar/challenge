import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/interfaces/user';
import { AuthService } from 'src/app/services/auth.service';
import { Router } from '@angular/router';
import { AlertService } from 'src/app/services/alert.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  user: User = {id: 0, username:"", password:""};

  constructor(private auth: AuthService, private router: Router, private alertService: AlertService) { }

  ngOnInit() {
  }

  register($event){
    $event.preventDefault();
    this.auth.register(this.user.username, this.user.password).subscribe(
      data => {
          this.router.navigate(['post-list']);
      },
      error => {
          this.alertService.error(error);
      });
  }
}
