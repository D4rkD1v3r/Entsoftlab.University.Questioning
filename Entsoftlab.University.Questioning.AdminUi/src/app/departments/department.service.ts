import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DepartmentModel } from "../models/departmentModel";

import 'rxjs/add/operator/map';

@Injectable()
export class DepartmentService {
  private baseAddress:string;
  constructor(private http: HttpClient) {
    this.baseAddress = "api/department";
  }

  public getDepartments() {
    return this.http.get(this.baseAddress);
  }

  public createDepartment(department: DepartmentModel) {
    return this.http.post(this.baseAddress, department);
  }

  public editDepartment(department: DepartmentModel) {
    return this.http.put(this.baseAddress, department);
  }

  public removeDepartment(departmentId: string) {
    let apiUrl = this.baseAddress + "/" + departmentId;
    return this.http.delete(apiUrl).subscribe();
  }
}
