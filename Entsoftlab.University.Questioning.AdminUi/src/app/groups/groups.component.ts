import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrls: ['./groups.component.css']
})
export class GroupsComponent implements OnInit {
  displayedColumns = ['name', 'course', 'teachFormName', 'facultyName', 'stateName', 'actions'];
  constructor() { }

  ngOnInit() {
  }

}
