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

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AccountingComponent,
    TimetableComponent,
    DashboardComponent,
    HeaderComponent,
    WidgetComponent,
    ElementComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
