import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PostListComponent } from './components/post-list/post-list.component';
import { AddComponent } from './components/add/add.component';
import { LoginComponent } from './components/login/login.component';


const routes: Routes = [
  { path: 'post-list', component: PostListComponent },
  { path: 'add', component: AddComponent },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
