import { Time } from "@angular/common";
import { Receiver } from "./receiver";

export class ReportsAndDetails {

    constructor(public date:Date,
    public time:Time,
    public note:string,
    public receiver:Receiver,
    public recieverApproved:boolean){}
}
