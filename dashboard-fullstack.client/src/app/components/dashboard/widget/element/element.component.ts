import { Component, OnInit, Input, ElementRef } from '@angular/core';
import { ElementType } from '../../../../models/dashboard-widget/widget-element.model';
import { Data } from '../../../../models/data.model';
import * as Highcharts from 'highcharts';

@Component({
  selector: 'app-element',
  templateUrl: './element.component.html',
  styleUrl: './element.component.css'
})
export class ElementComponent implements OnInit {

  @Input() data!: Data;
  @Input() type!: ElementType
  @Input() isPrivate: boolean = false;

  constructor(private elementRef: ElementRef) {

  }

  ngOnInit(): void {
    if (this.type === ElementType.Chart) {
      
    }
  }
  
}
