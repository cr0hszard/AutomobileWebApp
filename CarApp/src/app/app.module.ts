import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { map } from "rxjs/operators";

import { AppComponent } from './app.component';
import { CarComponent } from './components/car/car.component';


@NgModule({
  declarations: [
    AppComponent,
    CarComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent,]
})
export class AppModule { }
