import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/classes/category';
import { Receiver } from 'src/app/classes/receiver';
import { ReportsAndDetails } from 'src/app/classes/reports-and-details';
import { CurrentUserService } from 'src/app/services/current-user.service';
import { ReportConnectService } from 'src/app/services/report-connect.service';

@Component({
  selector: 'app-new-report',
  templateUrl: './new-report.component.html',
  styleUrls: ['./new-report.component.css']
})
export class NewReportComponent implements OnInit {
  len:number=0;
  //מקבל הפעולה
  receiver:Receiver=new Receiver("","")
  //דיווח
  report:ReportsAndDetails=new ReportsAndDetails(new Date(),{hours: 0,minutes:0} ,"",new Receiver("",""),false);
  //רשימת הקטגוריות של החבר ימופה כדי שלא יהיה סתם את הדיווחים עבור החבר בשביל רק  בחירת שמות הקטגוריות שלו
  listCategory:Array<Category>=[];
  //הקטגוריה שנבחרה נקבל משהמשתמש שם
  categoryName:string="";
 //בנאי
  constructor(private con:ReportConnectService ,public user:CurrentUserService) { }
  ngOnInit(): void {
    this.listCategory=this.user.currentMember.categories.map(c=>c.category);
    console.log(this.listCategory.toString());
    
  }
//פונקציית השמירה
  onSave(){
    this.report.receiver.phone=this.receiver.phone;
    //מציאת הקטגוריה שנבחרה ושלחיתה לסרויס שיוסיף לקטגוריה זו את הדיווח
    // this.category=this.user.currentMember.categories
    // .filter(c=>c.category.name==this.categoryName)
    // .map(c=>c.category)[0];
  //      this.con.addReport(this.categoryName,this.user.currentMember.phone,this.report).subscribe(     
  //       (data) => 
  //       {
  //         if(data == null)
  //           { alert("nooooo"); return;}
  //         alert("add");        
  //       },
  //       (err) => 
  //       {
  //         alert(err.message);
  //       }
  //     );
  // }

 
   }

}
