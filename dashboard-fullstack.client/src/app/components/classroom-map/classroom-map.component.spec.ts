import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClassroomMapComponent } from './classroom-map.component';

describe('ClassroomMapComponent', () => {
  let component: ClassroomMapComponent;
  let fixture: ComponentFixture<ClassroomMapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ClassroomMapComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ClassroomMapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
