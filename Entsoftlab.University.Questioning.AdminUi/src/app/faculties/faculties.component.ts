import {Component, OnInit, ViewChild} from '@angular/core';
import {MatPaginator, MatSort, MatTableDataSource} from '@angular/material';
import {MatDialog, MAT_DIALOG_DATA} from '@angular/material';
import {FacultyService} from './faculty.service'
import {FacultyEditComponent} from "./faculty-edit.component";
import {FacultyModel} from '../models/facultyModel';


@Component({
  selector: 'app-faculties',
  templateUrl: './faculties.component.html',
  styleUrls: ['./faculties.component.css']
})
export class FacultiesComponent implements OnInit {
  dataSource: MatTableDataSource<FacultyModel>;
  displayedColumns = ['fullName', 'shortName', 'deanFullName'];
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
      if (typeof(result)!=typeof(Boolean))
      {
        // for (let item of this.items)
        // {
        //   if (item.id==result.id)
        //   {
        //     item.deanFullName=result.deanFullName;
        //     item.fullName=result.fullName;
        //     item.shortName=result.shortName;
        //   }
        // }
        this.items.push(result);
        this.dataSource.data=this.items;
      }
    });
  }

}
