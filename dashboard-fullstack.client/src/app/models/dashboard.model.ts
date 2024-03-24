import { Widget } from "./dashboard-widget/widget.model";

export interface Dashboard {
  name: string
  id: number;
  organization: string;
  widgets: Widget[];
}
