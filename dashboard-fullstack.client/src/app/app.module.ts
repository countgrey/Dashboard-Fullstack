import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { AccountingComponent } from './components/accounting/accounting.component';
import { TimetableComponent } from './components/timetable/timetable.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { HeaderComponent } from './components/header/header.component';
import { WidgetComponent } from './components/dashboard/widget/widget.component';
import { ElementComponent } from './components/dashboard/widget/element/element.component';
import * as HighchartsMore from 'highcharts/highcharts-more';
import * as HighchartsExporting from 'highcharts/modules/exporting';
import * as Highcharts from 'highcharts';
import { ClassroomMapComponent } from './components/classroom-map/classroom-map.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatTabsModule } from '@angular/material/tabs';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AccountingComponent,
    TimetableComponent,
    DashboardComponent,
    HeaderComponent,
    WidgetComponent,
    ElementComponent,
    ClassroomMapComponent,
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, MatTooltipModule, MatTabsModule, BrowserAnimationsModule,
    ReactiveFormsModule
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
