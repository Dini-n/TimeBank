import { Component, Input, OnInit } from '@angular/core';
import { Category } from 'src/app/classes/category';
import { CategoryMember } from 'src/app/classes/category-member';
import { MemPlusCat } from 'src/app/classes/mem-plus-cat';
import { AllCategoriesService } from 'src/app/services/all-categories.service';
import { MemberConnectService } from 'src/app/services/member-connect.service';

@Component({
  selector: 'app-action-detiels',
  templateUrl: './action-detiels.component.html',
  styleUrls: ['./action-detiels.component.css']
})
export class ActionDetielsComponent implements OnInit {
  @Input() category:MemPlusCat=new MemPlusCat("","","",new Category("",0,false,0),"",false,"","",false,0,0);
  show:boolean = true;
  constructor(private membersCon:MemberConnectService) { 
    // this.category
  }
  ngOnInit(): void {
    console.log(this.category);
    
  }
}
