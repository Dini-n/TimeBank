import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Category } from 'src/app/classes/category';
import { CategoryMember } from 'src/app/classes/category-member';
import { MemPlusCat } from 'src/app/classes/mem-plus-cat';
import { AllCategoriesService } from 'src/app/services/all-categories.service';

@Component({
  selector: 'app-set-action',
  templateUrl: './set-action.component.html',
  styleUrls: ['./set-action.component.css']
})
export class SetActionComponent implements OnInit {

  key:string[] = Object.keys(CategoryMember);

  isChack:boolean=false;
  categories:Map<string,Array<MemPlusCat>> = new Map<string,Array<MemPlusCat>>();
  values:Array<Array<MemPlusCat>>=[];
  keys:Array<string> =[]
  toMap:boolean = true;
   selectedCat:MemPlusCat  = new MemPlusCat("","","",new Category("",0,false,0),"",false,"","",false,0,0);
  constructor(private CategoriesCon:AllCategoriesService,private router:Router) { 
  }
  ngOnInit(): void {
    this.loadData();
  }
  loadData()
  {
    
   this.CategoriesCon.getAllValues().subscribe(
   (myData)=>
   { 
   this.values = myData;
   console.log(this.values);
   this.CategoriesCon.getAllKeys().subscribe(
    (myData)=>{
      this.keys = myData;
      console.log(this.keys);
      for(let i=0;i<this.keys.length;i++)
      this.categories.set(this.keys[i],this.values[i]);
      console.log(this.categories);
    },
   (myErr)=>
    {  alert(myErr.message);}
   )  
     },
     (myErr)=>
     {  alert(myErr.message);}
    );
   
  }
  detiels(cat:MemPlusCat){
    this.isChack=!this.isChack;
    this.selectedCat = cat;
  }
}

