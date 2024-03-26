import { Data } from '../data.model';
import { ChartData } from './chart.model';
import { KpiData } from './kpi.model';
import { TableData } from './table.model';

export interface WidgetElement {
  id: number;
  isPrivate: boolean;
  elemType: ElementType;
  data: Data;
}

export enum ElementType {
  None,
  Text,
  Chart,
  Table,
  Image,
  Dropdown,
  Checkbox,
  Radio,
  CustomHTML,
  Kpi
}
