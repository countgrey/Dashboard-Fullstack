import { Component, OnInit, Input, ElementRef, ViewChild, AfterViewInit } from '@angular/core';
import { ElementType } from '../../../../models/dashboard-widget/widget-element.model';
import { Data } from '../../../../models/data.model';
import Highcharts from 'highcharts';
import HC_exporting from 'highcharts/modules/exporting';

@Component({
  selector: 'app-element',
  templateUrl: './element.component.html',
  styleUrl: './element.component.css'
})



export class ElementComponent implements AfterViewInit {
  ElementType = ElementType;

  @ViewChild('chartContainer', { static: false }) chartContainer!: ElementRef;
  @Input() data!: Data;
  @Input() type!: ElementType
  @Input() isPrivate: boolean = false;
  @Input() id!: number;

  ngAfterViewInit(): void {

    console.log(this.chartContainer.nativeElement.id);
    console.log(this.id);
    if (this.id == this.chartContainer.nativeElement.id) {
      // Импортируем необходимые модули Highcharts
      HC_exporting(Highcharts);



      const seriesOptions: Highcharts.SeriesSplineOptions = {
        type: 'spline', // указываем тип серии
        name: 'Данные не определены',
        data: [1, 2, 5, 4, 5],
        borderWidth: 0
      };

      switch (this.type) {
        case ElementType.Line:
          const seriesOptions: Highcharts.SeriesLineOptions = {
            type: 'line', // указываем тип серии
            name: 'Данные не определены',
            data: [1, 2, 5, 4, 5],
            borderWidth: 0
          };
          break;
        case ElementType.Spline:
          break;
        case ElementType.Area:
          break;
        case ElementType.AreaSpline:
          break;
        case ElementType.Column:
          break;
        case ElementType.Bar:
          break;
        case ElementType.Pie:
          break;
        case ElementType.Scatter:
          break;
        case ElementType.Bubble:
          break;
        case ElementType.WindRose:
          break;
        case ElementType.BoxPlot:
          break;
      }

      






      // Создаем объект настроек для графика
      const chartOptions: Highcharts.Options = {
        chart: {
          type: 'column',
          backgroundColor: 'rgba(255, 255, 255, 0)', // прозрачный фон
          height: 150 // ограничиваем высоту графика
        },
        credits: {
          enabled: false // отключаем кредиты
        },
        title: {
          text: ''
        },
        legend: {
          enabled: false // убираем легенду
        },
        xAxis: {
          categories: ['A', 'B', 'C', 'D', 'E'],
          gridLineWidth: 0,
          labels: {
            style: {
              textOutline: '0px', // убираем обводку для подписей по оси X
              color: '#ffffff' // делаем шрифт белым для подписей по оси X
            }
          }
        },
        yAxis: {
          title: {
            text: '',
            style: {
              color: '#ffffff', // делаем шрифт белым для подписей по оси X
              textOutline: '0px' // убираем обводку для заголовка оси Y
            }
          },
          gridLineWidth: 0,
          labels: {
            style: {
              color: '#ffffff' // делаем шрифт белым для подписей по оси Y
            }
          }
        },
        series: [
          seriesOptions
        ]
      };




      const chartElement = this.chartContainer.nativeElement;





      // Проверяем, что элемент существует
      if (chartElement.id == this.id) {
        // Создаем компонент графика
        Highcharts.chart(chartElement, chartOptions);
      } else {
        console.error(`Элемент с идентификатором ${this.id} не найден.`);
      }
    }
   
  }

  @ViewChild('chartElem', { static: false }) myElementRef!: ElementRef;
  
}
