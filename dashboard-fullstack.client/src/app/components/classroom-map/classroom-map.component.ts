import { Component, OnInit, HostListener } from '@angular/core';

import { trigger, state, style, transition, animate } from '@angular/animations';

const classroomAnimation = trigger('fadeInOut', [
  state('in', style({ opacity: 1 })),
  transition(':enter', [
    style({ opacity: 0 }),
    animate(300)
  ]),
  transition(':leave',
    animate(300, style({ opacity: 0 })))
]);

const classroomHoverAnimation = trigger('hover', [
  transition(':enter', [
    style({ transform: 'scale(1)' }),
    animate('200ms', style({ transform: 'scale(1.1)' }))
  ]),
  transition(':leave', [
    animate('200ms', style({ transform: 'scale(1)' }))
  ])
]);


@Component({
  selector: 'app-classroom-map',
  templateUrl: './classroom-map.component.html',
  styleUrls: ['./classroom-map.component.css'],
  animations: [classroomAnimation, classroomHoverAnimation]
})
export class ClassroomMapComponent implements OnInit {

  isHovered: boolean = false;

  // Обработчик события наведения мыши на кабинет
  @HostListener('mouseenter') onMouseEnter() {
    this.isHovered = true;
  }

  // Обработчик события ухода мыши с кабинета
  @HostListener('mouseleave') onMouseLeave() {
    this.isHovered = false;
  }

  classrooms: any[] = [];

  constructor() { }

  ngOnInit(): void {
    // Пример данных о кабинетах с добавленными свойствами
    this.classrooms = [
      { id: 1, name: 'Classroom 101', x: 100, y: 100, size: 'Medium', type: 'Lecture Hall', capacity: 50, occupancy: 30 },
      { id: 2, name: 'Classroom 102', x: 200, y: 200, size: 'Small', type: 'Lab', capacity: 20, occupancy: 15 },
      { id: 3, name: 'Classroom 103', x: 300, y: 300, size: 'Large', type: 'Conference Room', capacity: 100, occupancy: 80 },
      // Добавьте другие кабинеты
    ];
  }

  getClassroomInfo(classroom: any): string {
    return `
      Name: ${classroom.name}
      Type: ${classroom.type}
      Size: ${classroom.size}
      Capacity: ${classroom.capacity}
      Occupancy: ${classroom.occupancy}
    `;
  }

  calculateWidth(classroom: any): number {
    // Пример вычисления ширины кабинета в зависимости от его размера
    switch (classroom.size) {
      case 'Small':
        return 50;
      case 'Medium':
        return 100;
      case 'Large':
        return 150;
      default:
        return 100; // По умолчанию
    }
  }

  calculateHeight(classroom: any): number {
    // Пример вычисления высоты кабинета
    return this.calculateWidth(classroom);
  }

}

