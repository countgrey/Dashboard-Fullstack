import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-element',
  templateUrl: './element.component.html',
  styleUrl: './element.component.css'
})
export class ElementComponent implements OnInit {

  public data: string = 'SomeData';
  ngOnInit(): void {
      
  }
  
}
