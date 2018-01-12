import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FacultyModel } from "../models/facultyModel";

import 'rxjs/add/operator/map';

@Injectable()
export class FacultyService {
  private baseAddress: string;
  constructor(private http: HttpClient) {
    this.baseAddress = "api/faculty";
  }

  public getFaculties() {
    return this.http.get(this.baseAddress);
  }

  public createFaculty(faculty: FacultyModel) {
    return this.http.post(this.baseAddress, faculty);
  }

  public editFaculty(faculty: FacultyModel) {
    return this.http.put(this.baseAddress, faculty);
  }

  public removeFaculty(facultyId: string) {
    let apiUrl = this.baseAddress+"/" + facultyId;
    return this.http.delete(apiUrl).subscribe();
  }
}
