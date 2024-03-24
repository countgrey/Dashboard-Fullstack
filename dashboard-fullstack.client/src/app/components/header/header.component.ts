import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent {
  @Input() organizationName: string = "Generic organization";
  @Input() dashboardName: string = "Generic name";
}
