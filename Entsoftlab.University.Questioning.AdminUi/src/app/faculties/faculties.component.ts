import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatSort, MatTableDataSource } from '@angular/material';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material';
import { FacultyService } from './faculty.service'
import { FacultyEditComponent } from "./faculty-edit.component";
import { ConfirmDialogComponent } from "../confirm-dialog/confirm-dialog.component";
import { FacultyModel } from '../models/facultyModel';


@Component({
  selector: 'app-faculties',
  templateUrl: './faculties.component.html',
  styleUrls: ['./faculties.component.css']
})
export class FacultiesComponent implements OnInit {
  dataSource: MatTableDataSource<FacultyModel>;
  displayedColumns = ['fullName', 'shortName', 'deanFullName', 'actions'];
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  ngOnInit(): void {
  }

  items: FacultyModel[];

  constructor(private facultyService: FacultyService, public dialog: MatDialog) {
    this.items = [];
  }

  private populateItems() {
    this.facultyService.getFaculties().subscribe(res => {
      this.items = res as FacultyModel[];
      this.dataSource = new MatTableDataSource(this.items);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  ngAfterViewInit() {
    this.populateItems();
  }

  applyFilter(filterValue: string) {
    filterValue = filterValue.trim(); // Remove whitespace
    filterValue = filterValue.toLowerCase(); // Datasource defaults to lowercase matches
    this.dataSource.filter = filterValue;
  }

  public addNewFaculty() {
    let dialogRef = this.dialog.open(FacultyEditComponent, {
      data: new FacultyModel(),
      width: '800px'
    });
    dialogRef.afterClosed().subscribe(result => {
      if (typeof (result) != typeof (Boolean)) {
        this.items.push(result);
        this.dataSource.data = this.items;
      }
    });
  }
  public editFaculty(facultyId: string) {
    let selectedFaculty = {};
    for (let item of this.items) {
      if (item.id === facultyId) {
        selectedFaculty = item;
      }
    }
    let dialogRef = this.dialog.open(FacultyEditComponent, {
      data: Object.assign({}, selectedFaculty),
      width: '800px'
    });
    dialogRef.afterClosed().subscribe(result => {
      if (typeof (result) != typeof (Boolean)) {
        for (let item of this.items) {
          if (item.id === result.id) {
            item.deanFullName = result.deanFullName;
            item.fullName = result.fullName;
            item.shortName = result.shortName;
          }
        }
        this.dataSource.data = this.items;
      }
    });
  }

  public removeFaculty(facultyId: string) {
    let selectedFaculty: FacultyModel;
    for (let item of this.items) {
      if (item.id === facultyId) {
        selectedFaculty = item;
      }
    }
    let dialogRef = this.dialog.open(ConfirmDialogComponent, {
      data: "Вы действительно хотите удалить этот факультет: " + selectedFaculty.shortName,
      width: '800px'
    });
    dialogRef.afterClosed().subscribe(result => {
      if (result === true) {
        let itemIndex = this.items.indexOf(selectedFaculty);
        if (itemIndex !== -1) {

          this.items.splice(itemIndex, 1);
          this.dataSource.data = this.items;
        }
      }
    });
  }

}
