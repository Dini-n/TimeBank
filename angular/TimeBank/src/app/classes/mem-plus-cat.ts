import { Category } from "./category";

export class MemPlusCat {
    constructor(
        public memGiverName:string,
        public memPhone:string,
        public memEmail:string,
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

