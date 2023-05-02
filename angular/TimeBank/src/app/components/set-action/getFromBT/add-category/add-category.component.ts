import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/classes/category';
import { CategoryConnectService } from 'src/app/services/category-connect.service';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnInit {

  constructor(private con:CategoryConnectService) { }
  ngOnInit(): void {
  } 
  category:Category=new Category("",0,false,0);
  
  onSave(){
    {
      console.log(this.category);

         this.con.addCategory(this.category).subscribe(
          (data) => 
          {
            alert("add");  
          },
          (err) => 
          {
            alert(err.message);
          }
         );
    }
  }
}
