import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PostListComponent } from './components/post-list/post-list.component';
import { AddComponent } from './components/add/add.component';
import { FormsModule }   from '@angular/forms';
import { SearchFilterPipe } from './pipes/searchfilter.pipe';
import { LoginComponent } from './components/login/login.component';
import { AlertComponent } from './components/alert/alert.component';
import { AlertService } from './services/alert.service';

@NgModule({
  declarations: [
    AppComponent,
    PostListComponent,
    AddComponent,
    SearchFilterPipe,
    LoginComponent,
    AlertComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [AlertService],
  bootstrap: [AppComponent]
})
export class AppModule { }
