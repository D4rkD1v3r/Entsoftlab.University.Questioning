import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Rx';
import { FacultyModel } from "../models/facultyModel";

import 'rxjs/add/operator/map';

@Injectable()
export class FacultyService {
  constructor(private http: HttpClient) {

  }

  public getFaculties() {
    let apiUrl = 'api/faculty';
    return this.http.get(apiUrl);
  }

  public createFaculty(faculty: FacultyModel) {
    let apiUrl = 'api/faculty';
    return this.http.post(apiUrl, faculty);
  }

  public editFaculty(faculty: FacultyModel) {
    let apiUrl = 'api/faculty';
    return this.http.put(apiUrl, faculty);
  }

  public removeFaculty(facultyId: string) {
    let apiUrl = 'api/faculty/' + facultyId;
    return this.http.delete(apiUrl).subscribe();
  }
}
