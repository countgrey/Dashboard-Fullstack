export interface Data {
  id: number;
  name: string;
  value: number;
  tvalue: string;
  headers: string[];
  rows: string[][];
  labels: string[];
  series: Series[];
}

interface Series {
  type: string;
  data: number[];
}
