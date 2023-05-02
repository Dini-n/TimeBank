import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ReportsAndDetails } from '../classes/reports-and-details';
import { UrlsService } from './urls.service';

@Injectable({
  providedIn: 'root'
})
export class ReportConnectService {

  
  reportController = "report/"
  constructor(private http:HttpClient , private urls:UrlsService) { }
 urlApi = this.urls.urlApi;


 getAllReport():Observable<Array<ReportsAndDetails>>
 {
   return this.http.get<Array<ReportsAndDetails>>(this.urlApi + this.reportController+"GetAllReport");
 }
addReport(rep:ReportsAndDetails):Observable<ReportsAndDetails>{
    return this.http.post<ReportsAndDetails>(this.urlApi + this.reportController+"addReport",rep);
}
}
