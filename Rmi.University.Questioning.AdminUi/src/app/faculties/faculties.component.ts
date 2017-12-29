import { Component, OnInit } from '@angular/core';
import { FacultyService } from './faculty.service'


@Component({
  selector: 'app-faculties',
  templateUrl: './faculties.component.html',
  styleUrls: ['./faculties.component.css']
})
export class FacultiesComponent implements OnInit {
  ngOnInit(): void {  }

  items: any[];
  constructor(private facultyService: FacultyService) {
    this.items = [];
    this.populateItems();
  }

  populateItems() {
    this.facultyService.getFaculties().subscribe(res => {
      this.items = res;
    });
  }

}
