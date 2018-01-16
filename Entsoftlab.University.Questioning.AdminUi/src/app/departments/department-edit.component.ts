import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material';
import { DepartmentModel } from "../models/departmentModel";
import { DepartmentService } from "./department.service"

@Component({
  selector: 'app-department-edit',
  templateUrl: './department-edit.component.html',
  styleUrls: ['./department-edit.component.css']
})
export class DepartmentEditComponent implements OnInit {
  public currentItem: DepartmentModel;
  constructor( @Inject(MAT_DIALOG_DATA) public data: any, private departmentService: DepartmentService) {
  }

  ngOnInit() {
    this.currentItem = this.data;
  }

  public getPositiveResult() {
    if (this.currentItem.id == undefined) {
      this.departmentService.createDepartment(this.currentItem).subscribe(res => {
        this.currentItem.id = res as string;
      });
    } else {
      this.departmentService.editDepartment(this.currentItem).subscribe();
    }
  }
}
