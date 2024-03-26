import { Component, Input, OnInit} from '@angular/core';
import { WidgetElement } from '../../../models/dashboard-widget/widget-element.model';


@Component({
  selector: 'app-widget',
  templateUrl: './widget.component.html',
  styleUrl: './widget.component.css'
})
export class WidgetComponent implements OnInit {

  @Input() title: string = "Generic widget";
  @Input() elements!: WidgetElement[];
  

  constructor() { }

  ngOnInit(): void {
  }
}
