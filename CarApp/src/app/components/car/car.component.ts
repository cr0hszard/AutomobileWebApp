import { Component, OnInit } from '@angular/core';




@Component({
  selector: 'car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css']
})
export class CarComponent implements OnInit {
 
  Brand:string;
  ProductionYear:number;
  Id:number;
  ngOnInit() {
    
  
  }

  constructor() { }

  
 
}


