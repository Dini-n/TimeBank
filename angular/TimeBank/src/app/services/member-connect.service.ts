import { EventEmitter, Injectable, Output } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Member } from '../classes/member';
import { observable, Observable } from 'rxjs';
import { UrlsService } from './urls.service';

import {enableProdMode} from '@angular/core';

enableProdMode();


@Injectable({
  providedIn: 'root'
})
export class MemberConnectService {

  
 memberController = "member/"
  constructor(private http:HttpClient , private urls:UrlsService) { }
 urlApi = this.urls.urlApi;

 getAllMembers():Observable<Array<Member>>
 {
   return this.http.get<Array<Member>>(this.urlApi + this.memberController+"GetAllMembers");
 }
addMember(mem:Member):Observable<Member>{
    return this.http.post<Member>(this.urlApi + this.memberController+"addMember",mem);
}
approveMember(phone:string):Observable<number>{
 return this.http.put<number>(this.urlApi + this.memberController + "aproveMember/"+ phone , phone);
}
getMemberByPhone(phone:string):Observable<Member>{
 return this.http.get<Member>(this.urlApi + this.memberController+"getMemberByPhone/"+phone);
}
getMemberByPhoneAndPass(phone:string,pass:string):Observable<Member>{
  return this.http.get<Member>(this.urlApi + this.memberController+"getMemberByPhone/"+phone+"/"+pass);
 }
swichActive(phone:string,to:boolean):Observable<number>{
 return this.http.put<number>(this.urlApi + this.memberController + "swichActive/"+ phone +"/"+to, [phone,to]);
}
}