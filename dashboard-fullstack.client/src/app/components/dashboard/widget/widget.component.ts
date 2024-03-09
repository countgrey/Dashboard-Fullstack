import { Component } from '@angular/core';

@Component({
  selector: 'app-widget',
  templateUrl: './widget.component.html',
  styleUrl: './widget.component.css'
})
export class WidgetComponent {
  public widgetName: string = "Generic widget";
  public titleIsVisible: boolean = true;
  public widgetSize: string = "col-lg-4 col-md-6 col-sm-12 mb-4";
}
