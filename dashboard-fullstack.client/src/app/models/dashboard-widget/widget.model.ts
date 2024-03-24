import { WidgetElement } from "./widget-element.model";

export interface Widget {
  name: string;
  position: string;
  elements: WidgetElement[];
  id: number;
}
