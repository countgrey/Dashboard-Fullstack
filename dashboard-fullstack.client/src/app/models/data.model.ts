export interface Data {
  id: number;
  name: string;
  values: dataValues[];
}

interface dataValues {
  name: string;
  value: number;
}
