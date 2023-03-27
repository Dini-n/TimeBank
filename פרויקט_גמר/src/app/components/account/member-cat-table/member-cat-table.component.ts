import { Component, OnInit } from '@angular/core';
import { CategoryMember } from 'src/app/classes/category-member';
import { CurrentUserService } from 'src/app/services/current-user.service';

@Component({
  selector: 'app-member-cat-table',
  templateUrl: './member-cat-table.component.html',
  styleUrls: ['./member-cat-table.component.css']
})
export class MemberCatTableComponent implements OnInit {

  constructor(private curUser:CurrentUserService) { }
  
  categories:Array<CategoryMember> = this.curUser.currentMember.categories;
  ngOnInit(): void {
    console.log(this.categories);
  }

}
