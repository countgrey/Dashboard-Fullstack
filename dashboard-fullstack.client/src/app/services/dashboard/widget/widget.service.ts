import { Injectable } from '@angular/core';
import { WidgetElement } from '../../../models/dashboard-widget/widget-element.model';


@Injectable({
  providedIn: 'root'
})
export class DashboardWidgetService {

  widgetElement: WidgetElement = {
      type: 'kpi',
      data: {},
      height: 0
  };

  public position: string = "col-lg-4 col-md-6 col-sm-12 mb-4";
  public widgetElements: WidgetElement[] = [this.widgetElement];
  public title: string = "Generic widget";
  public titleEnabled: boolean = true;

  constructor() { }

  setPosition(position: string) {
    this.position = position;
  }

  setChartElements(widgetElements: any[]) {
    this.widgetElements = widgetElements;
  }

  setTitle(title: string) {
    this.title = title;
  }

  enableTitle(enabled: boolean) {
    this.titleEnabled = enabled;
  }

}
