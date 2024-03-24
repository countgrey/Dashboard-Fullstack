import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Dashboard } from '../../models/dashboard.model';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  constructor(private http: HttpClient) { }

  getData(url: string): Observable<Dashboard> {
    const data = this.http.get <Dashboard>(url);

    return data;
  }
}
