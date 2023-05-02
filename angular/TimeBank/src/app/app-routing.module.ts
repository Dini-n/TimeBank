import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { AboutComponent } from './components/about/about.component';
import { HomeComponent } from './components/home/home.component';
import { MyAccountComponent } from './components/account/my-account.component';
import { ReportsComponent } from './components/reports/reports.component';
import { SetActionComponent } from './components/set-action/set-action.component';
import { ViewMembersComponent } from './components/view-member/view-members/view-members.component';
import { HttpClientModule } from '@angular/common/http';
const routes: Routes = [

  {path:"", component:HomeComponent},

  // children:
  // [
  //   {}
  // ],
  {path:"about", component:AboutComponent},
  {path:"myAccount", component:MyAccountComponent},
  {path:"reports", component:ReportsComponent},
  {path:"get", component:SetActionComponent},
  {path:"viewMembers", component:ViewMembersComponent}

];
@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(routes),
    CommonModule ,
    HttpClientModule
  ]
})

export class AppRoutingModule { }





//ng g module app-routing --flat --module=app