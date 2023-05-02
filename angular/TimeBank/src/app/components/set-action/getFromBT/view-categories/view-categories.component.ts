import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/classes/category';
import { CategoryConnectService } from 'src/app/services/category-connect.service';

@Component({
  selector: 'app-view-categories',
  templateUrl: './view-categories.component.html',
  styleUrls: ['./view-categories.component.css']
})
export class ViewCategoriesComponent implements OnInit {
  category:Array<Category> = [];
  constructor(private con:CategoryConnectService) { }

  ngOnInit(): void {
    this.start();
  }
  

addData(){

}
removeData(){

}
  start(){
   this.loadData();
    }
 // פונקציה שמקבלת את תוצאות הקריאה מהשרת ומפרקת למקרה של הצלחה וכישלון
  loadData()
  {
   this.con.getAllCategory().subscribe(
   (myData)=>
   { 
    this.category = myData;
    },
    (myErr)=>
    {  alert(myErr.message);}
   );
  }
}
