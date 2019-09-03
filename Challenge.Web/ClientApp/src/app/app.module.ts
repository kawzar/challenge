import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PostListComponent } from './components/post-list/post-list.component';
import { AddComponent } from './components/add/add.component';
import { FormsModule }   from '@angular/forms';
import { SearchFilterPipe } from './pipes/searchfilter.pipe';

@NgModule({
  declarations: [
    AppComponent,
    PostListComponent,
    AddComponent,
    SearchFilterPipe
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
