import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { AccountingComponent } from './components/accounting/accounting.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { TimetableComponent } from './components/timetable/timetable.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'accounting', component: AccountingComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'timetable', component: TimetableComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
