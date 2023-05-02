import { Component, OnInit } from '@angular/core';
import { CategoryMember } from 'src/app/classes/category-member';
import { CurrentUserService } from 'src/app/services/current-user.service';

@Component({
  selector: 'app-member-categoties',
  templateUrl: './member-categoties.component.html',
  styleUrls: ['./member-categoties.component.css']
})
export class MemberCategotiesComponent implements OnInit {

  constructor(private curUser:CurrentUserService) { }
  categories:Array<CategoryMember> = this.curUser.currentMember.categories;
  ngOnInit(): void {
  }

}
