import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/classes/member';
import { CurrentUserService } from 'src/app/services/current-user.service';
import { MemberConnectService } from 'src/app/services/member-connect.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private con:MemberConnectService, private curUser:CurrentUserService) { }
  newMember:Member = new Member("","","","","",1950,true , {hours:0,minutes:0},true,true);

  phone:string="";

  password:string="";
  ngOnInit(): void {
  }

  onSave(){
   this.con.getMemberByPhoneAndPass(this.phone,this.password).subscribe(

  (data)  => 
   {
    console.log(data);
   if(data == null)
    alert("חבר זה אינו מופיע במערכת אנא בדוק את תקינות הקלט או הגש מועמדות להיות חבר בבנק");
   
   if(data.gender == true)
    alert("ברוך הבא " + data.name)
  else
    alert("ברוכה הבאה " +data.name)
    //עדכון מי החבר העכשווי
    this.curUser.setCurrentUser(data);
    console.log(this.curUser.currentMember.name);  

   },
   (err) => 
   {
     alert(err.message);
   }
 );
  }

}
