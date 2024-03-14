import { ChartData } from './chart.model';
import { KpiData } from './kpi.model';
import { TableData } from './table.model';

export interface WidgetElement {
  height: number; //В процентах
  type: string; // kpi, table, chart
  data?: any;
}
