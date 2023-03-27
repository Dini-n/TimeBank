import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Member } from 'src/app/classes/member';
import { MemberConnectService } from 'src/app/services/member-connect.service';

@Component({
  selector: 'app-view-members',
  templateUrl: './view-members.component.html',
  styleUrls: ['./view-members.component.css']
})
export class ViewMembersComponent implements OnInit {
members:Array<Member> = [];
btnCont:string="הכנס חבר חדש";
notCheck:boolean=false;
constructor(private con:MemberConnectService) { }

  ngOnInit(): void {
    this.start();
  }
  start(){
   this.loadData();
    }
 // פונקציה שמקבלת את תוצאות הקריאה מהשרת ומפרקת למקרה של הצלחה וכישלון
  loadData()
  {
   this.con.getAllMembers().subscribe(
   (myData)=>
   { 
    this.members = myData;
    },
    (myErr)=>
    {  alert(myErr.message);}
   );
  }
  //-------------פונקציות שמחזירות את הערכים בצורה קריאה---------//
  // מחזיר את הזמן
  getRemainTime(mem:Member){
   return(mem.remainingHours.hours + ":" + mem.remainingHours.minutes);
  }
// מחזיר את המין
  getGender(mem:Member){
    if(mem.gender == true)
       return 'ז';
      return 'נ';
  }
  // מחזיר האם פעיל או לא
  getActive(mem:Member){
    if(mem.active == true)
    return 'כן';
   return 'לא';
  }
  // פעולה שמאשרת חבר מסוים
  aproveMember(m:Member){
    let ans =  confirm(" האם אתה רוצה לאשר את החבר " + m.name + "\n" +" שמספרו " + m.phone);
    if(ans.valueOf()==true)
    {
      this.con.approveMember(m.phone).subscribe(
        (myData)=>
        { 
         alert("החבר אושר בהצלחה")
         this.refreshTableOfMembers();
         },
         (myErr)=>
         {  alert(myErr.message);}
        );
    }
  }
 
  
  removeMember(m:Member){
  // מוחק חבר מהרשימה כלומר קורא לפונ מחיקה מהסרביס ומפרק אותה
  }
  addMember(){
  // שם כאן את הקומפוננטה של הוספת חבר של המשתמש
  }
  
refreshTableOfMembers(){
  this.loadData();
}
switchActive(m:Member,b:boolean){
  let ans =  confirm(" האם אתה רוצה להפוך את מצב החבר " + m.name + "\n" +" שמספרו " + m.phone);
  if(ans.valueOf()==true)
  {
    this.con.swichActive(m.phone,b).subscribe(
      (myData)=>
      { 
       alert("מצב החבר התהפך")
       this.refreshTableOfMembers();
       },
       (myErr)=>
       {  alert(myErr.message);}
      );
  }
}
}

