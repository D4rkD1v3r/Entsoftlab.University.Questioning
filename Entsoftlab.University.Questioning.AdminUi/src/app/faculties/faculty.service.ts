import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Rx';

import 'rxjs/add/operator/map';
@Injectable()
export class FacultyService {
  constructor(private http: Http) {

  }
  getFaculties() {
    let apiUrl = 'api/Faculty';
    return this.http.get(apiUrl)
      .map((res: Response) => {
        return res.json();
      });
  }
}  
