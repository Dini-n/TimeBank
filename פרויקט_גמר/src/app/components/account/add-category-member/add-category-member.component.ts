import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/classes/category';
import { CategoryConnectService } from 'src/app/services/category-connect.service';

@Component({
  selector: 'app-add-category-member',
  templateUrl: './add-category-member.component.html',
  styleUrls: ['./add-category-member.component.css']
})
export class AddCategoryMemberComponent implements OnInit {

  constructor(private con:CategoryConnectService) { }
  ngOnInit(): void {
  } 
  category:Category=new Category("",1,false,0);
  
  onSave(){
    {
  
      console.log(this.category);
        this.con.addCategory(this.category).subscribe(
        
          data => 
          {
            alert("add");
            //עדכון הרשימה בסרביס
            // this.con.refreshList(data);
            //רענון הרשימה בקומפ' הרשימה
            // this.con.emit();
  
          },
          err => 
          {
            alert(err.message);
          }
        );
    }
  }
}
