import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule, routingComponents, userComponents, adminComponents , mentorComponents} from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './shared/home/home.component';
import { NavComponent } from './shared/nav/nav.component';
import { MentorService } from './service/mentor/mentor.service';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavComponent,
    routingComponents,
    userComponents,
    adminComponents,
    mentorComponents
    

 

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [MentorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
