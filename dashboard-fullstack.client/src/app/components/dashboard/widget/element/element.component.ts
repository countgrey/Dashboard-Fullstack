import { Component, OnInit, Input } from '@angular/core';
import { ElementType } from '../../../../models/dashboard-widget/widget-element.model';
import { Data } from '../../../../models/data.model';

@Component({
  selector: 'app-element',
  templateUrl: './element.component.html',
  styleUrl: './element.component.css'
})
export class ElementComponent implements OnInit {

  @Input() data!: Data;
  @Input() type!: ElementType
  @Input() isPrivate: boolean = false;

  ngOnInit(): void {
    console.log(this.data);
  }
  
}
