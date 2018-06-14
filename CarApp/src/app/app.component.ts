import { Component } from '@angular/core';
import { RetrieveService} from 'src/app/services/retrieve.service';
import { HttpClient} from '@angular/common/http';
import { map } from "rxjs/operators"
import { Observable } from 'rxjs';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  readonly ROOT_URL='https://jsonplaceholder.typicode.com/posts/1';
  
  posts:Observable<any[]>;
  
  constructor(private http:HttpClient) { 
    console.log('Service Connected');
  }  
  ngOnInit() {
      this.posts=this.http.get<any[]>(this.ROOT_URL);
 
 
  }
 
}
