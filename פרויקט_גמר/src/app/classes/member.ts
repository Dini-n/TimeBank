import { Time } from "@angular/common";
import { CategoryMember } from "./category-member";

export class Member {
    public categories:Array<CategoryMember>=[];
    constructor(public name:string,
                public password:string,
                public mail:string , 
                public phone:string ,
                public address:string ,
                public yearBorn:number ,
                public gender:boolean ,
                public remainingHours:Time ,
                public active:boolean,
                public toCheck:boolean,
                
                     )
    {    }

}
