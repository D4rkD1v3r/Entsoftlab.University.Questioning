import {Injectable} from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from 'rxjs/Rx';
import {FacultyModel} from "../models/facultyModel";

import 'rxjs/add/operator/map';

@Injectable()
export class FacultyService {
  constructor(private http: HttpClient) {

  }

  getFaculties() {
    let apiUrl = 'api/Faculty';
    return this.http.get(apiUrl);
  }

  createFaculty(faculty: FacultyModel) {
    let apiUrl = 'http://localhost:5000/api/faculty';
    return this.http.post(apiUrl, faculty);
  }
}
