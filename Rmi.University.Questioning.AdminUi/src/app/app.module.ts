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
import { AppComponent } from './app.component';


@NgModule({
  declarations: [
    AppComponent
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
  providers: [AppService],
  bootstrap: [AppComponent]
})
export class AppModule { }
