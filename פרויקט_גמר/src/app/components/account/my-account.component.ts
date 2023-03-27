import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/classes/member';
import { CurrentUserService } from 'src/app/services/current-user.service';
import { MemberConnectService } from 'src/app/services/member-connect.service';
import { NewMemberComponent } from '../view-member/new-member/new-member.component';

@Component({
  selector: 'app-my-account',
  templateUrl: './my-account.component.html',
  styleUrls: ['./my-account.component.css']
})
export class MyAccountComponent implements OnInit {
  currentMember:any
  constructor(private curMemberService:CurrentUserService,private memberCon:MemberConnectService) { 
    this.returnCurrent();
  }
 
  ngOnInit(): void {
  }
  getRemainTime(mem:Member){
    return(mem.remainingHours.hours + ":" + mem.remainingHours.minutes);
   }

   s:string | null=sessionStorage.getItem("currentUser");
   phone:string="";
   returnCurrent(){
    if(this.s!=null){
      this.phone=this.s;
    this.memberCon.getMemberByPhone(this.phone).subscribe(
 
   (data)  => 
    {
     if(data == null)
     alert("חבר אינו מופיע במערכת אנא בדוק את תקינות הקלט או הגש מועמדות להיות חבר בבנק");
     this.currentMember=data;
    },
    (err) => 
    {
      alert(err.message);
    }
  );
   }
         
  }
}
