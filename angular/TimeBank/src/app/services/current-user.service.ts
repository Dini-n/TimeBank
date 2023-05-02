import { Injectable } from '@angular/core';
import { Member } from '../classes/member';

@Injectable({
  providedIn: 'root'
})
export class CurrentUserService {
currentMember:Member = new Member("","","","","",1950,true , {hours:0,minutes:0},true,true);
  constructor() { }
  setCurrentUser(m:Member){
  this.currentMember = m;
  }
}



