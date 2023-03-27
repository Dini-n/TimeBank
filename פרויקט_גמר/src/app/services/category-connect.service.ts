import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../classes/category';
import { UrlsService } from './urls.service';

@Injectable({
  providedIn: 'root'
})
export class CategoryConnectService {
  categoryController = "category/"
  constructor(private http:HttpClient , private urls:UrlsService) { }
  urlApi = this.urls.urlApi;
  getAllCategory():Observable<Array<Category>>
  {
    return this.http.get<Array<Category>>(this.urlApi + this.categoryController+"getAllCategories");
  }
  addCategory(cat:Category):Observable<Category>{
     return this.http.post<Category>(this.urlApi + this.categoryController+"addCategory",cat);
  }
}
