import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA} from '@angular/material';
import {FacultyModel} from '../models/facultyModel';
import {FacultyService} from './faculty.service'

@Component({
  selector: 'app-faculty-edit',
  templateUrl: './faculty-edit.component.html',
  styleUrls: ['./faculty-edit.component.css']
})
export class FacultyEditComponent implements OnInit {
  public currentItem: FacultyModel;

  constructor(@Inject(MAT_DIALOG_DATA) public data: any, private facultyService: FacultyService) {
  }

  ngOnInit() {
    this.currentItem = this.data;
  }

  public getPositiveResult() {
    if (this.currentItem.id == undefined) {
      this.facultyService.createFaculty(this.currentItem).subscribe(res => {
        this.currentItem.id = res as string;
      });
    } else {
      this.facultyService.editFaculty(this.currentItem).subscribe();
    }
  }
}
