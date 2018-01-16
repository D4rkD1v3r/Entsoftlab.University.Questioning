import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatSort, MatTableDataSource } from '@angular/material';
import { MatDialog } from '@angular/material';
import { DepartmentService } from "./department.service"
import { DepartmentEditComponent } from "./department-edit.component";
import { ConfirmDialogComponent } from "../confirm-dialog/confirm-dialog.component";
import { DepartmentModel } from "../models/departmentModel";

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrls: ['./departments.component.css']
})
export class DepartmentsComponent implements OnInit {
  dataSource: MatTableDataSource<DepartmentModel>;
  displayedColumns = ['shortName', 'fullName', 'mainFullName', 'actions'];
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  ngOnInit(): void {
  }

  items: DepartmentModel[];

  constructor(private departmentService: DepartmentService, public dialog: MatDialog) {
    this.items = [];
  }

  private populateItems() {
    this.departmentService.getDepartments().subscribe(res => {
      this.items = res as DepartmentModel[];
      this.dataSource = new MatTableDataSource(this.items);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  ngAfterViewInit() {
    this.populateItems();
  }

  applyFilter(filterValue: string) {
    filterValue = filterValue.trim();
    filterValue = filterValue.toLowerCase();
    this.dataSource.filter = filterValue;
  }

  public addNewDepartment() {
    let dialogRef = this.dialog.open(DepartmentEditComponent, {
      data: new DepartmentModel(),
      width: '800px'
    });
    dialogRef.afterClosed().subscribe(result => {
      if (typeof (result) != typeof (Boolean)) {
        this.items.push(result);
        this.dataSource.data = this.items;
      }
    });
  }
  public editDepartment(departmentId: string) {
    let selectedDepartment = {};
    for (let item of this.items) {
      if (item.id === departmentId) {
        selectedDepartment = item;
      }
    }
    let dialogRef = this.dialog.open(DepartmentEditComponent, {
      data: Object.assign({}, selectedDepartment),
      width: '800px'
    });
    dialogRef.afterClosed().subscribe(result => {
      if (typeof (result) != typeof (Boolean)) {
        for (let item of this.items) {
          if (item.id === result.id) {
            item.mainFullName = result.mainFullName;
            item.fullName = result.fullName;
            item.shortName = result.shortName;
          }
        }
        this.dataSource.data = this.items;
      }
    });
  }

  public removeDepartment(departmentId: string) {
    let selectedDepartment: DepartmentModel;
    for (let item of this.items) {
      if (item.id === departmentId) {
        selectedDepartment = item;
      }
    }
    let dialogRef = this.dialog.open(ConfirmDialogComponent, {
      data: "Вы действительно хотите удалить эту кафедру: " + selectedDepartment.shortName,
      width: '800px'
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result === true) {
        let itemIndex = this.items.indexOf(selectedDepartment);
        if (itemIndex !== -1) {
          this.departmentService.removeDepartment(selectedDepartment.id);
          this.items.splice(itemIndex, 1);
          this.dataSource.data = this.items;
        }
      }
    });
  }
}
