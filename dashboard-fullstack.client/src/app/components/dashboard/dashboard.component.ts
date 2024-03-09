import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
  public name: string = "Generic dashboard";
  public positions: string[] = ["col-lg-4 col-md-6 col-sm-12",
                                "col-lg-4 col-md-6 col-sm-12",
                                "col-lg-4 col-md-6 col-sm-12",
                                "col-lg-12 col-md-6 col-sm-12"  ];
}
