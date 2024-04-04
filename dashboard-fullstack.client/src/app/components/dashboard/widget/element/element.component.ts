import { Component, OnInit, Input, ElementRef, ViewChild, AfterViewInit } from '@angular/core';
import { ElementType } from '../../../../models/dashboard-widget/widget-element.model';
import { Data } from '../../../../models/data.model';
import Highcharts from 'highcharts';
import HC_exporting from 'highcharts/modules/exporting';

@Component({
  selector: 'app-element',
  templateUrl: './element.component.html',
  styleUrls: ['./element.component.css']
})
export class ElementComponent implements AfterViewInit {
  ElementType = ElementType;

  @ViewChild('chartContainer', { static: false }) chartContainer!: ElementRef;
  @Input() data!: Data;
  @Input() type!: ElementType;
  @Input() isPrivate: boolean = false;
  @Input() id!: number;

  ngAfterViewInit(): void {
    console.log(this.chartContainer.nativeElement.id);
    console.log('ID', this.id);
    if (this.id == this.chartContainer.nativeElement.id) {
      HC_exporting(Highcharts);

      let seriesOptions: Highcharts.SeriesOptionsType = {
        type: 'spline',
        name: 'Данные не определены',
        data: [1, 2, 5, 4, 5],
        borderWidth: 0
      };

      switch (this.type) {
        case ElementType.Line:
          seriesOptions = {
            type: 'line',
            name: 'Данные не определены',
            data: [1, 2, 5, 4, 5],
            borderWidth: 0
          };
          break;
        case ElementType.Spline:
          break;
        case ElementType.Area:
          // Добавьте соответствующие настройки для Area
          break;
        case ElementType.AreaSpline:
          // Добавьте соответствующие настройки для AreaSpline
          break;
        case ElementType.Column:
          seriesOptions = {
            type: 'column',
            name: 'Данные не определены',
            data: [1, 2, 5, 4, 5],
            borderWidth: 0
          };
          break;
        case ElementType.Bar:
          seriesOptions = {
            type: 'bar',
            name: 'Данные не определены',
            data: [1, 2, 5, 4, 10],
            borderWidth: 0
          };
          break;
        case ElementType.Pie:
          // Добавьте соответствующие настройки для Pie
          break;
        case ElementType.Scatter:
          // Добавьте соответствующие настройки для Scatter
          break;
        case ElementType.Bubble:
          // Добавьте соответствующие настройки для Bubble
          break;
        case ElementType.WindRose:
          // Добавьте соответствующие настройки для WindRose
          break;
        case ElementType.BoxPlot:
          // Добавьте соответствующие настройки для BoxPlot
          break;
        default:
          console.error(`Неизвестный тип элемента: ${this.type}`);
          return;
      }

      const chartOptions: Highcharts.Options = {
        chart: {
          type: 'column',
          backgroundColor: 'rgba(255, 255, 255, 0)',
          height: 150
        },
        credits: {
          enabled: false
        },
        title: {
          text: ''
        },
        legend: {
          enabled: false
        },
        xAxis: {
          categories: ['A', 'B', 'C', 'D', 'E'],
          gridLineWidth: 0,
          labels: {
            style: {
              textOutline: '0px',
              color: '#ffffff'
            }
          }
        },
        yAxis: {
          title: {
            text: '',
            style: {
              color: '#ffffff',
              textOutline: '0px'
            }
          },
          gridLineWidth: 0,
          labels: {
            style: {
              color: '#ffffff'
            }
          }
        },
        series: [seriesOptions]
      };

      const chartElement = this.chartContainer.nativeElement;

      if (chartElement.id == this.id) {
        Highcharts.chart(chartElement, chartOptions);
      } else {
        console.error(`Элемент с идентификатором ${this.id} не найден.`);
      }
    }
  }
}
