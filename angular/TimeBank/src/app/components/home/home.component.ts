import { Component, OnInit } from '@angular/core';
// import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
// closeResult = '';private modalService: NgbModal
btnCont:string ="הצע מועמדות";
check:boolean=true;
constructor() { }

ngOnInit(): void {
}
}

