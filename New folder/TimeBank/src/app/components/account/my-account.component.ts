import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/classes/member';
import { CurrentUserService } from 'src/app/services/current-user.service';

@Component({
  selector: 'app-my-account',
  templateUrl: './my-account.component.html',
  styleUrls: ['./my-account.component.css']
})
export class MyAccountComponent implements OnInit {

  constructor(private curMemberService:CurrentUserService) { }
   currentMember:Member = this.curMemberService.currentMember;
  ngOnInit(): void {
  }
  getRemainTime(mem:Member){
    return(mem.remainingHours.hours + ":" + mem.remainingHours.minutes);
   }
}
