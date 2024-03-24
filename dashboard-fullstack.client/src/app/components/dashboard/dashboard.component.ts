import { Component, OnInit } from '@angular/core';
import { DashboardService } from '../../services/dashboard/dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent implements OnInit {

  constructor(private dashboardService: DashboardService) { }
  
  public name: string = "Generic dashboard";
  public orgName: string = "Generic organization";
  public dashName: string = "";
  public positions: string[] = ["col-lg-4 col-md-6 col-sm-12",
                                "col-lg-4 col-md-6 col-sm-12",
                                "col-lg-4 col-md-6 col-sm-12",
                                "col-lg-12 col-md-6 col-sm-12"  ];
  ngOnInit(): void {
    
    const url = 'https://localhost:44366/Dashboard';
    this.dashboardService.getData(url).subscribe(data => {
      this.orgName = data[0].organization;
      this.dashName = data[0].name;
    });
}
}
