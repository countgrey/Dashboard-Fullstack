import { Component, OnInit } from '@angular/core';
import { DashboardService } from '../../services/dashboard/dashboard.service';
import { Dashboard } from '../../models/dashboard.model';
import { Router } from "@angular/router"
import sqlite3 from 'sqlite3'
import { open } from 'sqlite'

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})

export class DashboardComponent implements OnInit {

  dashboard!: Dashboard;

  constructor(private dashboardService: DashboardService, private router: Router) { }
  
  ngOnInit(): void {
    
    const url = 'https://localhost:44366/Dashboard';
    this.dashboardService.getData(url).subscribe((data: Dashboard) => {

      this.dashboard = data;
      console.log(data)
    });
}
}
