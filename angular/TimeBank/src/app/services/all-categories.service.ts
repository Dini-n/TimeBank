import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../classes/category';
import { CategoryMember } from '../classes/category-member';
import { MemPlusCat } from '../classes/mem-plus-cat';
import { UrlsService } from './urls.service';

@Injectable({
  providedIn: 'root'
})
export class AllCategoriesService {
  categoryController = "memberCategory/"
  constructor(private http:HttpClient , private urls:UrlsService) { }
  urlApi = this.urls.urlApi;

  getAllKeys():Observable<Array<string>>
  {
  return this.http.get<Array<string>>(this.urlApi + this.categoryController+"getAllkeys");
  }

  getAllValues():Observable<Array<Array<MemPlusCat>>>
  {
    let h  = this.http.get<Array<Array<MemPlusCat>>>(this.urlApi + this.categoryController+"getAllValues");
  
    return h
  }
}
