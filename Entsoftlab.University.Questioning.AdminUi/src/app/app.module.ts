import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import { MatTabsModule } from '@angular/material/tabs';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSortModule } from '@angular/material/sort';
import { MatInputModule } from '@angular/material';
import { MatDialogModule } from '@angular/material/dialog';

import { AppService } from './app.service'
import { FacultyService } from "./faculties/faculty.service"
import { DepartmentService } from "./departments/department.service"
import { AppComponent } from './app.component';
import { FacultiesComponent } from './faculties/faculties.component';
import { FacultyEditComponent } from './faculties/faculty-edit.component';
import { ConfirmDialogComponent } from './confirm-dialog/confirm-dialog.component';
import { DepartmentsComponent } from './departments/departments.component';


@NgModule({
  declarations: [
    AppComponent,
    FacultiesComponent,
    FacultyEditComponent,
    ConfirmDialogComponent,
    DepartmentsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    MatTabsModule,
    MatIconModule,
    MatToolbarModule,
    MatButtonModule,
    MatTableModule,
    MatFormFieldModule,
    MatPaginatorModule,
    MatSortModule,
    MatInputModule,
    MatDialogModule
  ],
  entryComponents: [
    FacultyEditComponent,
    ConfirmDialogComponent
  ],
  providers: [AppService, FacultyService, DepartmentService],
  bootstrap: [AppComponent]
})
export class AppModule {
}
