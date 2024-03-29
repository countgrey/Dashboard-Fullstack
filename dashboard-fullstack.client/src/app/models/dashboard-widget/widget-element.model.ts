import { Data } from '../data.model';
import { ChartData } from './chart.model';
import { KpiData } from './kpi.model';
import { TableData } from './table.model';

export interface WidgetElement {
  id: number;
  isPrivate: boolean;
  elementType: ElementType;
  data: Data;

}

export enum ElementType {
  None,
  Text,
  Line,
  Spline,
  Area,
  AreaSpline,
  Column,
  Bar,
  Pie,
  Scatter,
  Bubble,
  WindRose,
  BoxPlot,
  Table,
  Image,
  Dropdown,
  Checkbox,
  Radio,
  CustomHTML,
  Kpi
}
