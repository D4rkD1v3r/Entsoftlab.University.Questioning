import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpModule } from '@angular/http';
import { NgModule } from '@angular/core';
import {
  DxDataGridModule,
  DxSelectBoxModule,
  DxCheckBoxModule
} from 'devextreme-angular';
import { MatTabsModule } from '@angular/material/tabs';


import { AppService } from './app.service'
import { FacultyService } from "./faculties/faculty.service"
import { AppComponent } from './app.component';
import { FacultiesComponent } from './faculties/faculties.component';


@NgModule({
  declarations: [
    AppComponent,
    FacultiesComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    BrowserAnimationsModule,
    DxDataGridModule,
    DxCheckBoxModule,
    DxSelectBoxModule,
    MatTabsModule
  ],
  providers: [AppService, FacultyService],
  bootstrap: [AppComponent]
})
export class AppModule { }
