import { Component, Input, OnInit, ViewChild, ComponentFactoryResolver } from '@angular/core';
import { DashboardWidgetService } from '../../../services/dashboard/widget/widget.service';
import { WidgetElement } from '../../../models/dashboard-widget/widget-element.model';


@Component({
  selector: 'app-widget',
  templateUrl: './widget.component.html',
  styleUrl: './widget.component.css'
})
export class WidgetComponent implements OnInit {

  constructor(public widgetService: DashboardWidgetService) { }

  ngOnInit(): void {
    this.widgetService.setPosition("col-lg-4 col-md-6 col-sm-12 mb-4");
    this.widgetService.setChartElements([]);
    this.widgetService.setTitle("Generic widget");
    this.widgetService.enableTitle(true);

    
  }
}
