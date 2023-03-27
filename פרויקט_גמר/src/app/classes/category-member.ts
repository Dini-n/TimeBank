import { Category } from "./category";
import { Member } from "./member";
import { ReportsAndDetails } from "./reports-and-details";

export class CategoryMember {
    public reports:Array<ReportsAndDetails>=[];
    constructor(
        public  category :Category,
        public  Place :string,
        public  PossibilityComeCustomerHome :boolean,
        public  ExperienceYears:string,
        public  RestrictionsDescription :string,
        public  forGroup:boolean,
        public  minGroup:number,
        public  maxGroup:number,
      
    )
{}}