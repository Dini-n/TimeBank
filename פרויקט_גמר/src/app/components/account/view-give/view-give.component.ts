import { Component, OnInit } from '@angular/core';
import { CategoryMember } from 'src/app/classes/category-member';
import { CurrentUserService } from 'src/app/services/current-user.service';

@Component({
  selector: 'app-view-give',
  templateUrl: './view-give.component.html',
  styleUrls: ['./view-give.component.css']
})
export class ViewGiveComponent implements OnInit {
  categoryMember:Array< CategoryMember>=[];
  constructor(private user:CurrentUserService) {
   this.categoryMember= user.currentMember.categories;
   }
  ngOnInit(): void {
  }

}
